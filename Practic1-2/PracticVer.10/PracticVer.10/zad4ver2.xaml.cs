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
    /// Логика взаимодействия для zad4ver2.xaml
    /// </summary>
    public partial class zad4ver2 : Window
    {
        public zad4ver2()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            string text = tb_text.Text;
            var txt = text.Split(' ').Select(Int32.Parse).ToArray();
        }
    }
}
