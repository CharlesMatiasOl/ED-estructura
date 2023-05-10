using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ED.Estructura
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }


        clsCola Cola = new clsCola();


        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Nodo = new clsNodo();
            Nodo.Codigo = Convert.ToInt32(txtCodigoN.Text);
            Nodo.Nombre = txtNombreN.Text;
            Nodo.Tramite = txtTramiteN.Text;

            Cola.Agregar(Nodo);
            Cola.Recorrer(dgvCola);
            Cola.Recorrer(lstListaCola);

            txtCodigoN.Text = "";
            txtNombreN.Text = "";
            txtTramiteN.Text = "";

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (Cola.Primero != null)
            {

                lblCodigoEE.Text = Cola.Primero.Codigo.ToString();
                lblNombreEE.Text = Cola.Primero.Nombre;
                lblTramiteEE.Text = Cola.Primero.Tramite;

                Cola.Eliminar();
                Cola.Recorrer(dgvCola);
                Cola.Recorrer(lstListaCola);
            }
            else
            {
                lblCodigoEE.Text = "";
                lblNombreEE.Text = "";
                lblTramiteEE.Text = "";

            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
