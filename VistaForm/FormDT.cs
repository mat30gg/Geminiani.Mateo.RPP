using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;
        public FormDT()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = this.tbNombre.Text;
            string apellido = this.tbApellido.Text;
            int edad = (int)nudEdad.Value;
            int dni = (int)nudDni.Value;
            int experiencia = (int)nudXP.Value;

            dt = new DirectorTecnico(nombre, apellido, edad, dni, experiencia);

            MessageBox.Show("Se ha creado el DT!");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(this.dt is not null)
            {
                if(this.dt.ValidarAptitud())
                {
                    MessageBox.Show("El DT es apto");
                }
                else
                {
                    MessageBox.Show("El DT no es apto");
                }
            }
            else
            {
                MessageBox.Show("Aun no se ha creado el DT del formulario");
            }
        }
    }
}
