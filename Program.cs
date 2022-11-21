using System.ComponentModel.DataAnnotations;
internal class Program
{
    private static void Main(string[] args)
    {
        //The collatz sequence is a conjecture in mathematics that follows a sequence.
        try
        {
            Console.WriteLine("______________________________________________");
            Console.WriteLine("                 WELCOME =)                  ");
            Console.WriteLine("Please enter a number to display a number list");
            Console.WriteLine("______________________________________________");
            var nu = Console.ReadLine();
            if (nu == null || nu == "")
            {
                Console.WriteLine("You did not enter a number...! :(\nPlease enter a number ;)");
                nu = Console.ReadLine(); ;
            }

            int n = Convert.ToInt32(nu);

            while (n > 1)
            {
                if (n % 2 == 0) // for even numbers
                {
                    n = n / 2;
                    Console.WriteLine(n);
                }
                else
                {
                    n = n * 3 + 1; // for odd numbers
                    Console.WriteLine(n);
                }
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}