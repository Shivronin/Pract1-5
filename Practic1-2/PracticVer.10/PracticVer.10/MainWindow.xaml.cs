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

namespace PracticVer._10
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

        private void btn_form1_Click(object sender, RoutedEventArgs e)
        {
            Zad1 newForm = new Zad1();
            newForm.Show();
            this.Hide();
        }

        private void btn_form2_Click(object sender, RoutedEventArgs e)
        {
            zad2 newForm = new zad2();
            newForm.Show();
            this.Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zad3 newForm = new zad3();
            newForm.Show();
            this.Hide();
        }

        private void btn_zad4_Click(object sender, RoutedEventArgs e)
        {
            zad4 newForm = new zad4();
            newForm.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            zad5 newForm = new zad5();
            newForm.Show();
            this.Hide();
        }
    }
}
