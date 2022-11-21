Console.WriteLine("Please enter a number to display a number");
int number = int.Parse(Console.ReadLine());
while(number > 1)
{
    if(number % 2 == 0) // for even numbers
        {
            number = number / 2;
            Console.WriteLine(number);
        }
        else
        {
            number = number * 3 + 1;
            Console.WriteLine(number);
        }
}
    return 0;
