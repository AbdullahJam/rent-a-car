using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class ServisFirma
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Servis { get; set; }
        public ICollection<Araba> Arabas { get; set; }
    }
}
