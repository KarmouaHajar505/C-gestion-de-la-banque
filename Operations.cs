using System;
using System.Collections.Generic;
using System.Text;

namespace pp
{
    class Operations
    {
        public String Vers;
        public String Vire;
        public String PaiementC;
        public String PaiementI;
        public sString Retrait;


        public Operations(String  Versement , String Virement,String Paiement_par_carte ,String Paiement_par_Internet,String Retrait_argent)
        {

            Versement1 = Versement;
            Virement1 = Virement;
            Paiement_par_carte1 = Paiement_par_carte;
            Paiement_par_Internet1 = Paiement_par_Internet;
            Retrait_argent1 = Retrait_argent;



        }
        public String Versement1{ get => Vers; set => Vers = value; }
        public String Virement1 { get => Vire; set => Vire = value; }
        public String Paiement_par_carte1 { get => PaiementC; set =>PaiementC = value; }
        public String Paiement_par_Internet1 { get => PaiementI; set => PaiementI = value; }
        public String Retrait_argent1 { get => Retrait; set => Retrait = value; }
    }
}
