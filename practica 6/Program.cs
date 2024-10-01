Console.WriteLine("Bienvenido al juego de PIEDRA PAPEL O TIJERA");
Console.WriteLine("Ingrese un numero segun corresponda");
Console.WriteLine("1.Piedra \n2.Papel \n3.Tijeras");
int valorP =int.Parse(Console.ReadLine());
string opcionP="", opcionC="";
while (valorP > 3 || valorP < 1) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("El valor que ingreso no es valido, vuelva a intentarlo");
    Console.ForegroundColor= ConsoleColor.White;
    Console.WriteLine("Ingrese un numero segun corresponda");
    Console.WriteLine("1.Piedra \n2.Papel \n3.Tijeras");
    valorP = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Generando un valor, espera un momento... presiona cualquier tecla");
    Console.ReadKey();
}
Random rnd = new Random();
int ppt = rnd.Next(1, 4);
switch (valorP) { 
    case 1:
        opcionP = "Piedra";
        break;
    case 2:
        opcionP = "Papel";
        break;
    case 3:
        opcionP = "Tijeras";
        break;
}
switch (ppt)
{
    case 1:
        opcionC = "Piedra";
        break;
    case 2:
        opcionC = "Papel";
        break;
    case 3:
        opcionC = "Tijeras";
        break;
}
if (valorP == ppt)
{
    Console.WriteLine($"Empate, ambos seleccionamos {opcionC}");
}
else {
    if (valorP == 3) {
        if (ppt == 2) { 
            Console.Write("Ganaste!!");
        }else
            Console.Write("Perdiste!!");
    }
        
    if (valorP == 2) {

        if (ppt == 1) { 
            Console.Write("Ganaste!!");
        }else
            Console.Write("Perdiste!!");
    }
    if (valorP == 1) {
        if (ppt == 3) { 
            Console.Write("Ganaste!!");
        }else
            Console.Write("Perdiste");
    }

    Console.Write($",yo elegi {opcionC} y tu elegiste {opcionP}");
}