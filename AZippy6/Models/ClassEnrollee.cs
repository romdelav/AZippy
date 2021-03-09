using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AZippy6.Models
{
    public class ClassEnrollee
    {

        [Key]
        public int enrolledRegisrationId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? classSessionId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int? memberId { get; set; }

        public ClassSession ClassSession { get; set; }
        public Member Member { get; set; }

    }
}
