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
    public partial class frmJefePracticas : Form
    {
        public frmJefePracticas()
        {
            InitializeComponent();
        }
        // Instanciar la clase a travez de un objeto
        // En esta parte se declara variables globales
        CapaNegocio.JefePractica jefePractica1 = new CapaNegocio.JefePractica();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int dni = int.Parse(txtDni.Text);
            jefePractica1.Nombres = nombres;
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Dni = dni;
            MessageBox.Show("se ha registrado correctamente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int dni = int.Parse(txtDni.Text);
            MessageBox.Show(" Nombres: " + nombres + " Apellidos: " + apellidos + " Dni: " + dni);
        }

        private void btnSupervisar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Supervisar
            MessageBox.Show(jefePractica1.Supervisar());
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Enseñar
            MessageBox.Show(jefePractica1.Enseñar());
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Corregir
            MessageBox.Show(jefePractica1.Corregir());
        }
    }
}
