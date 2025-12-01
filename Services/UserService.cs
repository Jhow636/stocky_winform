using Stocky.Models;

namespace Stocky.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();
        private int _nextId = 1;

        public User Register(string email, string password, Role role = Role.User)
        {
            var user = new User { Id = _nextId++, Email = email, Password = password, Role = role };
            _users.Add(user);
            return user;
        }

        public User? Login(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public List<User> GetAll() => _users.ToList();
    }
}
