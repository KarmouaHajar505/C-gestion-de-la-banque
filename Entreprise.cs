using System;
using System.Collections.Generic;
using System.Text;

namespace pp
{
    class Entreprise
    {
        public int IdEntreprise;
        public String NomEntreprise;
        public String DateCreation;


        public Entreprise(int id, String nomE, String DateCr)
        {
            IdEntreprise1 = id;
            NomEntreprise1 = nomE;
            DateCreation1 = DateCr;

        }
        public int IdEntreprise1{ get => IdEntreprise; set => IdEntreprise = value; }
        public String NomEntreprise1 { get => NomEntreprise; set => NomEntreprise = value; }
        public String DateCreation1 { get => DateCreation; set =>DateCreation = value; }
    }
}