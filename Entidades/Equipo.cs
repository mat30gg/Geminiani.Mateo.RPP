using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{e.nombre}");
            sb.AppendLine(e.directorTecnico is not null ? e.directorTecnico.Mostrar() : "Sin DT asignado");
            foreach(Jugador jugador in e.jugadores)
            {
                sb.AppendLine(jugador.Mostrar());
            }
            return sb.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            //return (e.jugadores.Contains<Jugador>(j)) ;
            foreach(Jugador jugador in e.jugadores)
            {
                if (jugador.Equals(j))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }


        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e != j)
            {
                if (e.jugadores.Count < Equipo.cantidadMaximaJugadores)
                {
                    if(j.ValidarAptitud())
                    {
                        e.jugadores.Add(j);
                    }
                }
            }
            return e;
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }
        public string Nombre { get => nombre; }

        public static bool ValidarEquipo(Equipo e)
        {
            bool existeArquero = false;
            bool noContienePosicion;
            bool valido = false;
            if(e.directorTecnico is not null && e.jugadores.Count == Equipo.cantidadMaximaJugadores)
            {
                for(int x = 0; x < 4; x++)
                {
                    noContienePosicion = true;
                    foreach(Jugador jugador in e.jugadores)
                    {
                        if(jugador.Posicion == (ePosicion)x)
                        {
                            if(ePosicion.Arquero == (ePosicion)x)
                            {
                                if(existeArquero)
                                {
                                    break;
                                }
                                existeArquero = true;
                            }
                            noContienePosicion = false;
                        }
                    }
                    if(noContienePosicion)
                    {
                        break;
                    }
                }
            }
            return valido;
        }
    }
}
