using System;

namespace ArraysOpg4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] christian = new int[4] { 9, 5, 45, 32 }; //vi har valgt forudbestemte værdier - altid godt at give en grundværdi, om den så bare er nul
            int[] christian2 = new int[4]; //tallene kan undlades, da vi har bestemt dem senere i koden

            // person
            string fornavn, efternavn;
            int skoStørrelse = 0, alder;

            // [0] FornavnsLængde ==9
            // 

            /*
                for (int i = 0; i < christian.Length; i++)
                {
                    Console.WriteLine(christian[i]);
                }
            */
            /*
            // indtaster jeg fornavn og lægger længden (fornavn.Length) ind i christian[0]
            Console.Write("Indtast dit fornavn ");
            fornavn = Console.ReadLine();

            christian[0] = fornavn.Length;

            // fornavns længde [0]
            Console.Write("Din fornavn (" + fornavn + ") ");
            //Console.Write($"Din fornavn ({fornavn}) ");


            if (christian[0] > 8)
            {
                Console.WriteLine("har en perfekt længde");
            }
            else
            {
                Console.WriteLine("er lige kort nok ik");
            }

            Console.Write("Indtast dit efternavn ");
            efternavn = Console.ReadLine();

            christian[1] = efternavn.Length;

            // efternavn længde [1]
            Console.Write("Dit efternavn (" + efternavn + ") ");
            if (christian[1] > 4)
            {
                Console.WriteLine("godt nok et kort efternavn du har");
            }
            else 
            {
                Console.WriteLine("fejl, det er alt for kort det efternavn");
            }
            
            Console.Write("Indtast din skostørrelse ");
            skoStørrelse = Convert.ToInt32(Console.ReadLine());
            christian[2] = skoStørrelse;
           
            // skoStørrelse [2]
            if (christian[2] > 44)
            {
                Console.WriteLine("sikke nogle store fødder");
            }
            else 
            {
                Console.WriteLine("nej nej nej, kan du ikke passe");
            }

            Console.Write("Indtast din alder ");
            alder = Convert.ToInt32(Console.ReadLine());
            christian[3] = alder;

            // alder [3]
            if (christian[3] > 31)
            {
                Console.WriteLine("uh det er en hot alder");
            }
            else 
            {
                Console.WriteLine("gid du var så ung");
            }
            */

            Random randomGenerator = new Random();

            string[] persons = new string[] { "Tore", "Kenneth", "Peter", "Katie", "André" };
            string[] actions = new string[] { "stjæler mederne fra julemandens kane", "drikker snaps", "pakker gaver ind", "pakker kattekillinger ind", "spiser vaniljekranse" };
            string[] causes = new string[] { "julen står for døren", "der er ild i juletræet", "sneen daler blidt ned", "julefrokosten gik over gevir" };
            string who, what, why, who2;

            while (true)
            {
                who = persons[randomGenerator.Next(0, persons.Length)];

                who2 = persons[randomGenerator.Next(0, persons.Length)];

                what = actions[randomGenerator.Next(0, actions.Length)];

                why = causes[randomGenerator.Next(0, causes.Length)];

                Console.WriteLine($"{who} er sammen med {who2}. \nDe {what}, fordi {why}.");
                Console.ReadLine();
            }

        }
    }
}
