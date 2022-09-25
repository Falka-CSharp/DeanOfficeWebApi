using Microsoft.EntityFrameworkCore;
using DeanOfficeWebApi.Models;

namespace DeanOfficeWebApi.Data
{
    public class DeanOfficeWebDbContext : DbContext
    {
        public DeanOfficeWebDbContext(DbContextOptions options)
            : base(options) {
        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<Teacher> Teachers => Set<Teacher>();

    }
}
