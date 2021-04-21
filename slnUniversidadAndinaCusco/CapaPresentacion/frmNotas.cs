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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        // Instanciar la clase a travez de un objeto
        // En esta parte se declara variables globales
        CapaNegocio.Notas notas1 = new CapaNegocio.Notas();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos del formulario
            string curso = txtCurso.Text;
            string aporte = txtAporte.Text;
            string semestre = txtSemestre.Text;
            notas1.Curso = curso;
            notas1.Aporte = aporte;
            notas1.Semestre = semestre;
            MessageBox.Show("se ha registrado correctamente");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Mostrar los datos almacenados en el objeto 1
            string curso = txtCurso.Text;
            string aporte = txtAporte.Text;
            string semestre = txtSemestre.Text;
            MessageBox.Show(" Curso: " + curso + " Aporte: " + aporte + " Semestre: " + semestre);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Aprobar
            MessageBox.Show(notas1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            // Mostrar el metodo u operacion Desaprobar
            MessageBox.Show(notas1.Desaprobar());
        }
    }
}
