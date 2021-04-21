using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //atributos
        private string nombres;
        private string ubicacion;
        private int creditos;
        private string requerimientos;
        //propiedades
        public string Nombres 
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Ubicacion 
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public int Creditos 
        {
            get { return creditos; }
            set { creditos = value; }
        }
        public string Requerimientos 
        {
            get { return requerimientos; }
            set { requerimientos = value; }
        }
        //operaciones
        public string Experimentar() 
        {
            return "no se ha implementado";
        }
        public string Ensamblar() 
        {
            return "no se ha implementado";
        }
        public string Cortar() 
        {
            return "no se ha implementado";
        }
    }
}
