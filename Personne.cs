using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace pp
    { 
    class Personne
    {
        public  String CIN;
        public String NOM;
        public String PRENOM;
        public String DATE;
        public String ADDRESSE;
        public String MAIL;
        public int GSM;

        public Personne(String cin, String nom, String prenom, String date, String adresse, String mail, int gsm)
        {

            CIN1 = cin;
            NOM1 = nom;
            PRENOM1 = prenom;
            DATE1 = date;
            ADDRESSE1 = adresse;
            MAIL1 = mail;
            GSM1 = gsm;
        }    
        public String CIN1 { get => CIN; set => CIN = value; }

        public String NOM1 { get => NOM; set => NOM = value; }

        public String PRENOM1 { get => PRENOM; set => PRENOM = value; }

        public String DATE1 { get => DATE; set => DATE = value; }

        public String ADDRESSE1 { get => ADDRESSE; set => ADDRESSE = value; }

        public String MAIL1 { get => MAIL; set => MAIL = value; }

        public int GSM1 { get => GSM; set => GSM = value; }


    }
}