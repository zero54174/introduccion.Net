// See https://aka.ms/new-console-template for more information
Console.WriteLine("Converciones de Medidas");
Console.WriteLine(" ");

double metros, centimetro, pulgadas, yardas, pies;

Console.WriteLine("digite la cantidad de metros de tela");
metros = double.Parse(Console.ReadLine());

centimetro = metros*100;

pulgadas = metros * 39.3701;

yardas = metros * 1.09361;

pies = metros * 3.28084;

Console.WriteLine("----------------------");
Console.WriteLine("centimetros: " + centimetro.ToString("0.00"));

Console.WriteLine("----------------------");
Console.WriteLine("pulgadas: " + pulgadas.ToString("0.00"));

Console.WriteLine("----------------------");
Console.WriteLine("yardas: " + yardas.ToString("0.00"));

Console.WriteLine("----------------------");
Console.WriteLine("pies: " + pies.ToString("0.00"));
