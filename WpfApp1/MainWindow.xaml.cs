using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    class FLAT
    {
        int Count;
        int S;
        int Stage;
        string Adr;
        int Price;
        public void Set_Info(int count, int s, int stage, string adr,int price)
        {
            Count = count;
            S = s;
            Stage = stage;
            Adr = adr;
            Price = price;
        }
        public void Disp()
        {
            MessageBox.Show($"Квартира на улице {Adr}, на {Stage} этаже имеет {Count} комнат, с общей площадью {S} кв м. Её цена на данный момент {Price} рублей", "Ответ");
        }
    }

    public partial class MainWindow : Window
    {
        FLAT f = new FLAT();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Count = int.Parse(count.Text);
            int S = int.Parse(s.Text);
            int Stage = int.Parse(stage.Text);
            string Adr = adr.Text;
            int Price = int.Parse(price.Text);

            f.Set_Info(Count, S, Stage, Adr, Price);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            f.Disp();
        }
    }
}
