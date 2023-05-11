using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED.Estructura
{
    internal class clsCola
    {
        public clsNodo Primero;
        public clsNodo Ultimo;

        public void Agregar(clsNodo Nuevo) // en cola se borra el primero en entrar

        {
            if (Primero == null) //si primero es nulo los dos quedan con el mismo valor ingresado 
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;//El ultimo.siguiente toma el valor de nuevo y el ultimo toma el valor nuevo 
                Ultimo = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == Ultimo) //si primero es igual a ultimo lo dos quedan con valor nulo
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;//primero toma el valor del numero eliminado
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;//definimos el primero 
            Grilla.Rows.Clear();//limpiamos 
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
    }
}
