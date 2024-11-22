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
    public partial class PrintInfoPage : Page
    {
        public ObservableCollection<MobileDevice> Devices { get; set; }

        public PrintInfoPage(ObservableCollection<MobileDevice> devices)
        {
            InitializeComponent();

            Devices = devices;
            this.DataContext = this;
        }

        private void GoBackClick(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
