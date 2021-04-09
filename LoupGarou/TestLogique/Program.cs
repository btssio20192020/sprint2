﻿using System;
using System.Collections.Generic;
using LoupGarou;

namespace TestLogique
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jeu G1 = new Jeu();

            /*foreach(Role element in G1.lesRoles)
            {
                Console.WriteLine(element.leDescriptif);
            }*/
            Joueur j1 = new Joueur("Lulu", 1);
            Joueur j2 = new Joueur("Boun", 2);
            Joueur j3 = new Joueur("Smuel", 3);
            Joueur j4 = new Joueur("Lilou", 4);
            Joueur j5 = new Joueur("Shreyk", 5);
            Joueur j6 = new Joueur("Gloire", 6);

            G1.lesJoueurs.Add(1, j1);
            G1.lesJoueurs.Add(2, j2);
            G1.lesJoueurs.Add(3, j3);
            G1.lesJoueurs.Add(4, j4);
            G1.lesJoueurs.Add(5, j5);
            G1.lesJoueurs.Add(6, j6);

            G1.attribuerDesRoles();
            foreach (KeyValuePair<int, Joueur> element in G1.lesJoueurs)
            {
                Console.WriteLine(element.Key + " -> " + element.Value.leLogin + "   " + element.Value.leRole.leLibelle + " = " + element.Value.leRole.leDescriptif);
            }
            G1.init();

            G1.setlaNarration(0);
            Console.WriteLine(G1.laNarration);

            G1.setlaNarration(1);
            Console.WriteLine(G1.laNarration);

            G1.setlaNarration(2);
            Console.WriteLine(G1.laNarration);

            G1.activerDesactiver(G1.lesLoupsGarous, true);
            Console.WriteLine(G1.lesLoupsGarous.Count);


            G1.setlaNarration(3);
            Console.WriteLine(G1.laNarration);

            G1.initVote();
           
           

            G1.MAJlesJoueurs();
        }
    }
}
