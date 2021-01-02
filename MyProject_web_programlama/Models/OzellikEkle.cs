using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class OzellikEkle
    {
        public int Id { get; set; }
        public int ArabaId { get; set; }
        public int OzellikId { get; set; }
        public DateTime Tarih { get; set; }

        public Araba Araba { get; set; }
        public Ozellik Ozellik { get; set; }
    }
}
