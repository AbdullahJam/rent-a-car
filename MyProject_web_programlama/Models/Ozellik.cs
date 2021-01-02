using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class Ozellik
    {
        public int Id { get; set; }
        public string OzellikTipi { get; set; }
        public Admin Admin { get; set; }
    }
}
