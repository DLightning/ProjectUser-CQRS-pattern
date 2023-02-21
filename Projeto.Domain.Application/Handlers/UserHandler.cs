using Projeto.Domain.Entities;
using Projeto.Domain.Repositories;

namespace Projeto.Domain.Application.Handlers
{
    public class UserHandler
    {

        private readonly IUserRepository _userRepository;

        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserEntity> Handler()
        {
            return _userRepository.GetAll();
        }
    }
}
