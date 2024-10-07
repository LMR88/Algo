namespace ConsoleApp2;

public class convertir
{
    public void time()
    {

        
        // valeur entré = nombre de secondes 
        Console.Write("Entrez une valeur : ");
        int n = int.Parse(Console.ReadLine());
        
        // temps en seconde converti en jours
        int jours = (n/86400);
        
        // temps en seconde converti en heures
        int heures = (n - jours * 86400)/ 3600 ;
        
        // temps en seconde converti en minutes 
        int minutes = ((n - heures * 3600)- jours * 86400)/ 60 ;
        
        
        Console.Write(jours + " j " + heures + " h " + minutes + " m ");

    }
}