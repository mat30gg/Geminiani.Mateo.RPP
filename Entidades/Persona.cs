using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        int edad;
        int dni;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int Edad { get => edad; }
        public int Dni { get => dni; }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Edad {this.edad}");
            sb.AppendLine($"DNI {this.dni}");
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
