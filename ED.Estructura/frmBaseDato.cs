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
    public partial class frmBaseDato : Form
    {
        clsBaseDeDato Base;
        public frmBaseDato()
        {
            InitializeComponent();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBaseDato_Load(object sender, EventArgs e)
        {

        }

        private void cmdProyeccionSimple_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSQL = "Select Titulo FROM Libro ";
            Base.Listar(dgBase, varSQL);
        }

        private void cmdProyeccionMulti_Click(object sender, EventArgs e)
        {

            Base = new clsBaseDeDato();
            String varSQL = "Select Titulo, Año, IdIdioma FROM Libro";
            Base.Listar(dgBase, varSQL);
        }

        private void cmdJuntar_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSql = "Select Titulo, Nombre " +
                "From Libro inner join Pais " +
                "on Libro.IdPais = Pais.IdPais ";
            Base.Listar(dgBase, varSql);
        }

        private void cmdSeleccionSimple_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSQL = "SELECT TITULO FROM Libro WHERE IdIdioma = 2";
            Base.Listar(dgBase, varSQL);
        }

        private void cmdSeleccionMulti_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSQL = "SELECT * FROM Libro WHERE IdLibro = 2 AND IdAutor > 1";
            Base.Listar(dgBase, varSQL);
        }

        private void cmdSeleccionConvolucion_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSql = "Select *" +
                " FROM (Select * from libro where IdIdioma > 1) as X " +
                "WHERE IdPais = 2 ";
            Base.Listar(dgBase, varSql);
        }

        private void cmdUnion_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSQL = " SELECT * FROM Libro WHERE IdIdioma = 2 " +
                " union " +
                " SELECT * FROM Libro where IdIdioma = 3 ";
            Base.Listar(dgBase, varSQL);
        }

        private void cmdInterseccion_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSql = "Select * from libro " +
                 " where IdIdioma=3 and IdLibro in " +
                 " (Select IdLibro from libro where IdPais =2 )" +
                 " order by 1 asc ";
            Base.Listar(dgBase, varSql);
        }

        private void cmdDiferencia_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSql = "Select * from libro " +
                " where IdIdioma=3 and IdLibro not in " +
                " (Select IdLibro from libro where IdPais =2 )" +
                " order by 1 asc ";
            Base.Listar(dgBase, varSql);
        }
    }
}
