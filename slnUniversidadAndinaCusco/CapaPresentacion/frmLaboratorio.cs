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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        // Instanciar la clase a travez de un objeto
        // En esta parte se declara variables globales
        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string nombres = txtNombres.Text;
            string ubicacion = txtUbicacion.Text;
            int creditos = int.Parse(txtCreditos.Text);
            string requerimientos = txtRequerimientos.Text;
            laboratorio1.Nombres = nombres;
            laboratorio1.Ubicacion = ubicacion;
            laboratorio1.Creditos = creditos;
            laboratorio1.Requerimientos = requerimientos;
            MessageBox.Show("se ha registrado correctamente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string nombres = txtNombres.Text;
            string ubicacion = txtUbicacion.Text;
            int creditos = int.Parse(txtCreditos.Text);
            string requerimientos = txtRequerimientos.Text;
            MessageBox.Show(" Nombres: " + nombres + " Ubicacion: " + ubicacion + " Creditos: " + creditos + " Requerimientos: " + requerimientos);
        }

        private void btnExperimentar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Experimentar
            MessageBox.Show(laboratorio1.Experimentar());
        }

        private void btnEnsamblar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Ensamblar
            MessageBox.Show(laboratorio1.Ensamblar());
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Cortar
            MessageBox.Show(laboratorio1.Cortar());
        }
    }
}
