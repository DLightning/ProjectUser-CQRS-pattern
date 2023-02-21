using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Infra.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>().ToTable("Users").HasKey(x => x.Id);
            modelBuilder.Entity<UserEntity>().Property(x => x.Name).HasMaxLength(128);
            modelBuilder.Entity<UserEntity>().Property(x => x.Cpf).HasMaxLength(14);
        }
    }
}
