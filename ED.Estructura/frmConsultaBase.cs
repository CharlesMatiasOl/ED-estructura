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
    public partial class frmConsultaBase : Form
    {
        clsBaseDeDato Base;
        public frmConsultaBase()
        {
            InitializeComponent();
        }

        private void frmConsultaBase_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSql = txtSQL.Text;

            Base.Listar(dataGridView1, varSql);
        }
    }
}
