using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED.Estructura
{
    public partial class frmArbol : Form
    {

        clsArbol Arbol = new clsArbol();
        public bool asc = true;
        public string recorrer;


        public frmArbol()
        {
            InitializeComponent();
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {
            optInOrden.Checked = true;
            optAscendente.Checked = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Arbol.Busqueda(Convert.ToInt32(txtCodigoN.Text)) == false)
            {
                clsNodo objNodo = new clsNodo();

                objNodo.Codigo = Convert.ToInt32(txtCodigoN.Text);
                objNodo.Nombre = txtNombreN.Text;
                objNodo.Tramite = txtTramiteN.Text;
                StreamWriter Sw = new StreamWriter("./Reporte.csv", true);

                Arbol.Agregar(objNodo);


                if (optInOrden.Checked)
                {
                    Arbol.Recorrer(dgGrillaArbol);
                    Arbol.Recorrer(lstListarArbol);
                    Arbol.Recorrer(lstCodigo);
                    Arbol.Recorrer(PTArbol);
                    Arbol.RecorrerSW(Sw);
                    txtCodigoN.Focus();

                }
                if (optAscendente.Checked)
                {
                    Arbol.Recorrer(lstListarArbol);
                    Arbol.Recorrer(dgGrillaArbol);
                    Arbol.Recorrer(lstCodigo);
                    Arbol.Recorrer(PTArbol);
                    Arbol.RecorrerDesSW(Sw);
                    txtCodigoN.Focus();
                }
                else
                {
                    Arbol.RecorrerDes(lstListarArbol);
                    Arbol.RecorrerDes(dgGrillaArbol);
                    Arbol.RecorrerDes(lstCodigo);
                    Arbol.RecorrerDes(PTArbol);
                    Arbol.RecorrerDesSW(Sw);
                    txtCodigoN.Focus();
                }
                if (optPreOrden.Checked)
                {
                    Arbol.RecorrerPreOrden(dgGrillaArbol);
                    Arbol.RecorrerPreOrden(lstListarArbol);
                    Arbol.RecorrerPreOrden(lstCodigo);
                    Arbol.RecorrerPreOrden(PTArbol);
                    Arbol.RecorrerPreOrdenSW(Sw);
                    txtCodigoN.Focus();

                }
                if (optPostOrden.Checked)
                {
                    Arbol.RecorrerPostOrden(dgGrillaArbol);
                    Arbol.RecorrerPostOrden(lstListarArbol);
                    Arbol.RecorrerPostOrden(lstCodigo);
                    Arbol.RecorrerPostOrden(PTArbol);
                    Arbol.RecorrerPreOrdenSW(Sw);
                    txtCodigoN.Focus();
                }

                txtCodigoN.Text = "";
                txtNombreN.Text = "";
                txtTramiteN.Text = "";
                Sw.Close();
                Sw.Dispose();

            }
            else
            {
                MessageBox.Show("TU CODIGO SE REPITE, POR FAVOR INTENTA CON OTRO");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((Arbol.Raiz != null) && (lstCodigo.SelectedIndex != -1))
            {
                Arbol.Eliminar(Convert.ToInt32(lstCodigo.SelectedItem));
                SeleccionRecorrido();
                RecorrerElementos();


                if (Arbol.Raiz == null)
                {
                    File.Delete("./Hola.csv");
                    dgGrillaArbol.Rows.Clear();
                    lstCodigo.Items.Clear();
                    lstListarArbol.Items.Clear();
                    PTArbol.Nodes.Clear();

                }

            }
            else
            {
                MessageBox.Show("No se encuentran datos");
            }
            txtCodigoN.Focus();



        }

        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optInOrden.Checked == true)
            {
                mrcLista.Enabled = true;
                optAscendente.Enabled = true;
            }
        }

        private void mrcLista_Enter(object sender, EventArgs e)
        {

        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPreOrden.Checked == true)
            {

                mrcLista.Enabled = true;

            }
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (optPostOrden.Checked == true)
            {

                mrcLista.Enabled = true;
            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {


        }

        public void SeleccionRecorrido()
        {
            if (optInOrden.Checked)
            {
                recorrer = "InOrden";
                if (optAscendente.Checked)
                {
                    asc = true;
                }
                else if (optDescendente.Checked)
                {
                    asc = false;
                }
            }
            else if (optPostOrden.Checked)
            {
                recorrer = "PostOrden";
            }
            else if (optPreOrden.Checked)
            {
                recorrer = "PreOrden";
            }

        }
        public void RecorrerElementos()
        {
            if (Arbol.Raiz != null)
            {
                StreamWriter sw = new StreamWriter("./REPORTE.txt", false);
                Arbol.Recorrer(sw, asc, recorrer);
                sw.Close();
                sw.Dispose();
                Arbol.Recorrer(lstListarArbol, asc, recorrer);
                Arbol.Recorrer(lstCodigo, asc, recorrer);
                Arbol.Recorrer(dgGrillaArbol, recorrer, asc);
                Arbol.Recorrer(PTArbol);
                PTArbol.ExpandAll();


            }

        }

        private void Validaciones()
        {
            if (txtCodigoN.Text != string.Empty && txtNombreN.Text != string.Empty && txtTramiteN.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;

            }
        }

        private void txtCodigoN_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtNombreN_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void txtTramiteN_TextChanged(object sender, EventArgs e)
        {
            Validaciones();

        }

        private void mrcElementoEliminado_Enter(object sender, EventArgs e)
        {

        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCodigo .SelectedText == null)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        
        private void btnEqulibrar_Click(object sender, EventArgs e)
        {
            if (Arbol.Raiz != null)
            {
                Arbol.Equilibrar();
                Arbol.Recorrer(dgGrillaArbol);
                Arbol.Recorrer(lstListarArbol);
                Arbol.Recorrer(lstCodigo);
                Arbol.Recorrer(PTArbol);
            }
        }
       

    }



        
}



