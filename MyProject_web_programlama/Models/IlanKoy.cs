using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class IlanKoy
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int Fiyat { get; set; }
        public Admin Admin { get; set; }
        public Araba Araba { get; set; }
    }
}
