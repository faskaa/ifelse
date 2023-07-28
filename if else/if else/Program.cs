namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
           

            if (number < 5 )
            {
                Console.WriteLine(number - 5);
            }
            else
            {
                Console.WriteLine(number + 5);
            }

            string firstName = "Fazil";
            string secondName = "Bahramov";

            Console.WriteLine(firstName + " " + secondName);
            

        }
    }
}