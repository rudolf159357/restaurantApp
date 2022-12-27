using System.ComponentModel.DataAnnotations;

namespace restaurantApp.Models
{
    public class Soup
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; } = "type";

        public double  Price { get; set; }

    }
}
