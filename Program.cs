// Simon Eke - .NET24


namespace MyFirstProgram_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // ------------------------------------
            // ---------Ternary Operator Solution--
            // int number = x;
            // string answer = (number > 10) ? "Talet är stort!" : "Oj. Lågt tal!"
            // Console.WriteLine(answer);
            // ------------------------------------


            // A variable is stored with the value 3 with an integer type
            int number = 3;            

            // An if statement where "number" is compared to 10 to see if it's 
            // bigger than 10. 
            if (number > 10)
            {
                // User is informed if True
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                // User is informed if False
                Console.WriteLine("Oj. Lågt tal!");
            }


            // Asking the user of their name
            Console.WriteLine("Vad heter du? ");

            // Saves the input from the user in a variable called "name"
            string name = Console.ReadLine();

            // Writes a greeting to the user, calling them by name.
            Console.WriteLine($"Hej {name}!");


            // A for-loop which will count the whole numbers from 0 to 
            // the declared variable "number".
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
