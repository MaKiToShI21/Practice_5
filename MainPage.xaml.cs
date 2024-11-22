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
    public partial class MainPage : Page
    {
        public static ObservableCollection<MobileDevice> Devices { get; } = new ObservableCollection<MobileDevice>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddSmatphoneClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new AddSmartphonePage());
        }

        private void AddE_BookClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new AddE_BookPage());
        }

        private void AddMobileDeviceClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new AddMobileDevicePage(Devices));
        }

        private void PrintInfoClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new PrintInfoPage(Devices));
        }

        private void ChangeDeviceClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new ChangeDevicePage(Devices));
        }

        private void DeleteDeviceClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new DeleteDevicePage(Devices));
        }
    }
}
