namespace personallib_be.Models
{
    public class Book
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public ICollection<Category> Categories { get; } = new List<Category>();
    }
}
