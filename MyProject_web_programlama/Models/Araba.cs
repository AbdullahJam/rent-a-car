using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class Araba
    {
        public int Id { get; set; }
        public int ArabaFirId { get; set; }
        public int ServisId { get; set; }
        public string Ad { get; set; }
        public ArabaFirma ArabaFir { get; set; }
        public ServisFirma Servis { get; set; }
        public ICollection<ArabaKira> ArabaKiras { get; set; }
        public ICollection<Fotograf> Fotografs { get; set; }
        public ICollection<IlanKoy> IlanKoys { get; set; }
        public ICollection<OzellikEkle> OzellikEkles { get; set; }
    }
}
