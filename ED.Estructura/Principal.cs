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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema objVentana = new Sistema();
            objVentana.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila objVentanaPila = new frmPila();
            objVentanaPila.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola objVentanaPila = new frmCola();
            objVentanaPila.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void liToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple objVentanaPila = new frmListaSimple();
            objVentanaPila.ShowDialog();
        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble objVentanaPila = new frmListaDoble();
            objVentanaPila.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol objVentanaPila = new frmArbol();
            objVentanaPila.ShowDialog();
        }

        private void operacionConBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDato objVentanaPila = new frmBaseDato();
            objVentanaPila.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBase objVentanaPila = new frmConsultaBase();
            objVentanaPila.ShowDialog();
        }

        private void repasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepasoBase objVentanaPila = new frmRepasoBase();
            objVentanaPila.ShowDialog();
        }
    }
}
