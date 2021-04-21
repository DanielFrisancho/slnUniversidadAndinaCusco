using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //atributos
        private string nombres;
        private int creditos;
        private int notaAprobar;
        //propiedades
        public string Nombres 
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Creditos 
        {
            get { return creditos; }
            set { creditos = value; }
        }
        public int NotaAprobar 
        {
            get { return notaAprobar; }
            set { notaAprobar = value; }
        }
        //operaciones
        public string Estudiar() 
        {
            return "no se ha implementado";
        }
        public string Participar() 
        {
            return "no se ha implementado";
        }
        public string Preguntar() 
        {
            return "no se ha implementado";
        }
    }
}
