using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice5
{
    public class MobileDevice : INotifyPropertyChanged
    {
        public string Type { get; } = "MobileDevice";
        private string firm, model;
        private int price;

        public MobileDevice(string firm = "Unknown", string model = "Unknown", int price = 0)
        {
            Firm = firm;
            Model = model;
            Price = price;
        }

        // Свойства set и get
        public string Firm
        {
            get => firm;
            set
            {
                if (value.Length > 0 && value.Length < 20)
                {
                    firm = value;
                }
                else
                {
                    firm = "Unknown";
                }
            }
        }
        public string Model
        {
            get => model;
            set
            {
                if (value.Length > 0 && value.Length < 20)
                {
                    model = value;
                }
                else
                {
                    model = "Unknown";
                }
            }
        }
        public int Price
        {
            get => price;
            set
            {
                if (value <= 500000 && value >= 0)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
