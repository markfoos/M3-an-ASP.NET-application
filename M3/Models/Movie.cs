using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace M3.Models
{
    public class Movie
    { 
        public int Id { get; set; }
        
        [StringLength(255)]
        [Required(ErrorMessage = "A Movie name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Genre is required")]
        public byte GenreId { get; set; }

        [Required(ErrorMessage = "A Release Date is Required, Example: Jun 1, 2010")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Movie Info is required")]
        public string Info { get; set; }

        [Required(ErrorMessage = "A 'Date Added' is required, Example: Jun 1, 2010")]
        public DateTime DateAdded { get; set; }

        [Range(0, 20, ErrorMessage = ("A value is required, Enter 0 if there is no stock"))]
        
        public int InStock { get; set; }

        public Genre Genre { get; set; }

    }
}