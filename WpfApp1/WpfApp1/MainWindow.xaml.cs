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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Button button = (Button)sender;

           MessageBox.Show(button.Name);
        }

        private void getValue(Button button)
        {
            TextBlock mytext = new TextBlock();
            mytext.Text = button.Name;
            GridChild.Children.Add(mytext);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }
    }
}
