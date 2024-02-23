
for (int i = 0; i < 7; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    string present = @"
██████╗░██╗███████╗███╗░░██╗██╗░░░██╗███████╗███╗░░██╗██╗██████╗░░█████╗░░██████╗  ░█████╗░
██╔══██╗██║██╔════╝████╗░██║██║░░░██║██╔════╝████╗░██║██║██╔══██╗██╔══██╗██╔════╝  ██╔══██╗
██████╦╝██║█████╗░░██╔██╗██║╚██╗░██╔╝█████╗░░██╔██╗██║██║██║░░██║██║░░██║╚█████╗░  ███████║
██╔══██╗██║██╔══╝░░██║╚████║░╚████╔╝░██╔══╝░░██║╚████║██║██║░░██║██║░░██║░╚═══██╗  ██╔══██║
██████╦╝██║███████╗██║░╚███║░░╚██╔╝░░███████╗██║░╚███║██║██████╔╝╚█████╔╝██████╔╝  ██║░░██║
╚═════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═╝╚═════╝░░╚════╝░╚═════╝░  ╚═╝░░╚═╝

██╗░░░░░░█████╗░  ██████╗░██╗░░░██╗██╗░░░░░███████╗████████╗░█████╗░  ██████╗░██╗░░░██╗░██████╗░█████╗░
██║░░░░░██╔══██╗  ██╔══██╗██║░░░██║██║░░░░░██╔════╝╚══██╔══╝██╔══██╗  ██╔══██╗██║░░░██║██╔════╝██╔══██╗
██║░░░░░███████║  ██████╔╝██║░░░██║██║░░░░░█████╗░░░░░██║░░░███████║  ██████╔╝██║░░░██║╚█████╗░███████║
██║░░░░░██╔══██║  ██╔══██╗██║░░░██║██║░░░░░██╔══╝░░░░░██║░░░██╔══██║  ██╔══██╗██║░░░██║░╚═══██╗██╔══██║
███████╗██║░░██║  ██║░░██║╚██████╔╝███████╗███████╗░░░██║░░░██║░░██║  ██║░░██║╚██████╔╝██████╔╝██║░░██║
╚══════╝╚═╝░░╚═╝  ╚═╝░░╚═╝░╚═════╝░╚══════╝╚══════╝░░░╚═╝░░░╚═╝░░╚═╝  ╚═╝░░╚═╝░╚═════╝░╚═════╝░╚═╝░░╚═╝";

    Console.WriteLine(present.PadLeft((Console.WindowWidth + present.Length) / 2));
    Thread.Sleep(600);
    //Console.ResetColor();
    Console.Clear();
}

string[] nombres ={"Aarón Gabriel", "Carmona Tavárez", "Adrian Lorenzo Torres",
"Alex Gabriel Kroumov Krumova", "Andriws Castillo Concepcin", "Angel Gabriel Morillo Rosario",
"Delio Lorenzo Rodriguez Lopez", "Eddy Gabriel Custodio Hernandez", "Erick Octavio Rivera Arias",
"Estarlin De La Cruz Acevedo", "Gredd Oslwald Rodriguez Polanco", "Heber Jr Encarnacion Mendez",
"Jayner Alejandro Diaz Peralta", "Jhon Michael Sierra Rodríguez", "Jordys Valenzuela Perez",
"Jorge Luis Muñis Coca", "Josué Ismael Blanco Sánchez", "Leyshi Yoelina Beras",
"Luis David Bueno St Fleur", "Max Anderson Linares Jaquez", "Maxwell Ivan Alcántara Hernández",
"Mayerlin Alcantara Valera", "Melvin Emmanuel Marte Cuevas", "Oliver Ernesto Tejeda Marte",
"Paula Mariel Henrsez Cruz", "Ramon Emil Estrella Romero", "Rolando Ma?On Henr?Quez",
"Sander Rafael Fernandez Tolentino", "Xavier Casilla", "Xavier Duverge Montero"};

Random aleatorio = new Random();
string[] desarollador = new string[nombres.Length];
string[] facilitador = new string[nombres.Length];

