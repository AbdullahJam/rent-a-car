using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class IlanKoy
    {
        public int Id { get; set; }
        public int ArabaId { get; set; }
        public int PersonelId { get; set; }
        public DateTime Tarih { get; set; }
        public int Fiyat { get; set; }
        public virtual Araba Araba { get; set; }
    }
}
