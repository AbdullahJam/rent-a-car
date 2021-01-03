using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Programlama.Models
{
    public class User
    {
        public int Id { set; get; }

        public int UlkeId { set; get; }

        public string Ad { set; get; }

        public string Soyad { set; get; }

        public Cinsiyet Cinsiyet { set; get; }

        public Ulke Ulke { set; get; }

    }


    public enum Cinsiyet
    {
        erkek = 1,
        kadin
    }
}
