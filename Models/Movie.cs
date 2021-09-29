using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(60,MinimumLength = 3)]
        [Required]
        [Column(TypeName="nvarchar(50)")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Email { get; set; }
        public string Rating { get; set; }

    }
}