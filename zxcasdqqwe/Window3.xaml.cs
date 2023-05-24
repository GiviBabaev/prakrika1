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
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(X.Text); 
            double b = 10 * x + Math.Log10(x); 

            double tgX2 = Math.Tan(x * x);
            double lnTgX2 = Math.Log(Math.Abs(tgX2)); 

            double a = 1 * Math.Cos(x) + lnTgX2 + b * b; 

            otv.Text=("Значение выражения: " + a);
        }

        private void vod_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
