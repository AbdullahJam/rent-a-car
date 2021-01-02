using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class ArabaFirma
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string FirmaSahibi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int AdresId { get; set; }
        public Adres Adres { get; set; }
        public ICollection<Araba> Arabas { get; set; }
    }
}
