using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AZippy6.Models
{
    public class FitnessClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Fitness Class Id")]
        public int fitnessclassId { get; set; }
        [Display(Name = "Title of the Class")]
        public String fitnessclassTitle { get; set; }
        [Display(Name = "Class Description")]
        public String fitnessclassDescription { get; set; }
        [Display(Name = "Class duration")]
        public int fitnessclassDuration { get; set; }
        [Display(Name = "Approximate calories burned")]
        public int fitnessclassCaloriesBurnedApprox { get; set; }
        [Display(Name = "Maximum enrollees")]
        public int fitnessclassMaxEnrollees { get; set; }
        [Display(Name = "Class Fee")]
        public double fitnessclassFee { get; set; }

    }
}
