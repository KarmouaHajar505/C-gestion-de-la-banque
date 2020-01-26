using System;
using System.Collections.Generic;
using System.Text;

namespace pp
{
    class C_Epargne : Compte
    { 
        public double taux;

        public C_Epargne(double leTauxInteret)
            : base()
        // appel du constructeur de la classe Compte
        // le mot-clé "base" permet d'accéder à la classe parente
        {
            taux = leTauxInteret;
        }

        // Calcule et ajoute les intérêts au solde du compte
        public void AjouterInterets()
        {
            // ... (détaillé plus bas)
        }
    }
}