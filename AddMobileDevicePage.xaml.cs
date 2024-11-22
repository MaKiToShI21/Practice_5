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

namespace WpfPractice5
{
    public partial class AddMobileDevicePage : Page
    {
        public static ObservableCollection<MobileDevice> Devices { get; set; }

        public AddMobileDevicePage(ObservableCollection<MobileDevice> devices)
        {
            InitializeComponent();
            Devices = devices;
            DataContext = Devices;
        }

        private void BackClick(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            MobileDevice mobileDevice = new MobileDevice();
            int.TryParse(priceBox.Text, out int price);
            mobileDevice.Firm = firmBox.Text;
            mobileDevice.Model = modelBox.Text;
            mobileDevice.Price = price;
            Devices.Add(mobileDevice);

            NavigationService.GoBack();
        }
    }
}
