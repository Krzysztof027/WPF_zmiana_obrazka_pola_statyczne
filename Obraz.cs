using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    public class Obraz
    {
       public string Opis { get; set; }
       public string ObrazSRC { get; set; }

       public BitmapImage BitmapImage { get; set;  }

        //OBrazki w  WPF
        

        public Obraz(string opis, string obrazSRC)
        {
            Opis = opis;
            ObrazSRC = obrazSRC;
            BitmapImage = new BitmapImage(new Uri(obrazSRC, UriKind.Relative));
        }
    }
}
