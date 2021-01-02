using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class ArabaKira
    {
        public int Id { get; set; }
        public int KiraFiyati { get; set; }
        public string Sure { get; set; }

        public Araba Araba { get; set; }
        public User User { get; set; }
    }
}
