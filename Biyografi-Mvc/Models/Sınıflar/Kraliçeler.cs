using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biyografi_Mvc.Models.Sınıflar
{
    public class Kraliçeler
    {
        [Key]
        public int İD { get; set; }
        public string Açiklama { get; set; }
        public string Başlik { get; set; }
    }
}