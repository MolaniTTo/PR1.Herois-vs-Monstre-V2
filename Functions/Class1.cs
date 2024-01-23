using System;

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

        //Facil

        public static void EasyDificult(ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, ref int VidM, ref int AtaP1, ref int AtaP2, ref int AtaP3, ref int AtaP4, ref int AtaM, ref int RedP1, ref int RedP2, ref int RedP3, ref int RedP4, ref int RedM, ref string[] personatges, ref string[] copiapersonatges, ref int choose, ref int atacCritic, ref int fallarAtac)
        {
            VidP1 = 2000; VidP2 = 3750; VidP3 = 1500; VidP4 = 2500; VidM = 9000;

            AtaP1 = 300; AtaP2 = 250; AtaP3 = 350; AtaP4 = 120; AtaM = 250;

            RedP1 = 40; RedP2 = 45; RedP3 = 35; RedP4 = 40; RedM = 20;



        }







    }

}

