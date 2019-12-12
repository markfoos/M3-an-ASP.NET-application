using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using M3.Models;

namespace M3.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A customer name is required.")]
        [StringLength(50)]
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

        public string phone_address { get; set; }

        [Required(ErrorMessage = "An email address is required.")]
        [EmailAddress(ErrorMessage = "An email address is required.")]

        public string email_address { get; set; }


     //   [ageValidation]

        public DateTime? birthdate { get; set; }

        public bool issubscribed { get; set; }




        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}