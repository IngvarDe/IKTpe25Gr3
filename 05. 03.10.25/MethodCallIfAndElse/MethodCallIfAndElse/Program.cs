namespace MethodCallIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kas kutsuda meetod v'lja");
            Console.WriteLine("vastused on ei või ja");
            //vaja teha if ja else-ga kontroll
            //kui sisestad ja, siis kutsub meetodi v'lja
            //kui kirjutad ei, siis ei kutsu meetodit v'lja
            string choice = Console.ReadLine();

            if (choice == "ja")
            {
                //siin kutsun DoSomething meetodi v'lja
                DoSomething();
            }
            else if (choice == "ei")
            {
                Console.WriteLine("Ei kutsunud meetodit välja");
            }
            else
            {
                Console.WriteLine("Vale valik. ERRORR!!!");
            }
        }


        static void DoSomething()
        {
            Console.WriteLine("See on DoSomething meetod");
        }
    }
}
