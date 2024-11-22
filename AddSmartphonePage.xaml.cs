using System;
using System.Collections.Generic;
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
    public partial class AddSmartphonePage : Page
    {
        public AddSmartphonePage()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
        private void SaveClick(object sender, EventArgs e)
        {
            Smartphone smartphone = new Smartphone();
            int.TryParse(priceBox.Text, out int price);
            int.TryParse(numOfCamerasBox.Text, out int numOfCameras);
            smartphone.Firm = firmBox.Text;
            smartphone.Model = modelBox.Text;
            smartphone.Price = price;
            smartphone.NumOfCameras = numOfCameras;
            MainPage.Devices.Add(smartphone);

            NavigationService.GoBack();
        }
    }
}
