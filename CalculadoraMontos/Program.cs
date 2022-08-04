// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora de Montos");
Console.WriteLine(" ");


int cantidad;

double precio, monto;

Console.WriteLine("Ingrese La cantidad Seleccionada: ");
cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese El Precio Del Producto C$: ");
precio = double.Parse(Console.ReadLine());

monto = cantidad * precio;

Console.WriteLine("----------------------");
Console.WriteLine("Monto a Cancelar C$: " + monto.ToString("0.00"));

