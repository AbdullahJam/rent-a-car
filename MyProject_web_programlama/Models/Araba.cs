using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class Araba
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Model { get; set; }
        public ICollection<ArabaKira> ArabaKiras { get; set; }
        public ICollection<Fotograf> Fotografs { get; set; }
        public ICollection<IlanKoy> IlanKoys { get; set; }
    }
}
