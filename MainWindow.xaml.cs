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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Obraz> Lista_obrazow { get; set; }

        public int Licznik { get; set; } = 0;

        public MainWindow()
        {
            InitializeComponent();
            //Obraz --> Od nazwy klasy
            Lista_obrazow = new List<Obraz>();
            Lista_obrazow.Add(new Obraz("kwiat1", "Images/kwiaty1.jpg"));
            Lista_obrazow.Add(new Obraz("kwiat2", "Images/kwiaty2.jpg"));
            Lista_obrazow.Add(new Obraz("kwiat3", "Images/kwiaty3.jpg"));
            Lista_obrazow.Add(new Obraz("kwiat4", "Images/kwiaty4.jpg"));
            Lista_obrazow.Add(new Obraz("kwiat5", "Images/kwiaty5.jpg"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Licznik--;
            if(Licznik < 0)
            {
                Licznik = Lista_obrazow.Count - 1;
            }
            obrazek.Source = Lista_obrazow[Licznik].BitmapImage;
            opis_Text_Block.Text = Lista_obrazow[Licznik].Opis;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Licznik++;
            if (Licznik == Lista_obrazow.Count)
            {
                Licznik = 0;
            }
            obrazek.Source = Lista_obrazow[Licznik].BitmapImage;
            opis_Text_Block.Text = Lista_obrazow[Licznik].Opis;
        }
    }
}
