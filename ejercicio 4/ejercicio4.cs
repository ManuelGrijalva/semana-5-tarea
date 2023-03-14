//Crear una funcion que determine si un numero es par o impar, 
//recibiendo como parametro el numero.


Console.WriteLine("ingresa un numero entero para determinar si es par o impar :) ");

int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"{numero} es un número par");


}
else
{
    Console.WriteLine($"{numero} es un número impar");
}

Console.ReadKey();




