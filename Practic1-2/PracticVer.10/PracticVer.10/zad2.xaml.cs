using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PracticVer._10
{
    /// <summary>
    /// Логика взаимодействия для zad2.xaml
    /// </summary>
    public partial class zad2 : Window
    {
        public zad2()
        {
            InitializeComponent();
        }

        private void btn_start2_Click(object sender, RoutedEventArgs e)
        {
            string[] text = tb_text.Text.Split(new char[] {' ', ',','.',':',';','-'}, StringSplitOptions.RemoveEmptyEntries);
            if (!Regex.IsMatch(text.ToArray()[0], "^[a-zA-Z]*$"))
            {
                //tbl_result.Text = (text.Where(x => x.Length == text.Max(m => m.Length)).Take(1).ToArray()[0]);
                tbl_result.Text = text.OrderByDescending(x => x.Length).ToArray()[0];
            }
            else tbl_result.Text = "Только русские буквы!";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
        }
    }
}
