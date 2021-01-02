using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class Fotograf
    {
        public int Id { get; set; }
        public string fotograf { get; set; }
        public Araba Araba { get; set; }
    }
}
