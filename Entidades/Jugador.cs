using System;
using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        float altura;
        float peso;
        ePosicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, ePosicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public float Altura { get => altura; }
        public float Peso { get => peso; }
        public ePosicion Posicion { get => posicion; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine($"Peso {this.peso}kg");
            sb.AppendLine($"Altura {this.altura}m");
            sb.AppendLine($"Posicion: {this.Posicion}");
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            if(this.Edad <= 40 && this.ValidarEstadoFisico())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarEstadoFisico()
        {
            bool returnValue = false;
            double masaCorporal;
            masaCorporal = this.peso / (Math.Pow(this.altura, 2));
            if(masaCorporal > 18.5 && masaCorporal <= 25)
            {
                returnValue = true;
            }
            return returnValue;
        }
    }
}
