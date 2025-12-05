namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ushort i = 1;

            //kui on 10 rida konsoolis, siis lõpetab ära
            //kasutada break;
            for (; ; )
            {
                Console.WriteLine("i väärtus on " + i);
                i++;

                if (i > 10)
                {
                    break;
                }    
            }
        }
    }
}
