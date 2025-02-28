﻿using Library_Proj.Models;

namespace Library_Proj.Interfaces
{
    public interface IUserService
    {
        public Task<User> AddUser(User user);
        public Task<User> RemoveUser(int userId);
        public Task<User> GetUserById(int userId);
        public Task<List<User>> GetAllUsers();
        public Task<User> Updateuser(User user);
        public Task<User> LoginUser(string username, string password);
    }
}
