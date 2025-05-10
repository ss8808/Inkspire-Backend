namespace Inksprie_Backend.Dtos
{
    public class BookDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public bool IsOnSale { get; set; }
        public decimal? DiscountPrice { get; set; }
    }
}
