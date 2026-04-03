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

namespace Tk_v16
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

        private void rb_changed(object sender, RoutedEventArgs e)
        {
            if (rb_current.IsChecked == true)
            {
                label1.Text = "Напряжение (Вольт)";
                label2.Text = "Сопротивление (Ом)";
            } else
            if (rb_voltage.IsChecked == true)
            {
                label1.Text = "Сопротивление (Ом)";
                label2.Text = "Сила тока (ампер)";
            } else
            if (rb_resistance.IsChecked == true)
            {
                label1.Text = "Сила тока (ампер)";
                label2.Text = "Напряжение (Вольт)";
            } else
            {
                // Такого не может быть никогда (c)
                throw new Exception("Не выбран ни один вариант");
            }
        }
        private string format(double x)
        {
            return string.Format("{0:0.000}", x);
        }
        private void btn_calc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(input1.Text.Replace('.', ','));
                double x2 = Convert.ToDouble(input2.Text.Replace('.', ','));
                if (x1 == double.NaN || x2 == double.NaN)
                    throw new Exception();
                if (rb_current.IsChecked == true)
                {
                    result.Text = "Сила тока = " + format(Calc.current(x1, x2)) + " А";
                }
                else
                if (rb_voltage.IsChecked == true)
                {
                    result.Text = "Напряжение = " + format(Calc.voltage(x1, x2)) + " В";
                }
                else
                if (rb_resistance.IsChecked == true)
                {
                    result.Text = "Сопротивление = " + format(Calc.resistance(x1, x2)) + " Ом";
                }
                else
                {
                    // Такого не может быть никогда (c)
                    throw new Exception("Не выбран ни один вариант");
                }
            }
            catch (Exception)
            {
                result.Text = "";
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}
