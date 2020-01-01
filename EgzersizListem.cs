using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webOdevi.Models
{
    public class EgzersizListem
    {
        public int id { get; set; }
        public string Resmim { get; set; }
        public bool çıkart { get; set; }

        public int EgzersizOnerileriid { get; set; }
        public EgzesizOnerileri egzersiz { get; set; }
    }
}