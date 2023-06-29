using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ED.Estructura
{
    internal class clsNodo
    {
        
        private Int32 Codi;
        private string Nom;
        private string Tra;
        private clsNodo sig;
        private clsNodo Ant;

        //propiedades estrutura 
        public Int32 Codigo
        {
            get { return Codi; }
            set { Codi = value; }
        }

        public string Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string Tramite
        {
            get { return Tra; }
            set { Tra = value; }
        }

        public clsNodo Anterior
        {
            get { return Ant; }
            set { Ant = value; }
        }

        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Izquierda
        {
            get { return Ant; }
            set { Ant = value; }
        }

        public clsNodo Derecha
        {
            get { return sig; }
            set { sig = value; }
        }

    }
}
