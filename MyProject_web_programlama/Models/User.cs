using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyProject_web_programlama.Models
{
    public partial class User : Person
    {
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }

        public Meslek Meslek { get; set; }

        [Range(2300, 50000, ErrorMessage = "{0} minimum 2300 TL , maksimum 50000 TL girebilirsiniz")]
        public double? Maas { get; set; }
            
        public Medeni Medeni { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

    }





    public enum Medeni
    {
        Evli = 1,
        Bekar,
        Dul,
        Bosanmis
    }
    
    public enum Meslek
    {
        calisiyor = 1,
        calismiyor,
        ogrenci
    }
    public enum Cinsiyet
    {
        Kadin = 1,
        Erkek
    }
}
