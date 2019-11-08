using System;

namespace Grading
{
    class Marks
    {
        public int Mark = 0;
        public int Weight = 0;
        public string Subj = "A";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Marks[] mark = new Marks [1];
            int i = 1;
            ConsoleKeyInfo result;
            do
            {
                //vytvoreni promenych
                string subjt;
                string inpt;
                int markt;
                int weigt;

                Console.Write("{0}. Žák - známka: ", i);
                inpt = Console.ReadLine();
                int.TryParse(inpt, out markt);
                Console.Write("{0}. Známka - váha: ", i);
                inpt = Console.ReadLine();
                int.TryParse(inpt, out weigt);
                Console.Write("{0}. Známka - předmět: ", i);
                subjt = Console.ReadLine();

                mark[i - 1] = new Marks() { Mark = markt, Weight = weigt, Subj = subjt };
                i += 1;

                Console.Write("Chceš vložit další známky? [A]: ");
                result = Console.ReadKey();
                Console.WriteLine();
            } while (result.Key == ConsoleKey.A);

            int soucet = 0;
            int vahy = 0;

            foreach (Marks znamka in mark)
            {
                soucet =+ znamka.Mark;
                vahy =+ znamka.Weight;
            }
            double prumer = soucet * vahy / soucet;
            Console.WriteLine(prumer);


            Console.ReadKey();
        }
    }
}
