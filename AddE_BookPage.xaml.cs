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
    public partial class AddE_BookPage : Page
    {
        public AddE_BookPage()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SaveClick(object sender, EventArgs e)
        {
            E_Book e_Book = new E_Book();
            int.TryParse(priceBox.Text, out int price);
            int.TryParse(memoryBox.Text, out int memory);
            e_Book.Firm = firmBox.Text;
            e_Book.Model = modelBox.Text;
            e_Book.Price = price;
            e_Book.Memory = memory;
            MainPage.Devices.Add(e_Book);

            NavigationService.GoBack();
        }
    }
}
