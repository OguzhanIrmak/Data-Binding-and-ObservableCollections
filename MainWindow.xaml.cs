using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfGridComboOrnek.EntityContext;
using WpfGridComboOrnek.Models;

namespace WpfGridComboOrnek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Urun> urunler = null;
        List<Kategori> kategoriler = null;
        public MainWindow()
        {
            InitializeComponent();
           // UrunContext urunDb = new UrunContext();
           kategoriler = new List<Kategori>()
            {
                new Kategori { Id = 1, Adi = "Kategori 1" },
            new Kategori { Id = 2, Adi = "Kategori 2" },
             new Kategori { Id = 3, Adi = "Kategori 3" }
            };

             urunler = new ObservableCollection<Urun>()
            {
                new Urun{Id=1,Adi="ürün 1",KategoriId=1},
                new Urun{Id=2,Adi="ürün 2",KategoriId=1},
                new Urun{Id=3,Adi="ürün 3",KategoriId=2},
                new Urun{Id=4,Adi="ürün 4",KategoriId=3},
                new Urun{Id=5,Adi="ürün 5",KategoriId=3},
            };

            //Kategoriler bağlanıyor
            cmbKategoriler.DisplayMemberPath = "Adi";
            cmbKategoriler.SelectedValuePath = "Id";
            cmbKategoriler.ItemsSource=kategoriler;

            //datagrid'e veri bağlanıyor
            gridUrunler.ItemsSource=urunler;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //urunler[0].Adi = "Ürün1 Yeni Adi ";
            urunler.RemoveAt(0);
            //urunler.Add(new Urun { Id = 6, Adi = "ürün 6", KategoriId = 6 });
        }
    }

    
}
