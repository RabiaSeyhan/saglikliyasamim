using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webOdevi.Models
{
    public class YemekTarifi
    {
        [Key]
        public int yemid { get; set; }
        public string YemekAdi { get; set; }
        public string YemekMalzemeler { get; set; }
        public string YemekHazirlanisi { get; set; }
        public string Resim { get; set; }


    }
}