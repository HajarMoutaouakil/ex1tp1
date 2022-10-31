public class exercice1
{
    public static void Main()
    {
        int nombre;
        Console.Write("Entrer un nombre entier: ");
        nombre = int.Parse(Console.ReadLine());
        premier(nombre);

    }
    public static void premier(int nbre)
    {
        int a = 1;
        int s = (int)Math.Sqrt(nbre);
        for (int i = 2; i <= s; i++)
        {
            if(nbre % i == 0)
            {
                a = 0;
                break;
            }
        }
        if (a == 0)
            Console.Write("Le nombre n'est pas premier");
        else
            Console.Write("Le nombre est premier");
    }
}
