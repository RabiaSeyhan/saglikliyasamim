using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webOdevi.Models
{
    public class EgzesizOnerileri
    {
        public int id { get; set; }
        public string Resim { get; set; }
        public bool ekle { get; set; }
        public string aciklama { get; set; }

        public List<EgzersizListem> Egzersizler { get; set; }
    }
}