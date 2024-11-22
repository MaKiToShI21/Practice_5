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
    public partial class DeleteDevicePage : Page
    {
        public ObservableCollection<MobileDevice> Devices { get; set; }
        
        public DeleteDevicePage(ObservableCollection<MobileDevice> devices)
        {
            InitializeComponent();
            Devices = devices;
            this.DataContext = this;
        }

        private void BackClick(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void DeleteDeviceClick(object sender, EventArgs e)
        {
            MobileDevice selectedDevice = (MobileDevice)listView.SelectedItem;
            if (selectedDevice != null)
            {
                var result = MessageBox.Show("Вы точно хотите удалить это устройство?", "Delete Device", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                    MainPage.Devices.Remove(selectedDevice);
            }
            else
            {
                MessageBox.Show("Выберите устройство!", "Configuration", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
