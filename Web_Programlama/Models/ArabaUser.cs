using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Programlama.Models
{
    public class ArabaUser
    {
        public int Id { set; get; }

        public int UserId { set; get; }

        public int ArabaId { set; get; }

        public Araba Araba { set; get; }

        public User User { set; get; }

    }
}
