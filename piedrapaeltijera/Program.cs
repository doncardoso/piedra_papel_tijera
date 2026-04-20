Console.WriteLine("Hello, World!");
System.Random random = new System.Random();


int puntosJugador = 0;
int puntosComputadora = 0;
int juegos = 0;
int empates = 0;
string switchControl = "menu";



List<(string nombre, int numero)> Opciones() { 
 return new List<(string nombre, int numero)>()
    {
        ("Piedra", 0),
        ("Papel", 1),
        ("Tijera", 2)
    };
}
while (true)
{

    
    switch (switchControl)
    {
        case "menu":
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------- :D ----BIENBENIDO AL JUEGO----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------AL MEJOR DE 3 --------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------JUEGA Y A CHINGAR A TU MADRE-----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------SI ES QUE PIERDES Y SI GANAS-----------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------AL CHINGARLA DE TODAS FORMAS--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------QUE HACE PERDIENDO EL TIEMPO!!!!!-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Quieres jugar? (si/no)");
            switchControl = Console.ReadLine()?.ToLower();

            if (switchControl == "si")
            {
                switchControl = "jugar";
            }
            break;


        case "jugar":
            Console.WriteLine("piedra = 0");
            Console.WriteLine("papel = 1");
            Console.WriteLine("tijera = 2");

            puntosComputadora = 0;
            puntosJugador = 0;

            for (int juego = 1; juego<=3; juego++)
             { 
                Console.WriteLine($"\n--------Juego#{juego}-----------");
                Console.WriteLine("Piedra , Papel o Tijera");
                Console.WriteLine("elige una");
                string eleccionJugador = Console.ReadLine()?.ToLower();

                var opciones = Opciones();
                var opcionJugador = opciones.FirstOrDefault(o => o.nombre.ToLower() == eleccionJugador);
                if (opcionJugador.nombre == null)
                {
                    Console.WriteLine("Esa opción no existe, ¡no seas pendejo!");
                    juego--;
                    continue;
                }

                int numeroJugador = opcionJugador.numero;

                var eleccionComputadora = random.Next(0, 3);
                string nombreComputadora = opciones[eleccionComputadora].nombre;

                Console.WriteLine($"elejiste {opcionJugador.nombre} y la computadora eligió {Opciones()[eleccionComputadora].nombre}");

                if (numeroJugador == eleccionComputadora)
                {
                    Console.WriteLine("Empate");
                    empates++;
                    juego--;
                    continue;
                }
                else if ((numeroJugador == 0 && eleccionComputadora == 2) ||
                         (numeroJugador == 1 && eleccionComputadora == 0) ||
                         (numeroJugador == 2 && eleccionComputadora == 1))
                {
                    Console.WriteLine("Ganaste esta ronda");
                    puntosJugador++;
                }
                else
                {
                    Console.WriteLine("Perdiste esta ronda");
                    puntosComputadora++;
                }

                if (puntosJugador == 2 || puntosComputadora == 2)
                {
                    Console.WriteLine("¡El mejor de 3 ha terminado!");
                    Console.WriteLine($"Resultados: Jugador {puntosJugador} - Computadora {puntosComputadora} - Empates {empates}");
                    break;
                }
                juegos++;

                

            }
            Console.WriteLine("\n=== RESULTADO FINAL ===");
            if (puntosJugador > puntosComputadora) Console.WriteLine("¡GANASTE EL MEJOR DE 3!");
            else if (puntosComputadora > puntosJugador) Console.WriteLine("PERDISTE, ¡A CHINGAR A SU MADRE!");
            else Console.WriteLine("EMPATE TÉCNICO");
            Console.WriteLine($"\n tu puntaje es {puntosJugador}");
            Console.WriteLine($"\n el puntaje de la pc es {puntosComputadora}");

            switchControl = "menu";
            break;



    }



}





