/* --------
__Author__=Hajar  Karmoua

*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace pp { 
    class Program { 
    
        static void Main(string[] args)
        {
            Compte c = new Compte();
            List<Personne> tab = new List<Personne>();
            List<Entreprise> prise = new List<Entreprise>();
            Console.WriteLine("----------------------------------------\n|\t\tBANK AL MAGHRIB\t\t|\n----------------------------------------");
            while (true) 
            
            {

                Console.WriteLine("\n\n1-Créer un compte | 2-S'inscrire");
                Console.WriteLine("Entrer votre choix :");
                int UserInput = int.Parse(Console.ReadLine());
                
                if (UserInput == 1)
                {
                    Console.WriteLine("1-Personne \t 2-Entreprise");

                    int UserType = int.Parse(Console.ReadLine());
                    if (UserType == 1)
                    {
                        Console.WriteLine("CIN:");
                        var CIN = Console.ReadLine();
                        while (String.IsNullOrEmpty(CIN) == true) { 
               
                            Console.WriteLine("Il faut la remplir! ");
                             CIN = Console.ReadLine();

                        }
                        Console.WriteLine("NOM:");
                        var NOM = Console.ReadLine();
                        while (String.IsNullOrEmpty(NOM) == true) 
                        {

                            Console.WriteLine("Il faut la remplir!");
                            NOM = Console.ReadLine();

                        }

                        Console.WriteLine("PRENOM:");
                        var PRENOM = Console.ReadLine();
                        while (String.IsNullOrEmpty(PRENOM) == true)
                        {

                            Console.WriteLine("Il faut la remplir!");
                            PRENOM = Console.ReadLine();

                        }
                        Console.WriteLine("DATE DE NAISSANCE:");
                        var DATE = Console.ReadLine();
                        while (String.IsNullOrEmpty(DATE) == true)
                        {

                            Console.WriteLine("Il faut la remplir!");
                            DATE = Console.ReadLine();

                        }

                        Console.WriteLine("ADRESSE:");
                        var ADDRESSE = Console.ReadLine();
                        while (String.IsNullOrEmpty(ADDRESSE) == true)
                        {

                            Console.WriteLine("Il faut la remplir!");
                            ADDRESSE = Console.ReadLine();

                        }
                        Console.WriteLine("Mail:");
                        var MAIL = Console.ReadLine();
                        while (String.IsNullOrEmpty(MAIL) == true)
                        {

                            Console.WriteLine("Il faut la remplir!");
                            MAIL = Console.ReadLine();
                        }

                        Console.WriteLine("GSM:");
                        int GSM = int.Parse(Console.ReadLine());

                        Personne per = new Personne(CIN, NOM, PRENOM, DATE, ADDRESSE, MAIL, GSM);
                        tab.Add(per);
                        Console.WriteLine("Vous voulez creér : \n 1)-Compte Courrant \n 2)-Compte Epargne");
                        int UserCompteType = int.Parse(Console.ReadLine());
                        if (UserCompteType == 1)
                        {
                            Console.WriteLine("Créez un id pour votre compte :");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Confirmez votre id de compte:");
                            int c_id = int.Parse(Console.ReadLine());
                            c.IdCompteP = id;
                            if (id == c_id)
                            {
                                Console.WriteLine("\nVotre compte est crée avec 0 dh!!\n");
                                Console.WriteLine("Chosissez votre choix:\n\n1-Carte Monétique\n2-Un Chéquier\n3-Un découvert\n4-Générant des charges mensuelles");
                                int type = int.Parse(Console.ReadLine());
                                if (type == 1 || type == 3 || type == 4)
                                {
                                    Console.WriteLine("Attendz un peu ,Votre compte sera redémarrer pour des raisons de sécurité");

                                    Thread.Sleep(5000);
                                    Console.WriteLine("\n----------------------------\nS'inscrire\n----------------------------");
                                    Console.WriteLine("\nId compte:");
                                    int UserCompte = int.Parse(Console.ReadLine());
                                    if (UserCompte == c.IdCompteP)
                                    {
                                        Console.WriteLine("\n-----------------\n|Votre Solde actuelle est:00dh|\n-----------------\n");
                                        Console.WriteLine("1-Inserer d'argents\n2-Pas maintenant");

                                        int choix = int.Parse(Console.ReadLine());
                                        if (choix == 1)
                                        {
                                            Console.WriteLine("Inserer un montant d'argents(au minimum 100dh):");
                                            String arg = Console.ReadLine();
                                            String[] newarg = arg.Split("dh");
                                            foreach (String j in newarg)
                                            {
                                                try
                                                {
                                                    int y = int.Parse(j);
                                                    if (y >= 100)
                                                    {
                                                        Console.WriteLine("-----------------\n|Votre Solde:" + j + "dh|\n-----------------");
                                                        Console.WriteLine("1-Versement\n2-Virement\n3-Paiement par carte\n4-Paiement par Internet\n5-Retrait d'argents");
                                                        int method = int.Parse(Console.ReadLine());
                                                        if (method == 1)
                                                        {
                                                            Console.WriteLine("-----------------\n|Votre Solde est:" + j + "dh|\n-----------------");
                                                            Console.WriteLine("N°Compte:");
                                                            Console.ReadLine();
                                                            Console.WriteLine("Montant:");
                                                            String Montant = Console.ReadLine();


                                                            String[] strlist = Montant.Split("dh");
                                                            foreach (String i in strlist)
                                                            {
                                                                try
                                                                {
                                                                    int x = int.Parse(i);
                                                                    if (x <= y)
                                                                    {
                                                                        int newMontant = y - x;
                                                                        Console.WriteLine("L'opération est faite!!");

                                                                        Console.WriteLine("-----------------\n| Votre Solde:" + newMontant + "dh|\n-----------------");
                                                                    }

                                                                    else if (x > y)
                                                                    {
                                                                        Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                    }

                                                                }
                                                                catch (FormatException ex)
                                                                {
                                                                    //Console.WriteLine(ex.Message);
                                                                }
                                                            }

                                                        }
                                                        else if (method == 2)
                                                        {
                                                            Console.WriteLine("-----------------\n|Votre Solde:" + j + "dh|\n-----------------");
                                                            Console.WriteLine("N°Compte:");
                                                            int NumCompte = int.Parse(Console.ReadLine());
                                                            Console.WriteLine("Montant:");
                                                            String Montant = Console.ReadLine();


                                                            String[] strlist = Montant.Split("dh");
                                                            foreach (String i in strlist)
                                                            {
                                                                try
                                                                {
                                                                    int x = int.Parse(i);
                                                                    if (x <= y)
                                                                    {
                                                                        int newMontant = y - x;
                                                                        //DateTime now = DateTime.Now;
                                                                        DateTime utc = DateTime.UtcNow;

                                                                        //Console.WriteLine($"UTC time {utc:HH:mm:ss}");
                                                                        Console.WriteLine("\nL'opération est faite!!\n\n");
                                                                        Console.WriteLine("---------------Activité---------------");
                                                                        Console.WriteLine("\nVotre Solde est:" + newMontant + "dh\n");
                                                                        Console.WriteLine("La somme d'argent sera converter:" + Montant + "\nAu compte:" + NumCompte);
                                                                        Console.WriteLine($"Date: {utc:HH:mm:ss}\n-------------------------");
                                                                    }

                                                                    else if (x > y)
                                                                    {
                                                                        Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                    }

                                                                }
                                                                catch (FormatException ex)
                                                                {
                                                                    //Console.WriteLine(ex.Message);
                                                                }
                                                            }

                                                        }
                                                        else if (method == 3)
                                                        {
                                                            Console.WriteLine("Inserer votre carte et (Cliquer sur Entrer pour Continuer)--");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Carte Code:");
                                                            int code = int.Parse(Console.ReadLine());
                                                            if (code==c.IdCompteP) {
                                                                Console.WriteLine("Facteur d'eau:\t\t80  dh\nFacteur d'électricité:\t100 dh\nvotre achats:\t\t150 dh\nTVA:\t\t\t08  dh\n------------------------------\n Total\t\t\t298 dh");
                                                                Console.WriteLine("Confirmez votre opération(Y/N):");
                                                                String confirm = Console.ReadLine();

                                                                if (confirm == "Y" || confirm == "y")
                                                                {
                                                                    try
                                                                    {
                                                                        if (298 <= y)
                                                                        {
                                                                            DateTime utc = DateTime.UtcNow;
                                                                            int newMontant = y - 298;

                                                                            Console.WriteLine("\nL'opération est faite!!\n\n");
                                                                            Console.WriteLine("---------------Paiement Activité---------------");
                                                                            Console.WriteLine($"Date: {utc:HH:mm:ss}\n");
                                                                            Console.WriteLine("Votre Solde est:" + newMontant + "dh\n");
                                                                            Console.WriteLine("Facteur d'eau:\t\t80  dh\nFacteur d'électricité:\t100 dh\nvotre achats:\t\t150 dh\nTVA:\t\t\t08  dh\n-------------------------\nTotal\t\t\t298 dh");

                                                                        }

                                                                        else if (298 > y)
                                                                        {
                                                                            Console.WriteLine("Votre solde n'est pas suffissant!!!\n");
                                                                            method = int.Parse(Console.ReadLine());
                                                                        }

                                                                    }
                                                                    catch (FormatException ex)
                                                                    {

                                                                    }
                                                                }
                                                                else if (confirm == "N" || confirm == "n")
                                                                {
                                                                    Console.WriteLine("Opération rejetée!!\n");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Incorrect choix");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Votre code de carte  est incorrect!!!\n\n");
                                                            }
                                                            


                                                        }

                                                        else if (method == 4)
                                                        {
                                                            Console.WriteLine("-----------------\n|Votre Solde:" + j + "dh|\n-----------------");
                                                            Console.WriteLine("Prix d'achat:");
                                                            String Montant0 = Console.ReadLine();


                                                            String[] strlist2 = Montant0.Split("dh");
                                                            foreach (String i in strlist2)
                                                            {
                                                                try
                                                                {
                                                                    int x = int.Parse(i);
                                                                    if (x <= y)
                                                                    {
                                                                        int newMontant2 = y - x;
                                                                        Console.WriteLine("\nL'achat est payée!!\n");
                                                                        Console.WriteLine("-----------------\n| Votre Solde est:" + newMontant2 + "dh|\n-----------------\n");
                                                                    }

                                                                    else if (x > y)
                                                                    {
                                                                        Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                    }

                                                                }
                                                                catch (FormatException ex)
                                                                {

                                                                }
                                                            }
                                                        }

                                                        else if (method == 5)
                                                        {
                                                            Console.WriteLine("-----------------\n|Votre Solde est:" + j + "dh|\n-----------------");
                                                            Console.WriteLine("Montant:");
                                                            String Montant2 = Console.ReadLine();


                                                            String[] strlist = Montant2.Split("dh");
                                                            foreach (String i in strlist)
                                                            {
                                                                try
                                                                {
                                                                    int x = int.Parse(i);
                                                                    if (x <= y)
                                                                    {
                                                                        int newMontant = y - x;
                                                                        Console.WriteLine("L'opération est faite!!");
                                                                        Console.WriteLine("-----------------\n| Votre Solde est:" + newMontant + "dh|\n-----------------");
                                                                    }

                                                                    else if (x > y)
                                                                    {
                                                                        Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                    }

                                                                }
                                                                catch (FormatException ex)
                                                                {

                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Incorrect Choix ");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Votre Compte est vide vous pouvez plus faire votre opérations bancaires");
                                                    }

                                                }


                                                catch
                                                {

                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Compte Vide ---");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect id Compte!");

                                    }
                                }
                                else if (type==2)
                                {
                                    Console.WriteLine("Votre choix est fait par success!!\n\n");
                                    Console.ReadKey();
                                }
                                else{
                                    Console.WriteLine("Incorrect choix");
                                }

                            }


                        }

                        else if (UserCompteType == 2)
                        { 
                            Console.WriteLine("Votre Solde (dh) est:");
                            String sold = Console.ReadLine();
                            String[] newsold = sold.Split("dh");
                            foreach (String k in newsold)
                            {
                                try
                                {
                                int intsold = int.Parse(k);
                                int taux = (intsold/100) * 10;
                                Console.WriteLine("Votre taux est:"+taux+"%");
                                
                                Console.ReadKey();
                                    Console.WriteLine("Merci de votre activité :-)\n\n");
                                }
                                catch (FormatException ex)
                                {
                                    //Console.WriteLine(ex.Message);
                                }

                            }


                        }
                        else
                        {
                            Console.WriteLine("Incorrect option ");
                        }


                    }

                    // Entreprise option select ---------------------------------------------------------------------


                    else
                    {



                        Console.WriteLine("Id_Entreprise:");
                        int IdEntreprise = int.Parse(Console.ReadLine());


                        Console.WriteLine("Nom_Entreprise:");
                        String  NomEntreprise = Console.ReadLine();

                        Console.WriteLine("Date d'Entreprise:");
                        String DateCreation = Console.ReadLine();

                    
                        Entreprise Ent = new Entreprise(IdEntreprise, NomEntreprise, DateCreation);
                        prise.Add(Ent);

                        Console.WriteLine("Vous voulez creér : \n 1)-Compte Courrant \n 2)-Compte Epargne");
                        int UserCompteType2 = int.Parse(Console.ReadLine());
                        if (UserCompteType2 == 1)
                        {
                            Console.WriteLine("Créez un id pour votre compte :");
                            int id2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Confirmez votre id de compte:");
                            int c_id2 = int.Parse(Console.ReadLine());
                            c.IdCompteP = id2;
                            if (id2 == c_id2)
                            {
                                Console.WriteLine("\nVotre compte est crée avec 0 dh !!\n");
                                Console.WriteLine("1-Carte Monétique\n2-Un Chéquier\n3-Un découvert\n4-Généant des charges mensuelles");
                                int type2 = int.Parse(Console.ReadLine());
                                if (type2 == 1 || type2 == 3 || type2 == 4)
                                {
                                    Console.WriteLine("Attendz un peu ,Votre compte sera redémarrer pour des raisons de sécurité");

                                    Thread.Sleep(5000);
                                    Console.WriteLine("\n----------------------------\nS'inscrire\n----------------------------");
                                    Console.WriteLine("\nId compte:");
                                    int UserCompte = int.Parse(Console.ReadLine());
                                    if (UserCompte == c.IdCompteP)
                                    {
                                        Console.WriteLine("\n-----------------\n|Votre Solde est:00dh|\n-----------------\n");
                                        Console.WriteLine("1-Inserer d'argents\n2-Pas maintenant\n");

                                        int choix = int.Parse(Console.ReadLine());
                                        if (choix == 1)
                                        {
                                            Console.WriteLine("Inserer un montant d'argents(au minimum 100dh):");
                                            String arg = Console.ReadLine();
                                            String[] newarg = arg.Split("dh");
                                            foreach (String j2 in newarg)
                                            {
                                                try
                                                {
                                                    int y = int.Parse(j2);
                                                    if (y >= 100)
                                                    {
                                                        Console.WriteLine("\n-----------------\n|Votre Solde est:" + j2 + "dh|\n-----------------\n");
                                                        Console.WriteLine("1-Versement\n2-Virement\n3-Paiement par carte\n4-Paiement par Internet\n5-Retrait d'argent");
                                                        int method = int.Parse(Console.ReadLine());
                                                        if (method == 1)
                                                        {
                                                            Console.WriteLine("-----------------\n|Votre Solde est:" + j2 + "dh|\n-----------------");
                                                            Console.WriteLine("N°Compte:");
                                                            Console.ReadLine();
                                                            Console.WriteLine("Montant:");
                                                            String Montant = Console.ReadLine();


                                                            String[] strlist = Montant.Split("dh");
                                                            foreach (String i in strlist)
                                                            {
                                                                try
                                                                {
                                                                    int x = int.Parse(i);
                                                                    if (x <= y)
                                                                    {
                                                                        int newMontant = y - x;
                                                                        Console.WriteLine("L'opération est faite!!");

                                                                        Console.WriteLine("-----------------\n| Votre Solde est:" + newMontant + "dh|\n-----------------");
                                                                    }

                                                                    else if (x > y)
                                                                    {
                                                                        Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                    }

                                                                }
                                                                catch (FormatException ex)
                                                                {
                                                                    //Console.WriteLine(ex.Message);
                                                                }
                                                            }

                                                        }
                                                        else if (method == 2)
                                                        {
                                                            Console.WriteLine("-----------------\n|Votre Solde est:" + j2 + "dh|\n-----------------");
                                                            Console.WriteLine("N°Compte:");
                                                            int NumCompte = int.Parse(Console.ReadLine());
                                                            Console.WriteLine("Montant:");
                                                            String Montant = Console.ReadLine();


                                                            String[] strlist = Montant.Split("dh");
                                                            foreach (String i in strlist)
                                                            {
                                                                try
                                                                {
                                                                    int x = int.Parse(i);
                                                                    if (x <= y)
                                                                    {
                                                                        int newMontant = y - x;
                                                                        //DateTime now = DateTime.Now;
                                                                        DateTime utc = DateTime.UtcNow;

                                                                        //Console.WriteLine($"UTC time {utc:HH:mm:ss}");
                                                                        Console.WriteLine("\nL'opération est faite!!\n\n");
                                                                        Console.WriteLine("---------------Activité---------------");
                                                                        Console.WriteLine("\nVotre Solde est:" + newMontant + "dh\n");
                                                                        Console.WriteLine("La somme d'argent sera convertir:" + Montant + "\nau compte:" + NumCompte);
                                                                        Console.WriteLine($"Date: {utc:HH:mm:ss}\n-------------------------");
                                                                    }

                                                                    else if (x > y)
                                                                    {
                                                                        Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                    }

                                                                }
                                                                catch (FormatException ex)
                                                                {
                                                                    //Console.WriteLine(ex.Message);
                                                                }
                                                            }

                                                        }
                                                        else if (method == 3)
                                                        {
                                                            Console.WriteLine("Inserer votre carte et (Cliquer sur entrer pour Continuer)--");
                                                            Console.ReadKey();
                                                            Console.WriteLine("Carte Code:");
                                                            int  code = int.Parse(Console.ReadLine());
                                                            if (code == c.IdCompteP)
                                                            {
                                                                Console.WriteLine("Facteur d'eau:\t\t80  dh\nFacteur d'électricité:\t100 dh\nvotre achats:\t\t150 dh\nTVA:\t\t\t08  dh\n------------------------------\n Total\t\t\t298 dh");
                                                                Console.WriteLine("Confirmez votre operation(Y/N):");
                                                                String confirm = Console.ReadLine();

                                                                if (confirm == "Y" || confirm == "y")
                                                                {
                                                                    try
                                                                    {
                                                                        if (298 <= y)
                                                                        {
                                                                            DateTime utc = DateTime.UtcNow;
                                                                            int newMontant = y - 298;

                                                                            Console.WriteLine("\nL'opération est faite!!\n\n");
                                                                            Console.WriteLine("---------------Paiement Activité---------------");
                                                                            Console.WriteLine($"Date: {utc:HH:mm:ss}\n");
                                                                            Console.WriteLine("Votre Solde est:" + newMontant + "dh\n");
                                                                            Console.WriteLine("Facteur d'eau:\t\t80  dh\nFacteur d'électricité:\t100 dh\nvotre achats:\t\t150 dh\nTVA:\t\t\t08  dh\n-------------------------\nTotal\t\t\t298 dh");

                                                                        }

                                                                        else if (298 > y)
                                                                        {
                                                                            Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                        }

                                                                    }
                                                                    catch (FormatException ex)
                                                                    {

                                                                    }

                                                                }
                                                                else if (confirm == "N" || confirm == "n")
                                                                {
                                                                    Console.WriteLine("Operation rejetée\n");
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Incorrect choix");
                                                                }

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Votre code de carte  est Incorrect \n\n");

                                                            }
                                                        }

                                                        else if (method == 4)
                                                        {
                                                            Console.WriteLine("-----------------\n|Votre Solde est" + j2 + "dh|\n-----------------");
                                                            Console.WriteLine("Prix d'achat:");
                                                            String Montant0 = Console.ReadLine();


                                                            String[] strlist2 = Montant0.Split("dh");
                                                            foreach (String i in strlist2)
                                                            {
                                                                try
                                                                {
                                                                    int x = int.Parse(i);
                                                                    if (x <= y)
                                                                    {
                                                                        int newMontant2 = y - x;
                                                                        Console.WriteLine("\nL'achat est payée!!\n");
                                                                        Console.WriteLine("-----------------\n| Votre Solde est:" + newMontant2 + "dh|\n-----------------\n");
                                                                    }

                                                                    else if (x > y)
                                                                    {
                                                                        Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                    }

                                                                }
                                                                catch (FormatException ex)
                                                                {

                                                                }
                                                            }
                                                        }

                                                        else if (method == 5)
                                                        {
                                                            Console.WriteLine("-----------------\n|Votre Solde est:" + j2 + "dh|\n-----------------");
                                                            Console.WriteLine("Montant:");
                                                            String Montant2 = Console.ReadLine();


                                                            String[] strlist = Montant2.Split("dh");
                                                            foreach (String i in strlist)
                                                            {
                                                                try
                                                                {
                                                                    int x = int.Parse(i);
                                                                    if (x <= y)
                                                                    {
                                                                        int newMontant = y - x;
                                                                        Console.WriteLine("L'opération est faite!!");
                                                                        Console.WriteLine("-----------------\n| Votre Solde est:" + newMontant + "dh|\n-----------------");
                                                                    }

                                                                    else if (x > y)
                                                                    {
                                                                        Console.WriteLine("Votre solde n'est pas suffissant!!!");
                                                                    }

                                                                }
                                                                catch (FormatException ex)
                                                                {

                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Incorrect Choix ");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Votre Compte est vide vous pouvez plus faire votre opérations bancaires");
                                                    }

                                                }


                                                catch
                                                {

                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Compte Vide ---");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect id Compte!");

                                    }

                                }
                                else if (type2 == 2)
                                {
                                    Console.WriteLine("Votre choix est fait par success!!\n\n");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect choix");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nincorrect code");
                            }
                                
                        }
                        else if (UserCompteType2 == 2)
                        {
                            Console.WriteLine("Votre Solde (dh) est:");
                            String sold = Console.ReadLine();
                            String[] newsold = sold.Split("dh");
                            foreach (String k in newsold)
                            {
                                try
                                {
                                    int intsold = int.Parse(k);
                                    int taux = (intsold / 100) * 10;
                                    Console.WriteLine("Votre taux est:" + taux + "%");

                                    Console.ReadKey();
                                    Console.WriteLine("Merci de votre activité :-)\n\n");
                                }
                                catch (FormatException ex)
                                {
                                    //Console.WriteLine(ex.Message);
                                }

                            }


                        }
                        else
                        {
                            Console.WriteLine("Incorrect option ");
                        }




                    }
                }
                else if (UserInput == 2)
                {
                    Console.WriteLine("Id compte:");
                    int addCode = int.Parse(Console.ReadLine());
                    if (addCode == 123456) 
                    {
                        int UserType = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Votre code est incorrect essayez celui-ci:'123456'");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect choix");
                }

            }
            
        }
    }
}










