// See https://aka.ms/new-console-template for more information
Console.WriteLine("Promedio Notas");
Console.WriteLine(" ");


string alumno;
int nota1, nota2, nota3, promedio;

Console.WriteLine("ingrese nombre del alumnno");
alumno = Console.ReadLine();

Console.WriteLine("ingrese la nota 1: ");
nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese la nota 2: ");
nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese la nota 3: ");
nota3 = int.Parse(Console.ReadLine());

promedio = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("-----------------------------------");
Console.WriteLine("el promedio del alumno es: " + promedio.ToString("0.00"));
