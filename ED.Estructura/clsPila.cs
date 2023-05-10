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
            if (Primero == null)//Verifica si primero es nulo, en caso 
                                //de serlo, le asigna el valor ingresado
            {
                Primero = Nuevo;
            }
            else//Si ya existe un valor, hacemos que Nuevo.Siguiente tome el valor
                //de primero, y primero tome el valor ingresado
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }

        
        
        

        public void Eliminar()
        {
            if (Primero != null)//Verifica que primero sea diferente de nulo
                                //y lo borra
            {
                Primero = Primero.Siguiente;//Primero toma el valor del siguiente
                                            //es decir primero.siguiente
            }
        }

        

        public void Recorrer(DataGridView dgvGrilla)
        {
            clsNodo Aux = Primero;//Utilizo un puntero para definir el primero
            dgvGrilla.Rows.Clear();//Limpiamos las columnas

            while (Aux != null)
            {
                dgvGrilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ListBox lstListado)
        {
            clsNodo Aux = Primero;//Utilizo un puntero para definir el primero
            lstListado.Items.Clear();//Limpiamos los items del list
            while (Aux != null)
            {
                lstListado.Items.Add(Aux.Codigo + " , " + Aux.Nombre + " , " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;//Utilizo un puntero para definir el primero
            Combo.Items.Clear();//Limpiamos los items del combo

            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
    }
}
