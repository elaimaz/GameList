using System;
using System.ComponentModel.DataAnnotations;

namespace GameList.Models
{
    public class Game
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [StringLength(30)]
        public string Genre { get; set; }
        [StringLength(30)]
        public string Plataform { get; set; }
        [StringLength(30)]
        public string Developer { get; set; }
        [StringLength(30)]
        public string Publisher { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Url]
        public string Image { get; set; }

    }
}
