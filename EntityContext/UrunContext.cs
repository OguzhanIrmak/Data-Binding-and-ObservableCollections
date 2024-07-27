using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfGridComboOrnek.Models;

namespace WpfGridComboOrnek.EntityContext
{
    public class UrunContext
    {
        static List<Kategori> kategoriler = new List<Kategori>
        {
           new Kategori{Id=1,Adi="Kategori 1"},
            new Kategori{Id=2,Adi="Kategori 2"},
             new Kategori{Id=3,Adi="Kategori 3"}
        };

        static List<Urun> urunler = new List<Urun>
        {
            new Urun{Id=1,Adi="ürün 1",KategoriId=1},
             new Urun{Id=2,Adi="ürün 2",KategoriId=1},
              new Urun{Id=3,Adi="ürün 3",KategoriId=2},
               new Urun{Id=4,Adi="ürün 4",KategoriId=3},
                new Urun{Id=5,Adi="ürün 5",KategoriId=3},
        };
        public  List<Kategori> Kategoriler
        {

            get { return kategoriler; } 
        }
        public List<Urun> Urunler
        {
            get { return urunler; }
        }
    
    }
}
