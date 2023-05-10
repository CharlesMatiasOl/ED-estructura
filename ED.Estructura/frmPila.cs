using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED.Estructura
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila Pila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();
            Nodo.Codigo = Convert.ToInt32(txtCodigoN.Text);
            Nodo.Nombre = txtNombreN.Text;
            Nodo.Tramite = txtTramiteN.Text;
            Pila.Agregar(Nodo);
            Pila.Recorrer(dgvPila);
            Pila.Recorrer(lstListaPila);

            txtCodigoN.Text = "";
            txtNombreN.Text = "";
            txtTramiteN.Text = "";


        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {

                lblCodigoEE.Text = Pila.Primero.Codigo.ToString();
                lblNombreEE.Text = Pila.Primero.Nombre;
                lblTramiteEE.Text = Pila.Primero.Tramite;

                Pila.Eliminar();
                Pila.Recorrer(dgvPila);
                Pila.Recorrer(lstListaPila);
            }
            else
            {
                lblCodigoEE.Text = "";
                lblNombreEE.Text = "";
                lblTramiteEE.Text = "";

            }


        }



    }
}
