using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGridComboOrnek.Models
{
    public class Urun:INotifyPropertyChanged
    {
        int id;
        string adi;
        int kategoriId;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Adi
        {
            get
            {
                return adi;
            }
            set
            {
                adi = value;
                OnPropertyChanged("Adi");
            }
        }
        public int KategoriId
        {
            get
            {
                return kategoriId;
            }
            set
            {
                kategoriId = value;
                OnPropertyChanged("KategoriId");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
