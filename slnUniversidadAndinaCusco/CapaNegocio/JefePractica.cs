using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //Atributos
        private string nombres;
        private string apellidos;
        private int dni;
        //Propiedades
        public string Nombres
        {
            get { return nombres; } //Lectura del atributo 
            set { nombres = value; } //Escritura del atributo 
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        //Metodos u Operaciones 
        public string Supervisar()
        {
            return "No se ha implementado el metodo supervisar";
        }
        public string Enseñar()
        {
            return "No se ha implementado el metodo enseñar";
        }
        public string Corregir()
        {
            return "No se ha implementado el metodo aprobar corregir";
        }
    }
}
