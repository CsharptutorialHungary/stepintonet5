using AspNetDemo.Backend.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetDemo.Backend
{
    public class TodoDbContext: DbContext
    {
        public DbSet<Todo> Todos { get; }

        public TodoDbContext()
        {
            Todos = Set<Todo>();
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=tododb.db");
        }
    }
}
