// See https://aka.ms/new-console-template for more information
Console.WriteLine("capital de la empresa");
Console.WriteLine(" ");

double aporte1, aporte2, aporte3, capital, socio1, socio2, socio3;

Console.WriteLine("digite el aporte del primer socio: ");
aporte1 = double.Parse(Console.ReadLine());

Console.WriteLine("digite el aporte del segundo socio: ");
aporte2 = double.Parse(Console.ReadLine());

Console.WriteLine("digite el aporte del tercer socio: ");
aporte3 = double.Parse(Console.ReadLine());

capital= aporte1 + aporte2 + aporte3;

socio1 = (aporte1 * 100) / capital;
socio2 = (aporte2 * 100) / capital;
socio3 = (aporte3 * 100) / capital;

Console.WriteLine("----------------------");
Console.WriteLine("capital: " + capital.ToString("0.00"));

Console.WriteLine("----------------------");
Console.WriteLine("socio1: " + socio1.ToString("0.00"));

Console.WriteLine("----------------------");
Console.WriteLine("socio2: " + socio2.ToString("0.00"));

Console.WriteLine("----------------------");
Console.WriteLine("socio3: " + socio3.ToString("0.00"));