int posicion = 0;
int iterador = 1;
int terminar = 1;
do
{
    //--------------------------------------------------------------------------------------------------
    //FUNCIONES 
    string buscarDev()
    {
    inicio:
        int indice1 = aleatorio.Next(nombres.Length);
        string nomb = nombres[indice1];
        for (int i = 0; i < nombres.Length; i++)
        {
            //System.Console.WriteLine($"Corrida: {i}");
            if (desarollador[i] == nomb)
            {
                goto inicio;
            }
        }
        return nomb;
    }

    string buscarFac()
    {
    inicio:
        int indice2 = aleatorio.Next(nombres.Length);
        string nomb = nombres[indice2];
        for (int i = 0; i < nombres.Length; i++)
        {
            //System.Console.WriteLine($"Corrida: {i}");
            if (facilitador[i] == nomb)
            {
                goto inicio;
            }
        }
        return nomb;
    }
//------------------------------------------------------------------------------------------------------
//======================================================================================================
//LLAMANDO LAS FUNCIONES Y MOSTRANDO SUS RESULTADOS.
volverAllamar:
    string nomb = buscarDev();
    string nomb1 = buscarFac();

    if (nomb == nomb1)
    {
        goto volverAllamar;
    }
    else
    {

        System.Console.WriteLine($"RONDA: {iterador}");
        Thread.Sleep(2000);

        Console.Clear();
        for (int i = 0; i < 5; i++)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine(@"
██╗░░░██╗  ██╗░░░░░░█████╗░░██████╗
╚██╗░██╔╝  ██║░░░░░██╔══██╗██╔════╝
░╚████╔╝░  ██║░░░░░██║░░██║╚█████╗░
░░╚██╔╝░░  ██║░░░░░██║░░██║░╚═══██╗
░░░██║░░░  ███████╗╚█████╔╝██████╔╝
░░░╚═╝░░░  ╚══════╝░╚════╝░╚═════╝░

░█████╗░░██████╗░██████╗░░█████╗░░█████╗░██╗░█████╗░██████╗░░█████╗░░██████╗
██╔══██╗██╔════╝░██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗██╔══██╗██╔══██╗██╔════╝
███████║██║░░██╗░██████╔╝███████║██║░░╚═╝██║███████║██║░░██║██║░░██║╚█████╗░
██╔══██║██║░░╚██╗██╔══██╗██╔══██║██║░░██╗██║██╔══██║██║░░██║██║░░██║░╚═══██╗
██║░░██║╚██████╔╝██║░░██║██║░░██║╚█████╔╝██║██║░░██║██████╔╝╚█████╔╝██████╔╝
╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═════╝░

░██████╗░█████╗░███╗░░██╗░░░░░░░░░
██╔════╝██╔══██╗████╗░██║░░░░░░░░░
╚█████╗░██║░░██║██╔██╗██║░░░░░░░░░
░╚═══██╗██║░░██║██║╚████║░░░░░░░░░
██████╔╝╚█████╔╝██║░╚███║██╗██╗██╗
╚═════╝░░╚════╝░╚═╝░░╚══╝╚═╝╚═╝╚═╝");
            Thread.Sleep(900);
            Console.Clear();

        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine($"EL DESARROLLADOR ES: {nomb}");
        System.Console.WriteLine($"EL FACILITADOR ES: {nomb1}\n");
        Console.ResetColor();


        desarollador[posicion] = nomb;
        facilitador[posicion] = nomb1;
        posicion++;
    }

//----------------------------------------------------------------------------------------------------
//CERRANDO EL PROGRAMA
    //Console.ReadKey();
    iterador++;
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    System.Console.WriteLine("PARA CONTINUAR CON LA RULETA PRESIONE 1, PARA FINALIZAR PRESIONA 0.");
    terminar = int.Parse(Console.ReadLine()!);
    if (terminar == 0)
    {
        for (int i = 0; i < 6; i++)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("CERRANDO...");
            System.Console.WriteLine(@"
─────────────────────────────▄██▄
─────────────────────────────▀███
────────────────────────────────█
───────────────▄▄▄▄▄────────────█
──────────────▀▄────▀▄──────────█
──────────▄▀▀▀▄─█▄▄▄▄█▄▄─▄▀▀▀▄──█
─────────█──▄──█────────█───▄─█─█
─────────▀▄───▄▀────────▀▄───▄▀─█
──────────█▀▀▀────────────▀▀▀─█─█
──────────█───────────────────█─█
▄▀▄▄▀▄────█──▄█▀█▀█▀█▀█▀█▄────█─█
█▒▒▒▒█────█──█████████████▄───█─█
█▒▒▒▒█────█──██████████████▄──█─█
█▒▒▒▒█────█───██████████████▄─█─█
█▒▒▒▒█────█────██████████████─█─█
█▒▒▒▒█────█───██████████████▀─█─█
█▒▒▒▒█───██───██████████████──█─█
▀████▀──██▀█──█████████████▀──█▄█
──██───██──▀█──█▄█▄█▄█▄█▄█▀──▄█▀
──██──██────▀█─────────────▄▀▓█
──██─██──────▀█▀▄▄▄▄▄▄▄▄▄▀▀▓▓▓█
──████────────█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
──███─────────█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
──██──────────█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
──██──────────█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
──██─────────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
──██────────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
──██───────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌
──██──────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌
──██─────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌
──██────▐█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▌
");
            Thread.Sleep(400);
            Console.Clear();
            Console.ResetColor();

        }
    }

} while (terminar != 0);