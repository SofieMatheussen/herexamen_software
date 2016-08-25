using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class YahtzeeController
    {
        public YahtzeeView _view;
        public YahtzeeModel _model;

        public YahtzeeController() //constructor
        {
            // Maak een instantie van de view
            // Geef een de huidige instantie (= controller = this) mee als argument
            //kan communiceren als er event heeft plaatsgevonden
            _view = new YahtzeeView( this );

            // Maak een nieuwe instantie van het model aan
            _model = new YahtzeeModel();
        }

        public YahtzeeView getView()
        {
            return _view;
        }

        public void AantalWorpen()
        {
            int maxWorp = 3;
            _model.AantalWorpen = maxWorp;
        }

        public void UpdateUI()
        {
            _view.UpdateUI(); // update view
        }
    }
}
