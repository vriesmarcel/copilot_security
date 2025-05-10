using AutoMapper;
using frontend.Models;
using System.Threading.Tasks;

namespace frontend.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByIdAsync(int id);
        Task UpdateUserAsync(User user);
    }
}
