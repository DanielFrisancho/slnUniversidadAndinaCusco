using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        //atributos
        private string nombreAlumno;
        private string apellidoAlumno;
        private string lugarPractica;
        //propiedades
        public string NombreAlumno
        {
            get { return nombreAlumno; }// Lectura de atributos
            set { nombreAlumno = value; }// Escritura de atributos
        }
        public string ApellidoAlumno
        {
            get { return apellidoAlumno; }
            set { apellidoAlumno = value; }
        }
        public string LugarPractica
        {
            get { return lugarPractica; }
            set { lugarPractica = value; }
        }

        //Metodos u operaciones
        public string Experimetar()
        {
            return "No se ha implementado el metodo experimentar";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo Aprender";
        }
        public string Trabajar()
        {
            return "No se ha implenmentado el metodo trabajar";
        }
    }
}
