Console.WriteLine("podaj cyfre:");
int cyfra = int.Parse(Console.ReadLine());
int liczba = 0;
int linijka = 1;
int petla = 0;
for (int i = 0; i < linijka; i++)
{
    Console.WriteLine();
    for (int j = 0; j <= i; j++)
    {
        liczba++;
        if (cyfra >= liczba)
        {
            Console.Write(liczba);
            if (liczba < 10 )
            {
                Console.Write(" ");
            }

        }
        else if (liczba == cyfra + 1)
        {
            petla++;
        }
    }
    linijka++;
    if (petla == 1)
    {
        break;
    }
}