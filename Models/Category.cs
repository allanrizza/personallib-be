using System.Text.Json.Serialization;

namespace personallib_be.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [JsonIgnore]
        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
