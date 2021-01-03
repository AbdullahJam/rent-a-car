using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web_Programlama.Models;

namespace Web_Programlama.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Araba> Araba { set; get; }

        public DbSet<Fotograf> Fotograf { set; get; }

        public DbSet<Kategori> Kategori { set; get; }

        public DbSet<Ulke> Ulke { set; get; }

        public DbSet<User> User { set; get; }

        public DbSet<ArabaUser> ArabaUser { set; get; }


    }
}
