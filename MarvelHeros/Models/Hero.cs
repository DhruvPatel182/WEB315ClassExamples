using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarvelHeros.Models
{
    public class Hero
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Date got their powers")]
        [DataType(DataType.Date)]
        public DateTime PowerAcquisitionDate { get; set; }

        [Display(Name = "Secret Identity")]
        public string SecretIdentity { get; set; }

        [Range(1, 100)]
        public decimal Age { get; set; }

        [Display(Name = "Country of Origin")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string CountryOfOrigin { get; set; }
        // public string Firstname { get; set; } // this is an auto property
        // public string Lastname { get; set; }

        // public string Fullname { get{
        //     return Firstname + " " + Lastname;
        //     } set{
        //         Firstname = value;
        //     } 
        // }

    }
}