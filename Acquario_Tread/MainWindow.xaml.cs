using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Threading;


namespace Acquario_Thread
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Uri uriPesce1 = new Uri("Phish.png", UriKind.Relative);
        static int posPesce1 = 0;
        readonly Uri uriPesce2 = new Uri("pesce-spada-trasp.png", UriKind.Relative);
        static int posPesce2 = 0;
        readonly Uri uriPesce3 = new Uri("squalo-trasp.png", UriKind.Relative);
        static int posPesce3 = 0;

        public ListaClassifica a;

        public MainWindow()
        {
            InitializeComponent();

            a = new ListaClassifica();

            Thread t1 = new Thread(new ThreadStart(muoviPesce1));
            Thread t2 = new Thread(new ThreadStart(muoviPesce2));
            Thread t3 = new Thread(new ThreadStart(muoviPesce3));

            ImageSource imm1 = new BitmapImage(uriPesce1);
            imgPesce1.Source = imm1;
            ImageSource imm2 = new BitmapImage(uriPesce2);
            imgPesce2.Source = imm2;
            ImageSource imm3 = new BitmapImage(uriPesce3);
            imgPesce3.Source = imm3;

            t1.Start();
            t2.Start();
            t3.Start();
        }

        public void muoviPesce1()
        {
            while (posPesce1 < 463)
            {
                //dopo 463 l'immagine dei pesci esce dallo schermo

                posPesce1 += 1;

                Thread.Sleep(TimeSpan.FromMilliseconds(7));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgPesce1.Margin = new Thickness(posPesce1, 331, 0, 0);
                }));
            }

            a.AggiungiARisultati("Pesce numero 1");
        }

        public void muoviPesce2()
        {
            while (posPesce2 < 463)
            {
                posPesce2 += 1;

                Thread.Sleep(TimeSpan.FromMilliseconds(7));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgPesce2.Margin = new Thickness(posPesce2, 227, 0, 0);
                }));
            }

            a.AggiungiARisultati("Pesce numero 2");
        }

        public void muoviPesce3()
        {
            while (posPesce3 < 463)
            {
                posPesce3 += 1;

                Thread.Sleep(TimeSpan.FromMilliseconds(7));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgPesce3.Margin = new Thickness(posPesce3, 97, 0, 0);
                }));
            }

            a.AggiungiARisultati("Pesce numero 3");
        }
    }
}
