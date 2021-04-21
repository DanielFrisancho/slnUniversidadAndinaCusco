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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        // Instanciar la clase a travez de un objeto
        // En esta parte se declara variables globales
        CapaNegocio.Docente Docente1 = new CapaNegocio.Docente();

        private void frmDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int Dni = int.Parse(txtDni.Text);
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            string profesion = txtProfesion.Text;
            Docente1.Apellidos = apellidos;
            Docente1.Nombres = nombres;
            Docente1.Dni = Dni;
            Docente1.FechaNacimiento = fechaNacimiento;
            Docente1.Profesion = profesion;
            MessageBox.Show("se ha registrado correctamente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string apellidos = Docente1.Apellidos;
            string nombres = Docente1.Nombres;
            DateTime fechaNacimiento = Docente1.FechaNacimiento;
            string profesion = Docente1.Profesion;
            MessageBox.Show(" Apellidos: " + apellidos + " Nombres: " + nombres + " FechaNacimiento: " + fechaNacimiento + " Profesion: " + profesion );
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Enseñar
            MessageBox.Show(Docente1.Enseñar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Aprobar
            MessageBox.Show(Docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Desaprobar
            MessageBox.Show(Docente1.Desaprobar());
        }
    }
}
