using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class Fotograf
    {
        public int Id { get; set; }
        public int ArabaId { get; set; }
        public string Fotograf1 { get; set; }
        public virtual Araba Araba { get; set; }
    }
}
