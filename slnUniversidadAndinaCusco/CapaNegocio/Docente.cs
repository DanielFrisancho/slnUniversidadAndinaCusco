using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    { 
        // atributos
        private string apellidos;
        private string nombres;
        private int dni;
        private DateTime fechaNacimiento;
        private string profesion;
        // propiedades
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        //operaciones
        public string Enseñar()
        {
            return "no se ha implementado";
        }
        public string Aprobar()
        {
            return "no se ha implementado";
        }
        public string Desaprobar()
        {
            return "no se ha implementado";
        }
    }
}
