//Crear una funcion que calcule el promedio de una lista de numeros,
//recibiendo como parametro una lista de enteros 

Console.WriteLine("Porfavor ingrese una lista de numeros enteros separados por comas para calcular su promedio");
string input = Console.ReadLine();

var num = input.Split(',').Select(int.Parse);

double average = num.Average();

Console.WriteLine($"El promedio de los números ingresados es :  {average}");

Console.ReadKey();