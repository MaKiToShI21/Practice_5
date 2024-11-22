using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice5
{
    public class E_Book : MobileDevice, INotifyPropertyChanged
    {
        new public string Type { get; } = "E_Book";
        private int memory;

        public E_Book(string firm = "Unknown", string model = "Unknown", int price = 0, int memory = 0) : base(firm, model, price)
        {
            Memory = memory;
        }

        public int Memory
        {
            get => memory;
            set
            {
                if (value > 0 && value <= 256)
                {
                    memory = value;
                }
                else
                {
                    memory = 0;
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
