char rONP ;
double ISSS = 0, AFP = 0, ONP = 0 ,renta=0;
Console.Write("Ingrese su salario: ");
double salario = double.Parse(Console.ReadLine());
while (salario <= 0) { 
    Console.Write("ERRROR, ingrese un valor postivo,intentelo de nuevo: ");
    salario = double.Parse(Console.ReadLine());
}
if (salario <= 3000)
{
    ISSS = salario * 0.09;
    do
    {
        Console.WriteLine("Se encuentra afiliado a la ONP? (Y/N):");
        rONP = char.Parse(Console.ReadLine().ToUpper());
    } while (rONP != 'Y' && rONP != 'N');
    if (rONP == 'N')
    {
        AFP = salario * 0.07;
    }
    else
        ONP = salario * 0.08;
    renta = salario * 0.1;
}
else {
    ISSS = salario * 0.11;
    do
    {
        Console.WriteLine("Se encuentra afiliado a la ONP? (Y/N):");
        rONP = char.Parse(Console.ReadLine().ToUpper());
    } while (rONP != 'Y' && rONP != 'N');
    if (rONP == 'N')
    {
        AFP = salario * 0.09;
    }
    else
        ONP = salario * 0.10;
    renta = salario * 0.12;

}
Console.WriteLine($"Su salario neto es de: {salario - ISSS - AFP - ONP - renta}");