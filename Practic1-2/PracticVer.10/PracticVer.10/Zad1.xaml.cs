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

namespace PracticVer._10
{
    /// <summary>
    /// Логика взаимодействия для Zad1.xaml
    /// </summary>
    public partial class Zad1 : Window
    {
        public Zad1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            string chislo = tb_text.Text,
                result = "";
            foreach (var s in chislo.Distinct())
                if (chislo.Count(x => x == s) > 1)
                    result += s;
            tbl_result.Text = result;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
        }
    }
}
