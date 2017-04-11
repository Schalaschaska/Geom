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
using System.Text.RegularExpressions;

namespace Geom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex X = new Regex(@"^\d+$");
            double x1, x2, x3, x4, y1, y2, y3, y4;//координаты прямой и отрезка
            double ua;//числител
            double au;//знаменатели
            double Y_cord;
            double X_cord;
            double max_x, min_x,max_y,min_y;
            if (X.IsMatch(x1_t.Text) && (X.IsMatch(x2_t.Text)) && (X.IsMatch(x3_t.Text)) && (X.IsMatch(x4_t.Text)) && (X.IsMatch(y1_t.Text)) && (X.IsMatch(y2_t.Text)) && (X.IsMatch(y3_t.Text)) && (X.IsMatch(y4_t.Text)))
            {
                x1 = Convert.ToDouble(x1_t.Text);
                x2 = Convert.ToDouble(x2_t.Text);
                x3 = Convert.ToDouble(x3_t.Text);
                x4 = Convert.ToDouble(x4_t.Text);
                y1 = Convert.ToDouble(y1_t.Text);
                y2 = Convert.ToDouble(y2_t.Text);
                y3 = Convert.ToDouble(y3_t.Text);
                y4 = Convert.ToDouble(y4_t.Text);
                ua = (x1 - x3) * (y4 - y3) * (y2 - y1) + y3 * (x4 - x3) * (y2 - y1) - y1 * (x2 - x1) * (y4 - y3);
                au = (x4 - x3) * (y2 - y1) - (x2 - x1) * (y4 - y3);
                Y_cord = ua / au;
                X_cord = x3 + ((x4 - x3) / (y4 - y3)) * (Y_cord - y3);
                if(x1>x2)
                {
                    max_x = x1;
                    min_x =x2;
                }
                else
                {
                    max_x = x2;
                    min_x = x1;
                }
                if (y1 > y2)
                {
                    max_y = y1;
                    min_y = y2;
                }
                else
                {
                    max_y = y2;
                    min_y = y1;
                }
                if (((X_cord <= max_x) && (X_cord >= min_x)) && ((Y_cord <= max_y) && (Y_cord >= min_y)))
                {
                    MessageBox.Show("Прямая и отрезок пересекаются", "Отчёт", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Прямая и отрезок не пересекаются!", "Отчёт", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }




        }
    }
}
