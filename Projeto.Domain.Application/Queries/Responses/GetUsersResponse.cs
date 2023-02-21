using Projeto.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Application.Queries.Responses
{
    public class GetUsersResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Cpf { get; set; }
        public string MotherName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public EnumStatus status { get; set; }
        public DateTime InclusionDate { get; set; }
        public DateTime AlterationDate { get; set; }
    }
}
