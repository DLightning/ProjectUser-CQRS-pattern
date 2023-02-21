using Projeto.Domain.Entities;
using Projeto.Domain.Infra.Contexts;
using Projeto.Domain.Interfaces.Repositories;

namespace Projeto.Domain.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext _context;

        public UserRepository(MyContext context)
        {
            _context = context;
        }

        public UserEntity AddUser(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public IQueryable<UserEntity> GetAll()
        {
            return _context.Users;
        }

        public UserEntity GetUser(Guid id)
        {
            return _context.Users.Find(id);
        }

        public UserEntity UpdateUser(UserEntity user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
        public void DeleteUser(UserEntity user) {
        
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
