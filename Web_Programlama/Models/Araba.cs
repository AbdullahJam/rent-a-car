using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Programlama.Models
{
    public class Araba
    {
        public int Id { set; get; }

        public string ArabaAd { set; get; }

        public int KategoriId { set; get; }

        public string? FotografId { set; get; }

        public int? YilModulu { set; get; }

        public string? UretilenFirma { set; get; }

        public Vites Vites { set; get; }

        public string? Yikit { set; get; }

        public Kategori Kategori { set; get; }

        internal class Fotograf
        {
        }
    }

    public enum Vites
    {
        Benzin = 1,
        dizel ,
        gaz
    }
}
