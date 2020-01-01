using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webOdevi.Models
{
    public class EgzersizListesi
    {
        private List<egzersizz> _egzersizs = new List<egzersizz>();
        public List<egzersizz> egzersizs
        {
            get { return _egzersizs; }
        }
        public void AddProduct(EgzesizOnerileri egzesiz , int adet)
        {
            var line = _egzersizs.FirstOrDefault(i => i.Product.id == egzesiz.id);
            if( line == null)
            {
                _egzersizs.Add(new egzersizz() { Product = egzesiz, adet = adet });
            }
            else
            {
                line.adet += 0 ;
            }
        }
        public void DeleteProduct( EgzesizOnerileri egzesiz)
        {
            _egzersizs.RemoveAll(i => i.Product.id == egzesiz.id);
        }
        public void Clear()
        {
            _egzersizs.Clear();

        }
        

    }
    public class egzersizz
    {
        public EgzesizOnerileri Product { get; set; }
        public int adet { get; set; }
    }
}