﻿using Projeto.Domain.Enums;

namespace Projeto.Domain.Entities
{
    public class UserEntity
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
        public DateTime InclusionDate { get; set; }
        public DateTime AlterationDate { get; set; }
        public EnumStatus Status { get; set; }
    }
}
