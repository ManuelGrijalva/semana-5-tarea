//Crear una funcion que convierta una cadena a mayusculas,
//recibiendo commo parametro la cadena.


 Console.WriteLine("Ingrese una cadena de texto que desee convertir a mayuscula :");

 string input = Console.ReadLine();

 string upperCase = input.ToUpper();

 Console.WriteLine($"Su cadena en  mayúsculas es: {upperCase}");

Console.ReadKey();
