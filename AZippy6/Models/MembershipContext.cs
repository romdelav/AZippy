using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AZippy6.Models
{
    public class MembershipContext : DbContext
    {
        public MembershipContext(DbContextOptions<MembershipContext> options) :
            base(options)
        { }

        // add a DbSet for each table (also referred to as an entity set )
        public DbSet<Member> Members { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MembershipStatus> MembershipStatuses { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<FitnessClass> FitnessClasses { get; set; }
        public DbSet<ClassSession> ClassSessions { get; set; }
        public DbSet<ClassEnrollee> ClassEnrollees { get; set; }



    }
}
