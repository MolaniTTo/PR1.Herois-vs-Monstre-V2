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

        //Batalla
        public static void Batalla(ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, ref int VidM, ref int AtaP1, ref int AtaP2, ref int AtaP3, ref int AtaP4, ref int AtaM, ref int RedP1, ref int RedP2, ref int RedP3, ref int RedP4, ref int RedM, ref string[] personatges, ref string[] copiapersonatges, ref int choose, ref int atacCritic, ref int fallarAtac)

        {
            int torns = 1, act = 0, intents = 3;
            int HB1 = 0, HB2 = 0, HB3 = 0, HB4 = 0;

            while ((VidP1 > 0 || VidP2 > 0 || VidP3 > 0 || VidP4 > 0) && (VidM > 0))
            {
                Console.WriteLine();
                Console.WriteLine("Torn " + torns);

                // Generar Ordre Aleatori

                GenerarOrdreAtac(copiapersonatges);


                foreach (string personatge in copiapersonatges)
                {
                    if ((VidP1 < 0 && VidP2 < 0 && VidP3 < 0 && VidP4 < 0) || (VidM == 0)) { break; }
                    if (PersonatgeViu(personatges, VidP1, VidP2, VidP3, VidP4, personatge))
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{personatge}, selecciona l'accio:");

                            Console.WriteLine("1. Atacar");
                            Console.WriteLine("2. Protegir-se");
                            if (personatge.Equals(personatges[0]) && HB1 != 0) { Console.WriteLine($"3. Habilitat especial DESHABILITADA, queden {HB1} torn/s"); }
                            else if (personatge.Equals(personatges[1]) && HB2 != 0) { Console.WriteLine($"3. Habilitat especial DESHABILITADA, queden {HB2} torn/s"); }
                            else if (personatge.Equals(personatges[2]) && HB3 != 0) { Console.WriteLine($"3. Habilitat especial DESHABILITADA, queden {HB3} torn/s"); }
                            else if (personatge.Equals(personatges[3]) && HB4 != 0) { Console.WriteLine($"3. Habilitat especial DESHABILITADA, queden {HB4} torn/s"); }
                            else { Console.WriteLine("3. Habilitat especial"); }


                            // Obtener la acción del usuario
                            act = Convert.ToInt32(Console.ReadLine());

                            switch (act)
                            {
                                case 1:
                                    Atac(personatge, AtaP1, AtaP2, AtaP3, AtaP4, RedM, personatges, ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, choose, atacCritic, fallarAtac);
                                    break;

                                case 2:
                                    Defensa(personatge, ref RedP1, ref RedP2, ref RedP3, ref RedP4, personatges);
                                    break;

                                case 3:
                                    if (personatge.Equals(personatges[0]) && HB1 != 0) { Console.WriteLine($"{personatges[0]} passa el torn!"); }
                                    else if (personatge.Equals(personatges[1]) && HB2 != 0) { Console.WriteLine($"{personatges[1]} passa el torn!"); }
                                    else if (personatge.Equals(personatges[2]) && HB3 != 0) { Console.WriteLine($"{personatges[2]} passa el torn!"); }
                                    else if (personatge.Equals(personatges[3]) && HB4 != 0) { Console.WriteLine($"{personatges[3]} passa el torn!"); }
                                    else { HabilitatEspecial(ref VidP1, ref VidP2, ref VidP3, ref VidP4, ref VidM, personatge, AtaP3, RedP2, personatges, ref HB1, ref HB2, ref HB3, ref HB4, ref CountHB, ref auxRedP2); }

                                    break;

                                default:
                                    Console.WriteLine("Accio no valida."); intents--;
                                    break;
                            }

                        } while (act < 1 || act > 3 && intents > 0);
                        if (intents <= 0) { End(intents, choose); }

                    }

                    else { Console.WriteLine($"El personatge {personatge} esta mort."); }




                }


                if (HB1 > 3) { Console.WriteLine(); Console.WriteLine($"El monstre esta noquejat per {personatges[0]}, no por atacar!"); Console.WriteLine(); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose); }
                else if (VidM > 0 && HB1 < 3) { AtacMonstre(ref VidP1, ref VidP2, ref VidP3, ref VidP4, ref VidM, AtaM, RedP1, RedP2, RedP3, RedP4, personatges, copiapersonatges, CountHB, choose); }

                roudValidations( RedP1,  RedP2,  RedP3,  RedP4, ref  HB1, ref  HB2, ref  HB3, ref  HB4, ref  CountHB);
                torns++;

            }


        }



        static bool PersonatgeViu(string[] personatges, int VidP1, int VidP2, int VidP3, int VidP4, string personatge)
        {
            for (int i = 0; i < personatges.Length; i++)
            {
                if (personatges[i] == personatge)
                {
                    switch (i)
                    {
                        case 0:
                            return VidP1 > 0;
                        case 1:
                            return VidP2 > 0;
                        case 2:
                            return VidP3 > 0;
                        case 3:
                            return VidP4 > 0;
                        default:
                            return false;
                    }
                }
            }
            return false;

        }
        static void Atac(string personatge, int AtaP1, int AtaP2, int AtaP3, int AtaP4, int RedM, string[] personatges, ref int VidM, ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, int choose, int atacCritic, int fallarAtac)
        {
            AtacCritic(ref atacCritic);
            FallarAtac(ref fallarAtac);

            if ((atacCritic <= 10 && fallarAtac <= 5 && fallarAtac >= 1) || (atacCritic > 10 && fallarAtac <= 5 && fallarAtac >= 1)) { Console.WriteLine("Ha fallat l'atac"); }

            else if (atacCritic <= 10 && fallarAtac > 5)
            {
                Console.WriteLine("Atac critic!");
                if (personatge.Equals(personatges[0]))
                {
                    VidM -= (AtaP1 * 2) * (100 - RedM) / 100;
                    Console.WriteLine($"{personatge} ataca al monstre amb {AtaP1}. El Monstre es defensa i rep només {(AtaP1 * 2) * (100 - RedM) / 100}."); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);
                }

                else if (personatge.Equals(personatges[1]))
                {
                    VidM -= (AtaP2 * 2) * (100 - RedM) / 100;
                    Console.WriteLine($"{personatge} ataca al monstre amb {AtaP2}. El Monstre es defensa i rep només {(AtaP2 * 2) * (100 - RedM) / 100}."); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);
                }

                else if (personatge.Equals(personatges[2]))
                {
                    VidM -= (AtaP3 * 2) * (100 - RedM) / 100;
                    Console.WriteLine($"{personatge} ataca al monstre amb {AtaP3}. El Monstre es defensa i rep només {(AtaP3 * 2) * (100 - RedM) / 100}."); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);
                }

                else if (personatge.Equals(personatges[3]))
                {
                    VidM -= (AtaP4 * 2) * (100 - RedM) / 100;
                    Console.WriteLine($"{personatge} ataca al monstre amb {AtaP4}. El Monstre es defensa i rep només {(AtaP4 * 2) * (100 - RedM) / 100}."); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);
                }


            }

            else if (atacCritic > 10 && fallarAtac > 5)
            {
                if (personatge.Equals(personatges[0]))
                {
                    VidM -= (AtaP1 * (100 - RedM) / 100);
                    Console.WriteLine($"{personatge} ataca al monstre amb {AtaP1}. El Monstre es defensa i rep només {(AtaP1 * (100 - RedM) / 100)}."); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);
                }

                else if (personatge.Equals(personatges[1]))
                {
                    VidM -= (AtaP2 * (100 - RedM) / 100);
                    Console.WriteLine($"{personatge} ataca al monstre amb {AtaP2}. El Monstre es defensa i rep només {(AtaP2 * (100 - RedM) / 100)}."); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);
                }

                else if (personatge.Equals(personatges[2]))
                {
                    VidM -= (AtaP3 * (100 - RedM) / 100);
                    Console.WriteLine($"{personatge} ataca al monstre amb {AtaP3}. El Monstre es defensa i rep només {(AtaP3 * (100 - RedM) / 100)}."); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);
                }

                else if (personatge.Equals(personatges[3]))
                {
                    VidM -= (AtaP4 * (100 - RedM) / 100);
                    Console.WriteLine($"{personatge} ataca al monstre amb {AtaP4}. El Monstre es defensa i rep només {(AtaP4 * (100 - RedM) / 100)}."); validateVidasMonstre(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);
                }


            }

        }

        public static int Defensa(string personatge, ref int RedP1, ref int RedP2, ref int RedP3, ref int RedP4, string[] personatges)
        {
            if (personatge.Equals(personatges[0]))
            {
                RedP1 *= 2;
                Console.WriteLine($"{personatge} es protegeix del monstre i duplica la seva reduccio de dany pel proxim atac");
                return RedP1;
            }

            else if (personatge.Equals(personatges[1]))
            {

                RedP2 *= 2;
                Console.WriteLine($"{personatge} es protegeix del monstre i duplica la seva reduccio de dany pel proxim atac");
                return RedP2;
            }

            else if (personatge.Equals(personatges[2]))
            {
                RedP3 *= 2;
                Console.WriteLine($"{personatge} es protegeix del monstre i duplica la seva reduccio de dany pel proxim atac");
                return RedP3;
            }

            else if (personatge.Equals(personatges[3]))
            {
                RedP4 *= 2;
                Console.WriteLine($"{personatge} es protegeix del monstre i duplica la seva reduccio de dany pel proxim atac");
                return RedP4;
            }
            else { return 0; }

        }

        public static int HabilitatEspecial(ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, ref int VidM, string personatge, int AtaP3, int RedP2, string[] personatges, ref int HB1, ref int HB2, ref int HB3, ref int HB4, ref int CountHB, ref int auxRedP2)
        {


            if (personatge.Equals(personatges[0]))
            {
                HB1 = 5;
                Console.WriteLine($"{personatge} noqueja el monstre durant 2 torns (no pot atacar)");
                return HB1;
            }

            else if (personatge.Equals(personatges[1]))
            {
                HB2 = 5;
                auxRedP2 = RedP2;
                CountHB = 3;
                Console.WriteLine($"{personatge} augmenta la seva defensa al 100% durant 3 torns");
                return HB2;
            }

            else if (personatge.Equals(personatges[2]))
            {
                HB3 = 5;
                VidM -= AtaP3 * 3;
                Console.WriteLine($"{personatge} dispara una bola de foc que fa {AtaP3 * 3} de dany");
                return HB3;
            }

            else if (personatge.Equals(personatges[3]))
            {
                HB4 = 5;
                Console.WriteLine($"{personatge} cura 500 de vida a tots els personatges");
                VidP1 += 500;
                VidP2 += 500;
                VidP3 += 500;
                VidP4 += 500;
                return HB4;

            }
            else { return 0; }

        }

        static void AtacMonstre(ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, ref int VidM, int AtaM, int RedP1, int RedP2, int RedP3, int RedP4, string[] personatges, string[] copiapersonatges, int CountHB, int choose)
        {
            RedP2 = (CountHB != 0) ? 100 : RedP2;
            //afegir la habilitat especial de defensa del barbar
            VidP1 -= (AtaM * (100 - RedP1) / 100);
            VidP2 -= (AtaM * (100 - RedP2) / 100);
            VidP3 -= (AtaM * (100 - RedP3) / 100);
            VidP4 -= (AtaM * (100 - RedP4) / 100);

            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine($"El monstre ataca a {personatges[0]}, {personatges[1]}, {personatges[2]}, i a {personatges[3]} amb {AtaM} de dany!");
            Console.WriteLine();
            if (VidP1 > 0) { Console.WriteLine($"{personatges[0]} es defensa i rep només {(AtaM * (100 - RedP1) / 100)} de dany."); }
            if (VidP2 > 0) { Console.WriteLine($"{personatges[1]} es defensa i rep només {(AtaM * (100 - RedP2) / 100)} de dany."); }
            if (VidP3 > 0) { Console.WriteLine($"{personatges[2]} es defensa i rep només {(AtaM * (100 - RedP3) / 100)} de dany."); }
            if (VidP4 > 0) { Console.WriteLine($"{personatges[3]} es defensa i rep només {(AtaM * (100 - RedP4) / 100)} de dany."); }

            validateVidasHerois(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose);

        }

        static void GenerarOrdreAtac(string[] copiapersonatges)
        {
            Random random = new Random();

            // Aplicar el algoritmo de Fisher-Yates
            for (int i = copiapersonatges.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                // Intercambiar personatges[i] y personatges[j]
                string temp = copiapersonatges[i];
                copiapersonatges[i] = copiapersonatges[j];
                copiapersonatges[j] = temp;
            }

        }


        static void roudValidations( int RedP1, int RedP2, int RedP3, int RedP4, ref int HB1, ref int HB2, ref int HB3, ref int HB4, ref int CountHB)
        {

            if (RedP1 >= 50 && RedP1 <= 80) { RedP1 /= 2; }
            if (RedP2 >= 70 && RedP2 <= 90) { RedP2 /= 2; }
            if (RedP3 >= 40 && RedP3 <= 70) { RedP3 /= 2; }
            if (RedP4 >= 50 && RedP4 <= 80) { RedP4 /= 2; }

            if (HB1 != 0) { HB1--; }
            if (HB2 != 0) { HB2--; }
            if (HB3 != 0) { HB3--; }
            if (HB4 != 0) { HB4--; }

            if (CountHB >= 1 && CountHB <= 3) { CountHB--; };


        }

        static void validateVidasHerois(ref int VidM, ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, string[] personatges, int choose)
        {
            Console.WriteLine();
            if (VidP1 <= 0) { VidP1 = 0; Console.WriteLine($"Vida restant de {personatges[0]}: {VidP1}, esta mort"); }
            if (VidP2 <= 0) { VidP2 = 0; Console.WriteLine($"Vida restant de {personatges[1]}: {VidP2}, esta mort"); }
            if (VidP3 <= 0) { VidP3 = 0; Console.WriteLine($"Vida restant de {personatges[2]}: {VidP3}, esta mort"); }
            if (VidP4 <= 0) { VidP4 = 0; Console.WriteLine($"Vida restant de {personatges[3]}: {VidP4}, esta mort"); }

            int[] marks = new int[] { VidP1, VidP2, VidP3, VidP4 };
            for (int i = 0; i < marks.Length - 1; i++)
            {

                for (int j = i + 1; j < marks.Length; j++)
                {

                    if (marks[i] < marks[j])
                    {

                        int aux = marks[i];
                        marks[i] = marks[j];
                        marks[j] = aux;
                    }
                }
            }

            for (int i = 0; i < marks.Length; i++)
            {
                if (VidP1 > 0 && VidP1 == marks[i]) { Console.WriteLine($"Vida restant de {personatges[0]}: {VidP1}"); }
                if (VidP2 > 0 && VidP2 == marks[i]) { Console.WriteLine($"Vida restant de {personatges[1]}: {VidP2}"); }
                if (VidP3 > 0 && VidP3 == marks[i]) { Console.WriteLine($"Vida restant de {personatges[2]}: {VidP3}"); }
                if (VidP4 > 0 && VidP4 == marks[i]) { Console.WriteLine($"Vida restant de {personatges[3]}: {VidP4}"); }
            }



            if (VidP1 == 0 && VidP2 == 0 && VidP3 == 0 && VidP4 == 0) { End(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose); }


        }

        static void validateVidasMonstre(ref int VidM, ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, string[] personatges, int choose)
        {
            Console.WriteLine();
            if (VidM <= 0) { VidM = 0; Console.WriteLine($"Vida restant del monstre: {VidM}, esta mort"); End(ref VidM, ref VidP1, ref VidP2, ref VidP3, ref VidP4, personatges, choose); }
            else { Console.WriteLine($"Vida restant del monstre: {VidM}"); }


        }

        static void End(ref int VidM, ref int VidP1, ref int VidP2, ref int VidP3, ref int VidP4, string[] personatges, int choose)
        {
            if (VidM <= 0) { Console.WriteLine($"Els herois {personatges[0]},{personatges[1]}, {personatges[2]} i  {personatges[3]} han derrotat al monstre!"); Console.WriteLine(); }

            else { Console.WriteLine(); Console.WriteLine($"El monstre ha derrotat als herois :("); Console.WriteLine(); }

        }

        static void End(int intents, int choose)
        {
            Console.Clear();
            Console.WriteLine("Has fallat massa cops, ADEU!");

        }

        public static int AtacCritic(ref int atacCritic)
        {

            Random rnd = new Random();
            atacCritic = rnd.Next(1, 101);
            return atacCritic;


        }

        public static int FallarAtac(ref int fallarAtac)
        {
            Random rnd = new Random();
            fallarAtac = rnd.Next(1, 101);
            return fallarAtac;


        }









































    }

}

