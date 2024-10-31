using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly LMSDBContext _context;

        public HomeController(LMSDBContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var books = _context.Books
                                .Include(b => b.Author)
                                .ToList();
            return View(books);
        }

        [Authorize]
        [HttpPost]
        public IActionResult BorrowBook(int bookId)
        {
            var userId = User.Identity.Name;
            var user = _context.Users.FirstOrDefault(u => u.Username == userId);

            if (user == null)
            {
                return NotFound();
            }

            var borrowing = new Borrowing
            {
                BookId = bookId,
                UserId = user.UserId,
                BorrowedAt = DateTime.Now
            };

            _context.Borrowings.Add(borrowing);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminBorrowList()
        {
            var borrowings = _context.Borrowings
                                     .Include(b => b.Book)
                                     .Include(b => b.User)
                                     .ToList();

            return View("AdminBorrowList", borrowings);
        }

        [Authorize]
        public IActionResult UserBorrowList()
        {
            var userId = User.Identity.Name;
            var user = _context.Users.FirstOrDefault(u => u.Username == userId);

            if (user == null)
            {
                return NotFound();
            }

            var borrowings = _context.Borrowings
                                     .Include(b => b.Book)
                                     .Where(b => b.UserId == user.UserId)
                                     .ToList();

            return View("UserBorrowList", borrowings);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminDashboard()
        {
            var books = _context.Books
                                .Include(b => b.Author)
                                .ToList();
            return View(books);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AddBook()
        {
            ViewBag.Authors = _context.Authors.ToList();
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction("AdminDashboard");
            }

            ViewBag.Authors = _context.Authors.ToList();
            return View(book);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult UpdateBook(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            ViewBag.Authors = _context.Authors.ToList();
            return View(book);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult UpdateBook(Book updatedBook)
        {
            if (ModelState.IsValid)
            {
                // Fetch the existing book from the database
                var bookInDb = _context.Books.FirstOrDefault(b => b.BookId == updatedBook.BookId);
                if (bookInDb == null)
                {
                    return NotFound();
                }

                // Update properties
                bookInDb.Title = updatedBook.Title;
                bookInDb.AuthorId = updatedBook.AuthorId;

                _context.SaveChanges();
                return RedirectToAction("AdminDashboard");
            }

            ViewBag.Authors = _context.Authors.ToList();
            return View(updatedBook);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.BookId == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
            return RedirectToAction("AdminDashboard");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
