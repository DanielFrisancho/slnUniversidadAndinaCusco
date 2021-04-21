using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        // atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
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
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { lugarNacimiento = value; }
        }
        //operaciones
        public string Estudiar()
        {
            return "no se ha implementado"; 
        }
        public string Trabajar()
        {
            return "no se ha implementado";
        }
        public string AprobarExamen()
        {
            return "no se ha implementado";
        }
        public string PresentarTarea()
        {
            return "no se ha implementado";
        }
    }
}
