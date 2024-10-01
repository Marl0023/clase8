Console.Write("Ingrese su texto : ");
string texto = Console.ReadLine();
char[] charArray = texto.ToCharArray();
Array.Reverse(charArray);
string  texto2 = new string(charArray);
Console.WriteLine($"El texto invertido es: {texto2}");