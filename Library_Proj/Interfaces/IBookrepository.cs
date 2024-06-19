using Coding_Challenge_Backend.Models;

namespace Coding_Challenge_Backend.Interfaces
{
    public interface IBookrepository
    {
        public Task<Book> Add(Book book);
        public Task<Book> Update(Book book);
        public Task<Book> Delete(int bookId);
        public Task<List<Book>> GetAsync();
        public Task<Book> GetAsync(int bookId);
    }
}
