using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Acquario_Thread
{
    public class ListaClassifica
    {
        private ObservableCollection<String> _risultati;

        public ListaClassifica()
        {
            _risultati = new ObservableCollection<string>();
        }

        public void AggiungiARisultati (string stringa)
        {
            _risultati.Add(stringa);
        }

    }
}
