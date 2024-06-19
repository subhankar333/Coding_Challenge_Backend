using Library_Proj.Models;

namespace Library_Proj.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> Add(User user);
        public Task<User> Update(User user);
        public Task<User> Delete(int userId);
        public Task<List<User>> GetAsync();
        public Task<User> GetAsync(int userId);
        public Task<User> Login(string username, string password);
    }
}
