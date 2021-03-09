using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AZippy6.Models;

namespace AZippy6.Controllers
{
    public class ClassEnrolleesController : Controller
    {
        private readonly MembershipContext _context;

        public ClassEnrolleesController(MembershipContext context)
        {
            _context = context;
        }

        // GET: ClassEnrollees
        public async Task<IActionResult> Index()
        {
            var membershipContext = _context.ClassEnrollees.Include(c => c.ClassSession)
                .ThenInclude(g => g.FitnessClass)
                .Include(c => c.Member);
            return View(await membershipContext.ToListAsync());
        }
        // GET: ClassEnrollees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classEnrollee = await _context.ClassEnrollees
                .Include(c => c.ClassSession)
                .Include(c => c.Member)
                .Include(c => c.ClassSession.FitnessClass) //added to modify the CRUD
                .FirstOrDefaultAsync(m => m.enrolledRegisrationId == id);
            if (classEnrollee == null)
            {
                return NotFound();
            }

            return View(classEnrollee);
        }

        // GET: ClassEnrollees/Create
        public IActionResult Create()
        {
            var memlist = new List<SelectListItem>();
            var sessionlist = new List<SelectListItem>();

            foreach (var m in _context.Members)
                memlist.Add(new SelectListItem
                {
                    Text = m.firstName + " " + m.lastName,
                    Value = m.memberId.ToString()
                });
            ViewBag.listofmembers = memlist;

            foreach (var m in _context.ClassSessions.Include(f => f.FitnessClass))
                sessionlist.Add(new SelectListItem
                {
                    Text = m.FitnessClass.fitnessclassTitle,
                    Value = m.classSessionId.ToString()
                });
            ViewBag.listofclasses = sessionlist;

            //  ViewData["classSessionId"] = new SelectList(_context.ClassSessions, "classSessionId", "classSessionId");
            //  ViewData["memberId"] = new SelectList(_context.Members, "memberId", "memberId");
            //  ViewData["testing"] = new SelectList(_context.Members, "memberId", "lastName" );
            return View();
        }

        // POST: ClassEnrollees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnrollMember([Bind("enrolledRegisrationId,classSessionId,memberId")] ClassEnrollee classEnrollee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classEnrollee);
                await _context.SaveChangesAsync();

                // update Member's balance
                int memID = Int32.Parse(Request.Form["memberId"].ToString());
                int cID = Int32.Parse(Request.Form["classSessionId"].ToString());
                var mem = _context.Members.Where(m => m.memberId == memID).Single(); ;
                Member member = (Member)mem;
                var fclass = _context.ClassSessions.Where(c => c.classSessionId == cID).Include(f => f.FitnessClass).Single();
                FitnessClass fc = (FitnessClass)fclass.FitnessClass;
                double balance = member.currentAmountOwed + fc.fitnessclassFee;
                member.currentAmountOwed = balance;

                _context.Update(member);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            ViewData["classSessionId"] = new SelectList(_context.ClassSessions, "classSessionId", "classSessionId", classEnrollee.classSessionId);
            ViewData["memberId"] = new SelectList(_context.Members, "memberId", "memberId", classEnrollee.memberId);
            return View(classEnrollee);
        }

        // GET: ClassEnrollees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classEnrollee = await _context.ClassEnrollees.FindAsync(id);
            if (classEnrollee == null)
            {
                return NotFound();
            }

            ViewData["classSessionId"] = new SelectList(_context.ClassSessions, "classSessionId", "classSessionId", classEnrollee.classSessionId);
            ViewData["memberId"] = new SelectList(_context.Members, "memberId", "memberId", classEnrollee.memberId);
            return View(classEnrollee);
        }

        // POST: ClassEnrollees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("enrolledRegisrationId,classSessionId,memberId")] ClassEnrollee classEnrollee)
        {
            if (id != classEnrollee.enrolledRegisrationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classEnrollee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassEnrolleeExists(classEnrollee.enrolledRegisrationId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["classSessionId"] = new SelectList(_context.ClassSessions, "classSessionId", "classSessionId", classEnrollee.classSessionId);
            ViewData["memberId"] = new SelectList(_context.Members, "memberId", "memberId", classEnrollee.memberId);
            return View(classEnrollee);
        }

        // GET: ClassEnrollees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classEnrollee = await _context.ClassEnrollees
                .Include(c => c.ClassSession)
                .Include(c => c.Member)
                .Include(c => c.ClassSession.FitnessClass)
                .FirstOrDefaultAsync(m => m.enrolledRegisrationId == id);
            if (classEnrollee == null)
            {
                return NotFound();
            }

            return View(classEnrollee);
        }

        // POST: ClassEnrollees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var classEnrollee = await _context.ClassEnrollees.FindAsync(id);
            _context.ClassEnrollees.Remove(classEnrollee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassEnrolleeExists(int id)
        {
            return _context.ClassEnrollees.Any(e => e.enrolledRegisrationId == id);
        }
    }
}
