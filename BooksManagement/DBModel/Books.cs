using System.ComponentModel.DataAnnotations;

namespace BooksManagement.DBModel
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string author { get; set; }

        [Required]
        public int publishedYear { get; set; }

        public float price { get; set; }
    }
}
