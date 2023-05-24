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
using System.Windows.Shapes;

namespace zxcasdqqwe
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(X.Text);
            double b = double.Parse(A.Text);
            double c = double.Parse(Y.Text);

            double pricePerKg = a / b; // стоимость 1 кг конфет

            double totalPrice = pricePerKg * c; // стоимость Y кг конфет

            otv.Text = ("Стоимость 1 кг конфет: " + pricePerKg);
            otv_Copy.Text = ("Стоимость " + c + " кг конфет: " + totalPrice);
        }

        private void vod_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Y_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}