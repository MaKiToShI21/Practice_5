using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice5
{
    public class Smartphone : MobileDevice, INotifyPropertyChanged
    {
        new public string Type { get; } = "Smartphone";
        private int numOfCameras;

        public Smartphone(string firm = "Unknown", string model = "Unknown", int price = 0, int numOfCameras = 0) : base(firm, model, price)
        {
            NumOfCameras = numOfCameras;
        }

        public int NumOfCameras
        {
            get => numOfCameras;
            set
            {
                if (value <= 10 && value > 0)
                {
                    numOfCameras = value;
                }
                else
                {
                    numOfCameras = 0;
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