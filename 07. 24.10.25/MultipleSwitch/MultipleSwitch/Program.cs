namespace MultipleSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple cases");

            string topic, category;

            topic = Console.ReadLine();

            switch (topic)
            {
                case "Into to C#":
                case "Variables":
                case "Data Types":
                    category = "Basics";
                    break;

                case "Loops":
                case "If statements":
                case "Jump statements":
                    category = "Control Flow";
                    break;

                case "Class & Objects":
                case "Inheritance":
                case "Constructors":
                    category = "OOP-s Concept";
                    break;

                default:
                    category = "Unknown";
                    break;
            }
            Console.WriteLine("Category is " + category);
        }
    }
}
