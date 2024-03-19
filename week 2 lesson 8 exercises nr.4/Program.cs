Console.WriteLine("enter number:");
int enteredNumber = int.Parse(Console.ReadLine());
int number = 0;
int line = 1;
int loop = 0;
for (int i = 0; i < line; i++)
{
    Console.WriteLine();
    for (int j = 0; j <= i; j++)
    {
        number++;
        if (enteredNumber >= number)
        {
            Console.Write(number);
            if (number < 10)
            {
                Console.Write(" ");
            }

        }
        else if (number == enteredNumber + 1)
        {
            loop++;
        }
    }
    line++;
    if (loop == 1)
    {
        break;
    }
}
