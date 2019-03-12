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

namespace FirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            App.Number = 10;
            App.Name = "Pepito Perez"
            something();
        }


        public void something()
        {
            int numberToShow = App.Number;
            string actualName = App.Name;
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Red);
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Blue);
        }
    }
}
