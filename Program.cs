internal class Program
{
    private static void Main(string[] args)
    {
        float n3;
        float n4;
        Console.WriteLine("ingrese un numero ");
        n3 = float.Parse(Console.ReadLine());

        Console.WriteLine("ingrese un numero :");
        n4 = float.Parse(Console.ReadLine());
        if ( n3 > n4 ){
            Console.WriteLine("el numero mayor es " + n3);
        }
        

    }
}