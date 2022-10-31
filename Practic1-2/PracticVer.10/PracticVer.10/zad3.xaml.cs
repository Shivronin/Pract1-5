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
    /// Логика взаимодействия для zad3.xaml
    /// </summary>
    public partial class zad3 : Window
    {
        public zad3()
        {
            InitializeComponent();
        }

        private void btn_start2_Click(object sender, RoutedEventArgs e)
        {
            string text = tb_text.Text;
            var txt = text.Split(' ').Select(Int32.Parse).ToArray();


            int? zero = null;
            for (int i = 1; i < txt.Length - 1; i++)
                if (txt[1] < txt[i] && txt[i] < txt[txt.Length - 1])
                    if (!zero.HasValue)
                        zero = i;
                    
            tbl_result.Text = zero.HasValue ? (zero.Value + 1).ToString() : "0";
        }
    }
}
