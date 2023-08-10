using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biyografi_Mvc.Models.Sınıflar
{
    public class Kiliseler
    {
        [Key]
        public int YapımYılı { get; set; }
        public string kiliseAdi { get; set; }
       
        public string Açiklama { get; set; }
        
    }
}