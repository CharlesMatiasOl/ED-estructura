using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble ListaDoble = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {        
         
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigoN.Text);
            objNodo.Nombre = txtNombreN.Text;
            objNodo.Tramite = txtTramiteN.Text;

            ListaDoble.Agregar(objNodo);
            ListaDoble.Recorrer(dgvListaDoble);
            ListaDoble.Recorrer(lstListaDoble);
            ListaDoble.Recorrer(lstCodigo);

            txtCodigoN.Text = "";
            txtNombreN.Text = "";
            txtTramiteN.Text = "";

        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaDoble.Primero != null)
            {

                Int32 Codigo = Convert.ToInt32(lstCodigo.Text);

                ListaDoble.Eliminar(Codigo);
                ListaDoble.Recorrer(dgvListaDoble);
                ListaDoble.Recorrer(lstListaDoble);
                ListaDoble.Recorrer(lstCodigo);
            }
            else
            {
                txtCodigoN.Text = "";
                txtNombreN.Text = "";
                txtTramiteN.Text = "";
                
            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.Recorrer(dgvListaDoble);
            ListaDoble.Recorrer(lstListaDoble);
            ListaDoble.Recorrer(lstCodigo);
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ListaDoble.RecorrerDes(dgvListaDoble);
            ListaDoble.RecorrerDes(lstListaDoble);
            ListaDoble.RecorrerDes(lstCodigo);
        }
    }
}
