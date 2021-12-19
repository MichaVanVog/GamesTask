using System.ComponentModel.DataAnnotations;

namespace Games.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        
        [Display(Name = "Название"), Required(ErrorMessage = "Название игры обязательно")]
        public string? Title { get; set; }
        
        [Display(Name = "Студия разработки"), Required(ErrorMessage = "Название студии разработки обязательно")]
        public string? DevelopersStudio { get; set; }
        
        [Display(Name = "Жанр"), Required(ErrorMessage = "Название жанра обязательно")]
        public string? Genre { get; set; }
    }
}
