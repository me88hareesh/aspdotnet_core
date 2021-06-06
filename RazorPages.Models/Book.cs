using System;

namespace RazorPages.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public int NoOfPages { get; set; }
        public string AuthorName { get; set; }
        public string CoverPage { get; set; }
        public string Description { get; set; }
        public BCategory BookCategory { get; set; }

    }
    public enum BCategory
    {
        Classics,
        Fiction,
        Suspense,
        Romance,
        Business,
        Travel
    }
}
