using Functions;
using System.Security.Cryptography.X509Certificates;
namespace HeroisVsMonstreV2
{
    public class HeroisVsMonstreV2Proj
    {

        public static void Main()
        {
            string MsgPrincipal = "Benvingut a HEROIS VS MONSTRE V2!";
            int dificultat = 0, VidP1 = 0, VidP2 = 0, VidP3 = 0, VidP4 = 0, VidM = 0, AtaP1 = 0, AtaP2 = 0, AtaP3 = 0, AtaP4 = 0, AtaM = 0, RedP1 = 0, RedP2 = 0, RedP3 = 0, RedP4 = 0, RedM = 0, choose = 0, atacCritic = 0, fallarAtac = 0;
            const string MsgBatalla = "Que començi la batalla!";
            string[] personatges = new string[4];

            string[] copiaPersonatges = new string[personatges.Length];

            Console.WriteLine(MsgPrincipal);
            Console.WriteLine();



            while (Class1.Menu(choose) == 1)
            {

                Class1.Noms(personatges);

                for (int i = 0; i < personatges.Length; i++)
                {
                    copiaPersonatges[i] = personatges[i];
                }

                switch (Class1.DificultSelector(dificultat))
                {
                    case 1:
                        Class1.EasyDificult(ref VidP1, ref VidP2, ref VidP3, ref VidP4, ref VidM, ref AtaP1, ref AtaP2, ref AtaP3, ref AtaP4, ref AtaM, ref RedP1, ref RedP2, ref RedP3, ref RedP4, ref RedM, ref personatges, ref copiaPersonatges, ref choose, ref atacCritic, ref fallarAtac);

                        break;
                    case 2:
                        Class1.HardDificult(ref VidP1, ref VidP2, ref VidP3, ref VidP4, ref VidM, ref AtaP1, ref AtaP2, ref AtaP3, ref AtaP4, ref AtaM, ref RedP1, ref RedP2, ref RedP3, ref RedP4, ref RedM, ref personatges, ref copiaPersonatges, ref choose, ref atacCritic, ref fallarAtac);
                        break;
                    case 3:
                        Class1.Personalized(ref VidP1, ref VidP2, ref VidP3,ref VidP4, ref VidM, ref AtaP1, ref AtaP2, ref AtaP3, ref AtaP4, ref AtaM, ref RedP1, ref RedP2, ref RedP3, ref RedP4, ref RedM, ref personatges, ref copiaPersonatges, ref choose, ref atacCritic, ref fallarAtac);
                        break;
                    case 4:
                        Class1.Random(ref VidP1, ref VidP2, ref VidP3, ref VidP4, ref VidM, ref AtaP1, ref AtaP2, ref AtaP3, ref AtaP4, ref AtaM, ref RedP1, ref RedP2, ref RedP3, ref RedP4, ref RedM, ref personatges, ref copiaPersonatges, ref choose, ref atacCritic, ref fallarAtac);
                        break;

                }
                if (dificultat>=1 && dificultat <= 4) { Console.Clear(); Console.WriteLine(MsgBatalla); }
                Class1.Batalla(ref VidP1, ref VidP2, ref VidP3, ref VidP4, ref VidM, ref AtaP1, ref AtaP2, ref AtaP3, ref AtaP4, ref AtaM, ref RedP1, ref RedP2, ref RedP3, ref RedP4, ref RedM, ref personatges, ref copiaPersonatges, ref choose, ref atacCritic, ref fallarAtac);
            }

        }
    }
}



        


              