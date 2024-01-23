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

        //Dificil
        public static void HardDificult(ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, ref int VidM, ref int AtaP1, ref int AtaP2, ref int AtaP3, ref int AtaP4, ref int AtaM, ref int RedP1, ref int RedP2, ref int RedP3, ref int RedP4, ref int RedM, ref string[] personatges, ref string[] copiapersonatges, ref int choose, ref int atacCritic, ref int fallarAtac)
        {
            VidP1 = 1500; VidP2 = 3000; VidP3 = 1000; VidP4 = 2000; VidM = 12000;

            AtaP1 = 180; AtaP2 = 150; AtaP3 = 300; AtaP4 = 70; AtaM = 400;

            RedP1 = 25; RedP2 = 35; RedP3 = 20; RedP4 = 25; RedM = 30;



        }

        //Personalitzada

        public static void Personalized(ref int VidP, ref int AtaP, ref int RedP, int vidaMin, int vidaMax, int ataqueMin, int ataqueMax, int reduccionMin, int reduccionMax, string NomPersonatges)
        {
            Console.Clear();

            int intents = 3;

            do
            {
                Console.WriteLine($"Introdueix la vida de {NomPersonatges} [{vidaMin}-{vidaMax}]: ");
                VidP = Convert.ToInt32(Console.ReadLine());
                if (VidP > vidaMax || VidP < vidaMin)
                {
                    Console.WriteLine("Introdueix els valors dins del rang!");
                    intents--;
                }

            } while (VidP > vidaMax || VidP < vidaMin && intents > 0);
            if (intents <= 0) { Console.WriteLine("Vida minima introduida!"); VidP = vidaMin; }
            intents = 3;

            do
            {
                Console.WriteLine($"Introdueix l'atac de {NomPersonatges} [{ataqueMin}-{ataqueMax}]: ");
                AtaP = Convert.ToInt32(Console.ReadLine());
                if (AtaP > ataqueMax || AtaP < ataqueMin)
                {
                    Console.WriteLine("Introdueix els valors dins del rang!");
                    intents--;
                }

            } while (AtaP > ataqueMax || AtaP < ataqueMin && intents > 0);
            if (intents <= 0) { Console.WriteLine("Atac minim introduit!"); AtaP = ataqueMin; }
            intents = 3;

            do
            {
                Console.WriteLine($"Introdueix la reducció de dany de {NomPersonatges} (valor percentual): [{reduccionMin}-{reduccionMax}]%: ");
                RedP = Convert.ToInt32(Console.ReadLine());
                if (RedP > reduccionMax || RedP < reduccionMin)
                {
                    Console.WriteLine("Introdueix els valors dins del rang!");
                    intents--;
                }

            } while (RedP > reduccionMax || RedP < reduccionMin && intents > 0);
            if (intents <= 0) { Console.WriteLine("Reduccio de dany minima introduida!"); RedP = reduccionMin; }
            intents = 3;




        }

        public static void Personalized(ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, ref int VidM, ref int AtaP1, ref int AtaP2, ref int AtaP3, ref int AtaP4, ref int AtaM, ref int RedP1, ref int RedP2, ref int RedP3, ref int RedP4, ref int RedM, ref string[] personatges, ref string[] copiapersonatges, ref int choose, ref int atacCritic, ref int fallarAtac)
        {
            Personalized(ref VidP1, ref AtaP1, ref RedP1, 1500, 2000, 180, 300, 25, 40, personatges[0]);
            Personalized(ref VidP2, ref AtaP2, ref RedP2, 3000, 3750, 150, 250, 35, 45, personatges[1]);
            Personalized(ref VidP3, ref AtaP3, ref RedP3, 1000, 1500, 300, 350, 20, 35, personatges[2]);
            Personalized(ref VidP4, ref AtaP4, ref RedP4, 2000, 2500, 70, 120, 25, 40, personatges[3]);
            Personalized(ref VidM, ref AtaM, ref RedM, 9000, 12000, 250, 400, 20, 30, "Monstre");

        }


        //Random
        public static void Random(ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, ref int VidM, ref int AtaP1, ref int AtaP2, ref int AtaP3, ref int AtaP4, ref int AtaM, ref int RedP1, ref int RedP2, ref int RedP3, ref int RedP4, ref int RedM, ref string[] personatges, ref string[] copiapersonatges, ref int choose, ref int atacCritic, ref int fallarAtac)
        {
            Random rnd = new Random();
            VidP1 = rnd.Next(1500, 2001);
            VidP2 = rnd.Next(3000, 3751);
            VidP3 = rnd.Next(1000, 1501);
            VidP4 = rnd.Next(2000, 2501);
            VidM = rnd.Next(9000, 12001);
            AtaP1 = rnd.Next(180, 301);
            AtaP2 = rnd.Next(150, 251);
            AtaP3 = rnd.Next(300, 351);
            AtaP4 = rnd.Next(70, 121);
            AtaM = rnd.Next(250, 401);
            RedP1 = rnd.Next(25, 41);
            RedP2 = rnd.Next(35, 46);
            RedP3 = rnd.Next(20, 36);
            RedP4 = rnd.Next(25, 41);
            RedM = rnd.Next(20, 31);



        }













    }

}

