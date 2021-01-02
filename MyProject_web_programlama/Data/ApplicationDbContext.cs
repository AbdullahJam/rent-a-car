using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject_web_programlama.Models;

namespace MyProject_web_programlama.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Araba> Araba { get; set; }
        public DbSet<ArabaKira> ArabaKira { get; set; }
        public DbSet<Fotograf> Fotograf { get; set; }
        public DbSet<IlanKoy> IlanKoy { get; set; }
        public DbSet<Ofis> Ofis { get; set; }
        public DbSet<Ozellik> Ozellik { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<User> User { get; set; }
    }
}
