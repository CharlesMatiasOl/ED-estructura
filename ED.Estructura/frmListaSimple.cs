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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple ListaSimple = new clsListaSimple();



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();
            Nodo.Codigo = Convert.ToInt32(txtCodigoN.Text);
            Nodo.Nombre = txtNombreN.Text;
            Nodo.Tramite = txtTramiteN.Text;

            ListaSimple.Agregar(Nodo);
            ListaSimple.Recorrer(dgvListaSimple);
            ListaSimple.Recorrer(lstListado);
            ListaSimple.Recorrer(lstCodigo);

            txtCodigoN.Text = "";
            txtNombreN.Text = "";
            txtTramiteN.Text = "";



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaSimple.Primero != null)
            {

                Int32 Codigo = Convert.ToInt32(lstCodigo.Text);

                ListaSimple.Eliminar(Codigo);
                ListaSimple.Recorrer(dgvListaSimple);
                ListaSimple.Recorrer(lstListado);
                ListaSimple.Recorrer(lstCodigo);
            }
            else
            {
                txtCodigoN.Text = "";
                txtNombreN.Text = "";
                txtTramiteN.Text = "";
                
            }
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
