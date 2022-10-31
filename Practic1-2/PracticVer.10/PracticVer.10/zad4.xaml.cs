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
    /// Логика взаимодействия для zad4.xaml
    /// </summary>
    public partial class zad4 : Window
    {
        public zad4()
        {
            InitializeComponent();
        }

        private void btn_start2_Click(object sender, RoutedEventArgs e)
        {
            string text = textbox.Text;
            var txt = text.Split(' ', ',').Select(Int32.Parse).ToArray();

            int emptyValues = 0;
            int Values = 0;
            bool flag = false;
            for (int i = 0; i < txt.Length; i++)
            {
                flag = false;
                if (txt[i] <= 1)
                    continue;
                else
                    for (int j = 2; j < txt[i]; j++)
                        if (txt[i] % j == 0)
                            flag = true;
                if (!flag)
                    emptyValues++;

            }
            for (int i = 0; i < txt.Length; i++)
            {
                for (int j = 2; j <= txt.Length; j++)
                {
                    int sum = 0;
                    for (int n = 1; n <= j - 1; n++)
                    {
                        if (j % n == 0)
                        {
                            sum += n;
                        }
                    }
                    if (sum == j)
                    {
                        Values++;
                    }

                }
                tbl_result.Text = Values.ToString();
                MessageBox.Show("Вот я смотрю на задание, и почему то зубы скрипят");
            }

        }
    }
}

