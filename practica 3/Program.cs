char opcion;
double y = 0, x = 0;
do {
    Console.Write("Escoja la opcion: (A-B-C-D):");
    opcion = char.Parse(Console.ReadLine().ToUpper());
    if (opcion == 'A' || opcion == 'B' || opcion == 'C' || opcion == 'D')
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR , ingrese de nuevo la opcion ");
        Console.ForegroundColor= ConsoleColor.White;
    }
} while (true);
Console.Write("Ingrese un valor para X: ");
x = double.Parse(Console.ReadLine());
switch (opcion)
{
    case 'A':
        y = (3 * (Math.Pow(x, 3)) - (Math.Pow(x, 0.333333)) + 4 * (Math.Pow(x, 2)));
        break;
    case 'B':
        y = (4 * (Math.Pow(x, 3))) - (3 * (Math.Pow(x, 2))) + (2 * x) - 5;
        break;
    case 'C':
        y =5*(Math.Pow(x,0.33333))+(4*(Math.Sqrt(x)))+6;
        break;
    case 'D':
        y= (8 * Math.Pow(x, 0.6)) - (3 * Math.Pow(x, 3)) + 6 * (Math.Pow(x, 2)) - 7;
        break;
}
Console.WriteLine(Math.Round(y,2));
