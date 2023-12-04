internal class Program
{
    private static void Main(string[] args)
    {
        int opc = 0;
        while (opc != 4)
        {
            Console.Clear();
            Console.WriteLine("MENU NUMEROS AMIGOS");
            Console.WriteLine("1. Conocer si dos numeros son amigos.");
            Console.WriteLine("2. Encontrar el siguiente par de numeros amigos [1000, 1500].");
            Console.WriteLine("3. Encontrar los pares de numeros amigos en un rango.");
            Console.WriteLine("4. Salir.");
            opc = Int32.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    punto1();
                    Console.ReadKey();
                    break;
                case 2:
                    punto2();
                    Console.ReadKey();
                    break;
                case 3:
                    punto3();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Hasta Luego");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
    public static void punto1()
    {
        Console.Write("Ingrese n: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Ingrese m: ");
        int m = Int32.Parse(Console.ReadLine());
        int count = result(n);
        int count2 = result(m);
        Console.WriteLine(
            count == m && count2 == n ? "Son numeros amigos" : "No son numeros amigos"
        );
    }
    public static void punto2()
    {
        for (int i = 1000; i <= 1249; i++)
        {
            int x = result(i);
            int y = result(x);
            if (y == i)
            {
                Console.WriteLine($"Los numeros {x} y {y} son amigos");
                break;
            }
        }
    }
    public static void punto3()
    {
        Console.Write("Ingrese el valor minimo del rango: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor maximo del rango: ");
        int m = Int32.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            int x = result(i);
            int y = result(x);
            if (y == i)
            {
                Console.WriteLine($"Los numeros {x} y {y} son amigos");
            }
        }
    }
    public static int result(int x)
    {
        int count = 0;
        for (int i = 1; i <= x / 2; i++)
        {
            if (x % i == 0)
                count += i;
        }
        return count;
    }
}
