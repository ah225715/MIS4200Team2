using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class recognitions
    {
        [Key]
        public int recognitionId { get; set; }
        public Guid ID { get; set; }
        public virtual userProfile UserProfile { get; set; }

        [Required]
        [Display(Name = "Description of Recognition")]
        public string description { get; set; }

        [Required]
        [Display(Name = "Core Value Displayed")]
        public Values values { get; set; }

        public enum Values
        {
            Balance,
            Culture,
            [Display(Name = "Delivery Excellence")]
            DeliveryExcellence,
            [Display(Name = "Greater Good")]
            GreaterGood,
            Innovation,
            Integrity,
            Stewardship

        }

        
    }
}