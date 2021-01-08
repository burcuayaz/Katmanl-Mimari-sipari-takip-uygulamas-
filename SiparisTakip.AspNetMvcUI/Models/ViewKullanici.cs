using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiparisTakip.AspNetMvcUI.Models
{
    public class ViewKullanici
    {
        [DisplayName("Kullanıcı Kodu")]
        [Required(ErrorMessage = "{0} kodu Boş geçilemez"), 
         MinLength(3,ErrorMessage = "{0} kodu en az {1} karakterden oluşmalıdır"),
         MaxLength(20,ErrorMessage = "{0} kodu en fazla {1} karakterden oluşmalıdır")]
        public string KullaniciKodu { get; set; }
        [DisplayName("Parola")]
        [Required(ErrorMessage = "{0} Boş geçilemez"),
         MinLength(3, ErrorMessage = "{0} en az {1} karakterden oluşmalıdır"),
         MaxLength(8, ErrorMessage = "{0} en fazla {1} karakterden oluşmalıdır"),
         DataType(DataType.Password)]
        public string Parola { get; set; }
    }
}