using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webOdevi.Models
{
    public class EgzersizListemContext : DbContext
    {
        public EgzersizListemContext()
        {
            Database.SetInitializer(new EgzersizListemInitializer());
        }
        
        public DbSet<EgzersizListem> egzersizler { get; set; }
        public DbSet<EgzesizOnerileri> egzersizOnerileri { get; set; }
        public DbSet<YemekTarifi> tarifler { get; set; }

        public DbSet<Yorum> yorumlar { get; set; }
        public DbSet<magaza> magazalar { get; set; }


    }
}