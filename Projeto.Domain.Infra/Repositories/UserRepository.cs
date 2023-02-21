using Projeto.Domain.Entities;
using Projeto.Domain.Infra.Contexts;
using Projeto.Domain.Repositories;

namespace Projeto.Domain.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyContext _context;

        public UserRepository(MyContext context)
        {
            _context = context;
        }

        public IEnumerable<UserEntity> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
