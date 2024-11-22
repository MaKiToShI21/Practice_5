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
    public partial class ChangeDevicePage : Page
    {
        public ObservableCollection<MobileDevice> Devices { get; set; }

        public ChangeDevicePage(ObservableCollection<MobileDevice> devices)
        {
            InitializeComponent();
            Devices = devices;
            DataContext = this;
        }

        private void BackClick(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ChangeDeviceClick(object sender, EventArgs e)
        {
            var selectedDevice = (MobileDevice)listView.SelectedItem;
            if (selectedDevice != null && selectedDevice is Smartphone)
                NavigationService.Navigate(new ChangeSmartphonePage((Smartphone)selectedDevice));
            else if (selectedDevice != null && selectedDevice is E_Book)
                NavigationService.Navigate(new ChangeE_BookPage((E_Book)selectedDevice));
            else if (selectedDevice != null)
                NavigationService.Navigate(new ChangeMobileDevicePage(selectedDevice));
            else
            {
                MessageBox.Show("Выберите устройство!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
