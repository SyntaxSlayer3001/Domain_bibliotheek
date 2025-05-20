using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bibliotheek.Business
{
    public class Controller
    {
        //instantie van de persistence
        private Persistence.Boekmapper _bibliotheek;
        //instantie van onze klasse Boek
        private Boek boek;
        //instantievariabele van onze boekenlijst
        private List<Boek> _boekenlijst;

        //constructor
        public Controller()
        {
            //initialisatie van de instantievariabele
            _bibliotheek = new Persistence.Boekmapper();
            _boekenlijst = _bibliotheek.GetBoeken();
        }
        public List<Boek> GetBoeken
        {
            get { return _boekenlijst; }
            set { _boekenlijst = value; }
        }
        public void InsertBoek(string titel, int genreId, string auteur, string uitgever, string taal, int graad, string isbn)
        {
            //hier wordt de insert uitgevoerd
            _bibliotheek.InsertBoek(titel, genreId, auteur, uitgever, taal, graad, isbn);
            //hier wordt de boekenlijst opnieuw ingeladen
            _boekenlijst = _bibliotheek.GetBoeken();
        }
    }
}
