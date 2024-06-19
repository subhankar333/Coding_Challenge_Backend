
using Coding_Challenge_Backend.Context;
using Coding_Challenge_Backend.Interfaces;
using Coding_Challenge_Backend.Models;
using Library_Proj.Exceptions;
using System.Diagnostics.Metrics;

namespace Coding_Challenge_Backend.Repository
{
    public class BookRepository:IBookrepository
    {
        private readonly LibraryDbContext _context;
        private readonly ILogger<BookRepository> _logger;

        public BookRepository(LibraryDbContext context, ILogger<BookRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Book> Add(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
            _logger.LogInformation("Book added with BookId " + book.BookId);
            return book;
        }

        public async Task<Book> Delete(int bookId)
        {
            var book = await GetAsync(bookId);
            if (book != null)
            {
                _context.Remove(book);
                await _context.SaveChangesAsync();
                _logger.LogInformation($"Book removed with BookId {bookId}");
                return book;
            }
            throw new NoSuchBookException();
        }


        public async Task<Book> GetAsync(int bookId)
        {
            var books = await GetAsync();
            var book = books.FirstOrDefault(e => e.BookId == bookId);
            if (book != null)
            {
                return book;
            }
            throw new NoSuchBookException();
        }

        public async Task<List<Book>> GetAsync()
        {
            var members = _context.Books.ToList();
            return members;
        }

        public async Task<Book> Update(Book item)
        {
            var book = await GetAsync(item.BookId);
            if (book != null)
            {
                _context.Entry(book).CurrentValues.SetValues(item);
                _context.SaveChanges();
                _logger.LogInformation($"Book updated with BookId {item.BookId}");
                return book;
            }
            throw new NoSuchBookException();
        }
    }
}

