string resp, resp2;
do {
    int num1 = 0, num2 = 0;
    Console.WriteLine("Ingrese dos numero enteros");
    Console.Write("Primer valor: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Segundo valor: ");
    num2 = int.Parse(Console.ReadLine());
    do
    {
        Console.Write("Desea realizar una suma o una resta (SUMA - RESTA): ");
        resp = Console.ReadLine().ToUpper();
    } while (resp != "SUMA" && resp != "RESTA");
    switch (resp)
    {
        case "SUMA":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La suma de ambos valores es de: {num1 + num2}");
            Console.ForegroundColor= ConsoleColor.White;
            break;
        case "RESTA":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"La resta de ambos numero es de: {num1 - num2}");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }
    Console.WriteLine("Desea volver a realizar la operacion? \n/Presiona S para continuar \n/Presiona cualquier letra para finalizar");
    resp2 = Console.ReadLine().ToUpper();
} while (resp2=="S");
