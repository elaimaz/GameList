using System;
using System.ComponentModel.DataAnnotations;

namespace GameList.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Plataform { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

    }
}
