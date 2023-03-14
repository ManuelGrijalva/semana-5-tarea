//Crear una función que calcule el perímetro de un rectángulo,
//recibiendo como parámetros el ancho y la altura.


int  ancho, alto;

Console.WriteLine("Vamos a calcular el perimetro de un rectangulo :)");

Console.WriteLine("Ingresa el ancho del rectangulo por favor.");
ancho = int.Parse(Console.ReadLine());

Console.WriteLine("Ahora ingresa alto del rectangulo, por favor.");
alto = int.Parse(Console.ReadLine());


Console.WriteLine("El resultado del perímetro es: " + (ancho+alto));

Console.ReadKey();





