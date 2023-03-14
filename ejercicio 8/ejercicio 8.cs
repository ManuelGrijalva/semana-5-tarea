//Crear una funcion que calcule el factrorial de un numero, 
//recibiendo como parametro el nuemero.

int factorial = 1;

Console.WriteLine("Ingrese el numero que dese calcular su factorial");
int numero = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= numero; i++)
{
    factorial = factorial * i;

}
Console.WriteLine("El factorial del numero que ingreso es :" + factorial);

Console.ReadLine();

