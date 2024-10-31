using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Borrowing
    {
        [Key]
        public int BorrowingId { get; set; }

        public int UserId { get; set; }
        public int BookId { get; set; }

        public DateTime BorrowedAt { get; set; }
        public DateTime? ReturnedAt { get; set; }

        public User User { get; set; }
        public Book Book { get; set; }
    }
}
