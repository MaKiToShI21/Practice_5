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
    public partial class ChangeE_BookPage : Page
    {
        public E_Book E_Book { get; set; }

        public ChangeE_BookPage(E_Book selectedDevice)
        {
            InitializeComponent();
            E_Book = selectedDevice;
            DataContext = E_Book;
        }

        private void SaveChangesClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }
    }
}
