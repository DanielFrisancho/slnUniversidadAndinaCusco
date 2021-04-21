using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class fmrRector : Form
    {
        public fmrRector()
        {
            InitializeComponent();
        }
        // Instanciar la clase a travez de un objeto
        // En esta parte se declara variables globales
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string lugarNacimiento = txtLugarNacimiento.Text;
            rector1.Nombres = nombres;
            rector1.Apellidos = apellidos;
            rector1.Lugarnacimiento = lugarNacimiento;
            MessageBox.Show("se ha registrado correctamente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string lugarNacimiento = txtLugarNacimiento.Text;
            MessageBox.Show(" Nombres: " + nombres + " Apellidos: " + apellidos + " Lugar de Nacimiento: " + lugarNacimiento);
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Supervisar
            MessageBox.Show(rector1.Supervisar());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Administrar
            MessageBox.Show(rector1.Administrar());
        }

        private void btnControlar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Administrar
            MessageBox.Show(rector1.Administrar());
        }
    }
}
