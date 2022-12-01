using System;
using Entidades;


namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Genero un equipo nuevo
            Equipo equipo = new Equipo(" UTN ");
            // Genero un Director Técnico y lo asigno al equipo
            DirectorTecnico dt = new DirectorTecnico(" Lionel ", " Scaloni ", 60, 8332112, 10);
            DirectorTecnico dtInvalido = new DirectorTecnico(" Pablo ", " Aimar ", 90, 6332112, 1);
            equipo.DirectorTecnico = dtInvalido;
            // Genero Jugadores
            Jugador j1 = new Jugador(" Emiliano ", " Martínez ", 28, 33222456, 70.5f, 1.82f, ePosicion.Arquero);
            Jugador j2 = new Jugador(" Nicolas ", " Otamendi ", 28, 33222456, 72f, 1.70f,
ePosicion.Defensor);
            Jugador j3 = new Jugador(" Lionel ", " Messi ", 31, 31333444, 73.5f, 1.90f,
ePosicion.Delantero);
            Jugador j4 = new Jugador(" Maxi ", " Rodríguez ", 32, 30443332, 75.5f, 1.75f,
ePosicion.Central);
            Jugador j5 = new Jugador(" Papi ", " Gomez ", 26, 36555443, 99.5f, 1.73f,
ePosicion.Delantero);
            Jugador j6 = new Jugador(" Angel ", " Di maria", 50, 37456678, 86.5f, 1.94f,
ePosicion.Delantero);
            Jugador j7 = new Jugador(" Cuti ", " Romero ", 26, 36555443, 66.5f, 1.73f, ePosicion.Defensor);

            Jugador j8 = new Jugador(" Lautaro ", " Martinez ", 25, 37456678, 86.5f, 1.94f,
ePosicion.Delantero);
            // Agrego los jugadores al equipo
            equipo = equipo + j1;
            equipo = equipo + j2;
            equipo = equipo + j3;
            Console.WriteLine(" *******************************EQUIPO INVÁLIDO * ******************************");
            // Imprimo los datos del equipo
            Console.WriteLine((string)equipo);
            if (Equipo.ValidarEquipo(equipo))
                Console.WriteLine(" El equipo es válido");
else
                Console.WriteLine(" El equipo no es válido ");
            equipo.DirectorTecnico = dt;
            equipo = equipo + j4;
            equipo = equipo + j5;
            equipo = equipo + j6;
            equipo = equipo + j7;
            equipo = equipo + j8;
            Console.WriteLine(" *******************************EQUIPO VÁLIDO * ********************************");
            // Imprimo los datos del equipo
            Console.WriteLine((string)equipo);
            if (Equipo.ValidarEquipo(equipo))
                Console.WriteLine(" El equipo es válido");
else
                Console.WriteLine(" El equipo no es válido ");
            Console.ReadKey();
        }
    }
}
