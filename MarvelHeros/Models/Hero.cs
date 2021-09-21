using System;
using System.ComponentModel.DataAnnotations;

namespace MarvelHeros.Models
{
    public class Hero
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime PowerAcquisitionDate { get; set; }
        public string SecretIdentity { get; set; }
        public decimal Age { get; set; }
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