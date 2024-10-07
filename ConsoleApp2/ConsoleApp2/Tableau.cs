namespace ConsoleApp2;

public class Tableau
{
     public void tab()
     {
          int n = int.Parse(Console.ReadLine());
          int[] monTableau = new int[n];
          for (int i = monTableau.Length - 1; i > 0; i--)
          {
              if (i%2 == 0)
              {
                  monTableau[i] = monTableau.Length - i;
                  Console.WriteLine(monTableau[i]);
              }
          }
     }
}
    