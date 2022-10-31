using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для zad5.xaml
    /// </summary>
    public partial class zad5 : Window
    {
        public zad5()
        {
            InitializeComponent();
        }
        private void btn_start2_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            try
            {
                int m = Convert.ToInt32(tb_M.Text);
                int n = Convert.ToInt32(tb_N.Text);
                int[] sort = new int[n * m];
                int[,] massiv = new int[m, n];
                int __nigga__ = 0;
                for (int i = 0; i < m; i++)
                {
                    string str = "";
                    for (int j = 0; j < n; j++)
                    {
                        int x = rnd.Next(-10, 10);
                        massiv[i, j] = x;
                        str += massiv[i, j] + "   ";
                        sort[__nigga__] = x;
                        __nigga__++;
                    }

                }
                dataGrid.ItemsSource = ToDataTable(massiv).DefaultView;

                sort = sort.OrderBy(p => p).ToArray();
                reverseArray(sort, n, m, dataGrid2);
                min.Text = sort[0].ToString();
                sort = sort.OrderByDescending(p => p).ToArray();
                reverseArray(sort, n, m, dataGrid1);
                max.Text = sort[0].ToString();
            }
            catch
            {
                MessageBox.Show("Введите целое число");
            }

        }
        public void reverseArray(int[] sort, int m, int n, DataGrid grid)
        {
            int[,] massive = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    massive[i, j] = sort[index];
                    index++;
                }
            }
            grid.ItemsSource = ToDataTable(massive).DefaultView;
        }

        public DataTable ToDataTable(int[,] matrix)
        {
            var res = new DataTable();

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add(i.ToString(), typeof(int));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }
                res.Rows.Add(row);
            }
            return res;
        }
    }
}
