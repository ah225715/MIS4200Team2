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

        //ID of person being recognized
        public Guid ID { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey(name: "ID")]
        public virtual userProfile UserProfile { get; set; }

        [Required]
        [Display(Name = "Date of Recognition")]
        public DateTime DateOfRecognition { get; set; }

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