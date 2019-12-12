using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace M3.Models
{ 
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A customer name is required.")]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "A street address is required.")]
        public string street_address { get; set; }
        [Required(ErrorMessage = "A city is required.")]
        public string city_address { get; set; }
        [Required(ErrorMessage = "A state is required.")]
        [StringLength(2)]
        public string state_address { get; set; }
        [Required(ErrorMessage = "A zip code is required.")]
        public int? zip_address { get; set; }
        [Required(ErrorMessage = "A phone number is required.")]
        [Display(Name = "Phone number")]

        public string phone_address { get; set; }

        [Required(ErrorMessage = "An email address is required.")]
        [EmailAddress(ErrorMessage = "An email address is required.")]
        [Display(Name = "Email address")]

        public string email_address { get; set; }


        [ageValidation]
        [Display(Name = "Date of birth")]

        public DateTime? birthdate { get; set; }

        public bool issubscribed { get; set; }


        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}