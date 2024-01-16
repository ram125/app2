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

namespace app2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            char[] arr = { '1', '~', '@' };
            string ran = arr.ToString();
            if (pswdBox.Password.Length < 8 && !pswdBox.Password.Contains(ran))
            {
                MessageBox.Show("Doesn't work");
            }
            else
            {
                MessageBox.Show($"Your usename is:{txtUsername.Text}, Password: {pswdBox.Password}      It worked Yay!!!!!!!");
            }
        }

        private void usernameClear(object sender, RoutedEventArgs e)
        {

            if (txtFirstname.Text == "First Name")
            {
                txtFirstname.Text = "";
            }
        }

    }
}
