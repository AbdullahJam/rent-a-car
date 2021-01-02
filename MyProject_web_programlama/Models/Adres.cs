using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class Adres
    {
        public int Id { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public string Satir1 { get; set; }
        public string Satir2 { get; set; }
        public ICollection<ArabaFirma> ArabaFirmas { get; set; }
    }
}
