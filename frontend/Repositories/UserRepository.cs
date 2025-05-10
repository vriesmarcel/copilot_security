using frontend.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace frontend.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            // Simulate a database with an in-memory list
            _users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john.doe@example.com", IsAdmin = false },
                new User { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com", IsAdmin = true }
            };
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            return Task.FromResult(user);
        }

        public Task<User> GetUserByEmail(string email)
        {
            var user = _users.FirstOrDefault(u => u.Email == email);
            return Task.FromResult(user);
        }
        public Task UpdateUserAsync(User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.IsAdmin = user.IsAdmin;
            }
            return Task.CompletedTask;
        }
    }
}
