using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        
        public ICollection<Borrowing> Borrowings { get; set; }

        
    }
}
