using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED.Estructura
{
    internal class clsListaSimple
    {

        public clsNodo Primero;

       
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)//Verifica si primero es nulo, en caso 
                                //de serlo, le asigna el valor ingresado
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)//Si el valor nuevo es menor que el primero
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;//Puntero Guia
                    clsNodo Ant = Primero;//Toma el valor anterior del puntero AUX

                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        Ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }

                    Ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }
            }
        }

        

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo aux = Primero;//Puntero Guia
                clsNodo Ant = Primero;//Toma el valor anterior del puntero AUX

                while (aux.Codigo != Codigo)
                {
                    Ant = aux;
                    aux = aux.Siguiente;

                    if (aux == null)
                    {
                        break;
                    }
                }

                Ant.Siguiente = aux.Siguiente;
            }
        }


        public void Recorrer(DataGridView dgvGrilla)
        {
            clsNodo Aux = Primero;
            dgvGrilla.Rows.Clear();

            while (Aux != null)
            {
                dgvGrilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lstListado)
        {
            clsNodo Aux = Primero;
            lstListado.Items.Clear();
            while (Aux != null)
            {
                lstListado.Items.Add(Aux.Codigo + " , " + Aux.Nombre + " , " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox lstCodigo)
        {
            clsNodo Aux = Primero;
            lstCodigo.Items.Clear();
            while (Aux != null)
            {
                lstCodigo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }
        }
    }
}
