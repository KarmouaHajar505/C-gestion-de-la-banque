using System;
using System.Collections.Generic;
using System.Text;

namespace pp
{
    class C_Courant : Compte
    {

        public int carteMonetique;
        public string chequier;
        public double decouvert;
        public string generantCharge;

        // Constructeur
        public C_Courant( int carteMonetique, string chequier, double decouvert, string generantCharge)

        : base()  // appel au constructeur de Compte
        {
            this.carteMonetique = carteMonetique;
            this.chequier = chequier;
            this.decouvert = decouvert;
            this.generantCharge = generantCharge;
        }


    }
}