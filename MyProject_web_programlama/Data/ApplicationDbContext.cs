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
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Araba> Arabas { get; set; }
        public DbSet<ArabaFirma> ArabaFirmas { get; set; }
        public DbSet<ArabaKira> ArabaKiras { get; set; }
        public DbSet<Fotograf> Fotografs { get; set; }
        public DbSet<IlanKoy> IlanKoys { get; set; }
        public DbSet<Kiraci> Kiracis { get; set; }
        public DbSet<Ofi> Ofis { get; set; }
        public DbSet<Ozellik> Ozelliks { get; set; }
        public DbSet<OzellikEkle> OzellikEkles { get; set; }
        public DbSet<ServisFirma> ServisFirmas { get; set; }
        public DbSet<MyProject_web_programlama.Models.Person> Person { get; set; }
        public DbSet<MyProject_web_programlama.Models.User> User { get; set; }
    }
}
