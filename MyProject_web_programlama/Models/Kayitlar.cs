using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject_web_programlama.Models
{
    public class Kayitlar
    {
        public int Id { get; set; }
        public int AdminID { get; set; }
        public int UserID { get; set; }
    }
}