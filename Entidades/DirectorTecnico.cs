using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }


        public int AñosExperiencia { get => añosExperiencia; set => añosExperiencia = value; }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine($"{this.añosExperiencia} años de experiencia");
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            if(this.Edad >= 65 && this.añosExperiencia <= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
