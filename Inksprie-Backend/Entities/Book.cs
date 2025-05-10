using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Inksprie_Backend.Entities
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Title { get; set; }

        public string? Author { get; set; }

        public string? Genre { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string? Language { get; set; }

        public string? Format { get; set; }

        public string? ISBN { get; set; }

        public string? Publisher { get; set; }

        public string? Description { get; set; }

        public DateTime PublishedDate { get; set; }

        public bool IsOnSale { get; set; }

        public decimal? DiscountPrice { get; set; }
    }
}
