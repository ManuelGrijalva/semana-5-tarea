//crear una funcion que calcule la suma de los primeros n numeros naturales, 
//recibiendo como parametro el numero n. 

    static int SumaNaturales(int n)
    {
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }
        return suma;
    }

        Console.WriteLine("Ingrese un número entero:");
        int numero = int.Parse(Console.ReadLine());

        int resultado = SumaNaturales(numero);

        Console.WriteLine($"La suma de los primeros {numero} números naturales es: {resultado}");

Console.ReadKey();
