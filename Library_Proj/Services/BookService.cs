
using Coding_Challenge_Backend.Interfaces;
using Coding_Challenge_Backend.Models;
using System.Diagnostics.Metrics;

namespace Coding_Challenge_Backend.Services
{
    public class BookService:IBookService
    {
        private readonly IBookrepository _bookRepository;
        private readonly ILogger<BookService> _logger;

        public BookService(IBookrepository bookRepository, ILogger<BookService> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;
        }
        public async Task<Book> AddBook(Book book)
        {
            return await _bookRepository.Add(book);
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAsync();
        }

        public async Task<Book> GetBookById(int bookId)
        {
            return await _bookRepository.GetAsync(bookId);
        }

        public async Task<Book> RemoveBook(int bookId)
        {
            var book = await _bookRepository.GetAsync(bookId);
            if (book != null)
            {
                await _bookRepository.Delete(bookId);
                return book;
            }
            return null;
        }

        public async Task<Book> UpdateBook(Book book)
        {
            var _member = await _bookRepository.GetAsync(book.BookId);
            if (book != null)
            {
                _member = await _bookRepository.Update(book);
                return _member;
            }

            return null;
        }
    }
}

