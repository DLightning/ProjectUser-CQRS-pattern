using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        IQueryable<UserEntity> GetAll();

        UserEntity AddUser(UserEntity user);

        UserEntity GetUser(Guid id);

        UserEntity UpdateUser(UserEntity user);

        void DeleteUser(UserEntity user);

    }


}
