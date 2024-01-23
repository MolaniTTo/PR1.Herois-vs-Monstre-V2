﻿using System;

namespace Functions
{
    public class Class1
    {

        private static int CountHB = 0;
        private static int auxRedP2 = 0;



        //menu jugar o sortir
        public static int Menu(int choose)
        {
            string Bye = "D'acord, adeu!";
            int intents = 3; choose = 0;

            do
            {
                
                Console.WriteLine("1.Jugar 0.Sortir:");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose > 1 || choose < 0)
                {
                    intents--;
                    Console.WriteLine("Recorda introduir els valors dins del rang!");
                }

            } while ((choose > 1 || choose < 0) && intents > 0);

            if (intents == 0)
            {
                Console.WriteLine("Fins una altra!");
                return intents;
            }
            if (choose == 0) { Console.WriteLine(Bye); }

            return choose;
        }


        //Noms personatges
        public static string[] Noms(string[] personatges)
        {
            Console.Clear();
            for (int i = 0; i < personatges.Length; i++)
            {
                Console.WriteLine($"Introdueix el nom del personatge {i + 1}:");

                personatges[i] = Console.ReadLine();
            }

            return personatges;
        }


        //selector de dificultat
        public static int DificultSelector(int dificultat)
        {
            Console.Clear();
            int intents = 3;

            do
            {
                Console.WriteLine("Introdueix a quina dificultat vols jugar:");
                Console.WriteLine("1.Facil");
                Console.WriteLine("2.Dificil");
                Console.WriteLine("3.Personalitzat");
                Console.WriteLine("4.Random");
                dificultat = Convert.ToInt32(Console.ReadLine());
                if (dificultat > 4 || dificultat < 1) { Console.WriteLine("Recorda introduir els valors dins del rang!"); intents--; }

            } while ((dificultat > 4 || dificultat < 1) && intents > 0);

            if (intents == 0) { Console.WriteLine("Fins una altra!"); return intents; }

            return dificultat;
        }






    }

}

