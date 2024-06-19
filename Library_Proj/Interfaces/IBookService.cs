using Coding_Challenge_Backend.Models;
using System.Diagnostics.Metrics;

namespace Coding_Challenge_Backend.Interfaces
{
    public interface IBookService
    {
        public Task<Book> AddBook(Book book);
        public Task<Book> RemoveBook(int bookId);
        public Task<Book> GetBookById(int bookId);
        public Task<List<Book>> GetAllBooks();
        public Task<Book> UpdateBook(Book book);

    }
}