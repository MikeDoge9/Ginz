using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ginz.Model
{
    public class Gin
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Grade { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
