using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        //Atributos
        private string curso;
        private string aporte;
        private string semestre;
        //Propiedades
        public string Curso
        {
            get { return curso; } //Lectura del atributo 
            set { curso = value; } //Escritura del atributo 
        }
        public string Aporte
        {
            get { return aporte; }
            set { aporte = value; }
        }
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        //Metodos u Operaciones 
        public string Aprobar()
        {
            return "No se ha implementado el metodo Aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo desaprobar";
        }
    }
}
