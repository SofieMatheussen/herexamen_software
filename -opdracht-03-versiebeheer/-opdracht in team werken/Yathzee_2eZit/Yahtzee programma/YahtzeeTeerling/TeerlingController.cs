﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    // Vergeet niet de controller op public te zetten
    // Zo kan de view die de controller als argument meekrijgt aan de properties
    public class TeerlingController
    {
        //nodig omdat anders random getal altijd hetzelfde is
        static int seeder = new Random().Next();

        //random getal genereren
        Random random = new Random(++seeder);

        // Member die de view opvangt
        TeerlingView _view;

        // Member die het model opvangt
        // Maak public zodat de view hier ook aan kan
        public TeerlingModel _model;

        public TeerlingController()
        {
            // Maak een instantie van de view
            // Geef een de huidige instantie (= controller = this) mee als argument
            //kan communiceren als er event heeft plaatsgevonden
            _view = new TeerlingView( this );

            // Maak een nieuwe instantie van het model aan
            _model = new TeerlingModel();
        }

        // Return de huidige view
        public TeerlingView getView()
        {
            return _view;
        }

        //methode om teerling te werpen
        // en deze toevoegt aan de database (=model)
        public void werpTeerling()
        {


            // Genereer een willekeurig getal tussen 1 en 6
            int teerlingGetal = random.Next(1, 7);

            //random getal doorsturen naar model
            _model.AantalOgen = teerlingGetal;
        }

        public void updateUI()
        {
            _view.updateUI();
        }

    }
}
