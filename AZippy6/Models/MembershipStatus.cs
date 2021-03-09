using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AZippy6.Models
{
    public class MembershipStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int membershipStatusId { get; set; }
        public String membershipStatusDescription { get; set; }
    }
}
