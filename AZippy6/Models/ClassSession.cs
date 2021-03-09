using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AZippy6.Models
{
    public class ClassSession
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int classSessionId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fitnessClassId { get; set; }
        public DateTime classSessionStartTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int locationId { get; set; }
        // NOTE IF WANT TO MAKE IT EASY NEED SAME ATTRIBUTE NAME AS IN LOCATION CLASS !

        public FitnessClass FitnessClass { get; set; }
        public Location Location { get; set; }
    }
}
