//Crear una función que calcule el área de un círculo, recibiendo como parámetro el radio.

double area = 0, radio = 0;

Console.WriteLine("Vamos a calcular el radio de un circulo :)");

Console.WriteLine("Porfavor ingresa el radio del circulo");

radio = Int32.Parse(Console.ReadLine());
area = radio * radio * 3.1415;
Console.WriteLine("El Area del Circulo es : " + area);

Console.ReadKey();

