using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AZippy6.Models
{
    public class Member
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Member ID")]
        public int memberId { get; set; }
        [Display(Name = "Last Name")]
        public String lastName { get; set; }
        [Display(Name = "First Name")]
        public String firstName { get; set; }
        [Display(Name = "Street Address")]
        public String streetAddress { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        [Display(Name = "Zip code")]
        public Int32 zipCode { get; set; }
        [Display(Name = "Email")]
        public String emailAddress { get; set; }
        [Display(Name = "Home phone")]
        public String phoneHome { get; set; }
        [Display(Name = "Mobile phone")]
        public String phoneCell { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Membership Type Id")]
        public int membershipTypeId { get; set; }
        [Display(Name = "Employer")]
        public String employerCompanyName { get; set; }
        [Display(Name = "Employer Phone Number")]
        public string employerPhoneNumber { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int membershipStatusId { get; set; }
        [Display(Name = "Emergency Contact Name")]
        public String emergencyContactName { get; set; }
        [Display(Name = "Emergency Contact Phone Number")]
        public String emergencyContactPhone { get; set; }
        [Display(Name = "Emergency Contact Relationship")]
        public String emergencyContactRelationship { get; set; }
        [Display(Name = "Outstanding balance")]
        public double currentAmountOwed { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Primary Location Id")]
        public int primaryLocationId { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Primary Location")]
        public Location primaryLocation { get; set; }
        public MembershipStatus MembershipStatus { get; set; }

        public FitnessClass FitnessClass { get; set; }

    }
}
