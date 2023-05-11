using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED.Estructura
{
    internal class clsPila
    {
        public clsNodo Primero;

        
        
        
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)//Si primero es nulo, en caso le asigna el valor ingresado
                                
            {
                Primero = Nuevo;
            }
            else//aca hacemos que el nuevo tome el valor del primero 
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }

        
        
        

        public void Eliminar()
        {
            if (Primero != null)//Si primero es diferente de nulo lo apaga
                                
            {
                Primero = Primero.Siguiente;
            }
        }

        

        public void Recorrer(DataGridView dgvGrilla)
        {
            clsNodo Aux = Primero;//para definir el primero
            dgvGrilla.Rows.Clear();//Limpiar la grilla


            while (Aux != null)
            {
                dgvGrilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ListBox lstListado)
        {
            clsNodo Aux = Primero;//definir el primero
            lstListado.Items.Clear();//Limpiar la lista 
            while (Aux != null)
            {
                lstListado.Items.Add(Aux.Codigo + " , " + Aux.Nombre + " , " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;// definir el primero
            Combo.Items.Clear();//Limpiar el combo

            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
    }
}
