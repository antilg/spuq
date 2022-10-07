using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EinzelaufageB.Model
{
    public class Logbook
    {
        [JsonIgnore]
        public int Id { get; set; }
        [Required]
        public string? Driver { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [Required]
        public int? Distance { get; set; }
        public Logbook(string? driver, string? description, DateTime start, DateTime end, int? distance)
        {
            Driver = driver;
            Description = description;
            Start = start;
            End = end;
            Distance = distance;
        }
    }
}
