using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Threading;

namespace Mare_Thread
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Uri uriPesce1 = new Uri("Phish.png", UriKind.Relative);
        public int posPesce1 = 0;
        public MainWindow()
        {
            InitializeComponent();

            lblRisultati.Visibility = Visibility.Hidden;

            Thread t1 = new Thread(new ThreadStart(muoviPesce1));

            ImageSource imm = new BitmapImage(uriPesce1);
            imgPesce1.Source = imm;

            t1.Start();
        }

        public void muoviPesce1()
        {
            while(posPesce1<500)
            {
                posPesce1 += 100;

                Thread.Sleep(TimeSpan.FromMilliseconds(700));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgPesce1.Margin = new Thickness(posPesce1, 331, 0, 0);
                }));
            }
        }
    }
}
