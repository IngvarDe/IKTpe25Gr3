namespace IfAndElseMethodCall2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb teha if ja else-ga paaris ja paaritu arvu kontroll,
            //mis kutsub välja meetodi
            int number = Convert.ToInt32(Console.ReadLine());

            if (number %2 == 0)
            {
                EvenNumber();
            }
            else
            {
                OddNumber();
            }


            //tuleb teha meetod EvenNumber()
            //Kui kutsutakse välja see meetod, siis tuleb vastus:
            //Tegemist on paaris numbriga

            //tuleb teha teine meetod OddNumber()
            //Kui kutsutakse välja see meetod, siis tuleb vastus:
            //Tegemist on paaritu numbriga
        }

        static void EvenNumber()
        {
            Console.WriteLine("See on paaris number");
        }

        static void OddNumber()
        {
            Console.WriteLine("See on paaritu number");
        }
    }
}
