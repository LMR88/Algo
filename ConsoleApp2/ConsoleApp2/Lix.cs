namespace ConsoleApp2;

public class Lix
{
    public void Solve()

    {
        // permettant d'entrer la valeur min et max
        Console.WriteLine("Veuillez entrer un nombre entre 6 et 956 : ");
        int n = int.Parse(Console.ReadLine());
        if (n < 6 || n > 956)
        {
            Console.WriteLine("Error");
            return;
        }

        for (int i = 6; i <= n; i++)
        {
            if (i % 3 == 0 || i % 4 == 0)
            {
                Console.WriteLine("C");
            }

            if (i % 7 == 0 || i % 18 == 0)
            {
                Console.WriteLine("A");
            }

            if (i % 42 == 0)
            {
                Console.WriteLine("CA");
            }

        }
    }
}

