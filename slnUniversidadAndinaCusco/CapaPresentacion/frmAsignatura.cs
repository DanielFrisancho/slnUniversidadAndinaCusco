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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        // Instanciar la clase a travez de un objeto
        // En esta parte se declara variables globales
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string nombres = txtNombres.Text;
            int creditos = int.Parse(txtCreditos.Text);
            int notaAprobar = int.Parse(txtNotaAprobar.Text);
            asignatura1.Nombres = nombres;
            asignatura1.Creditos = creditos;
            asignatura1.NotaAprobar = notaAprobar;
            MessageBox.Show("se ha registrado correctamente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string nombres = txtNombres.Text;
            int creditos = int.Parse(txtCreditos.Text);
            int notaAprobar = int.Parse(txtNotaAprobar.Text);
            MessageBox.Show(" Nombres: " + nombres + " Creditos: " + creditos + " Nota para Aprobar: " + notaAprobar);

        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Estudiar
            MessageBox.Show(asignatura1.Estudiar());
        }

        private void btnParticipar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Participar
            MessageBox.Show(asignatura1.Participar());
        }

        private void btnPreguntar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Preguntar
            MessageBox.Show(asignatura1.Preguntar());
        }
    }
}
