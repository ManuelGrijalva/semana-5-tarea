//crear una funcion que calcule la distancia entre dos puntos en un plano cartesiano,
//recibiendo como parametros las coordenadas x e y de anbos puntos. 


int x1, x2, y1, y2;

Console.WriteLine("ingrese el valor para x1: ");
x1 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el valor para x2: ");
x2 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el valor para y1: ");
y1 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el valor para y2: ");
y2 = int.Parse(Console.ReadLine());

    var distancia = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
    
Console.WriteLine("La distancia entre los puntos es : " + distancia);

Console.ReadKey();