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
    public partial class frmRepasoBase : Form
    {
        clsBaseDeDato Base;

        public frmRepasoBase()
        {
            InitializeComponent();
        }

        private void frmRepasoBase_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Base = new clsBaseDeDato();
            String varSql = "SELECT * FROM LIBRO";
            switch (cbConsulta.SelectedIndex)
            {
                //diferencia
                case 0:
                    lblRepaso.Text = cbConsulta.Text + ":       "
                        + "Idiomas que no tienen libros ";
                    varSql = "Select * from idioma where " +
                        "Ididioma not in " + "(Select IdIdioma from Libro) ";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                //Interseccion
                case 1:
                    lblRepaso.Text = cbConsulta.Text + ":             " +
                        "Idiomas que si tienen libros ";
                    varSql = "Select * From Idioma where " +
                        " IdIdioma in " +
                        " (Select IdIdioma from Libro) ";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 2:
                    lblRepaso.Text = cbConsulta.Text + ": " +
                        "Libros y Autores";
                    varSql = "Select  Titulo, Nombre " +
                        "from Libro inner join Autor " +
                        "on Libro.IdAutor = Autor.IdAutor ";

                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 3:
                    lblRepaso.Text = cbConsulta.Text + ": " +
                        "Todos los autores de los libros";
                    varSql = "Select Nombre From Autor";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 4: //Proyeccion multiatributo
                    lblRepaso.Text = cbConsulta.Text + ":" +
                        "Muestra Pais, Titulo y Cantidad";
                    varSql = "Select IdPais, Titulo, Cantidad from Libro";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 5://seleccion con and
                    lblRepaso.Text = cbConsulta.Text + ":" +
                        "Muestra todos los libros Alemanes con su precio ";
                    varSql = "Select * from Libro " +
                        "where IdPais =  5 AND Precio ";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 6://Seleccion multiatributo con operador OR
                    lblRepaso.Text = cbConsulta.Text + ":" +
                     "Muestra todos los libros que su autor sea Carlos o Virginia ";
                    varSql = "Select * from Libro " +
                        "where IdAutor = 2 OR IdAutor = 3 ";
                    Base.Listar(dgRepasoBase, varSql);

                    break;

                case 7://Seleccion multiatributo por convolucion
                    lblRepaso.Text = cbConsulta.Text + ":" +
                     "Muestra los libros de Alemania con cantidad mayor que 2 ";
                    varSql = "Select * From " +
                        "(Select  Titulo, Cantidad, IdPais, IdIdioma From Libro where Cantidad > 2) as X " +
                        "Where IdIdioma = 3 ";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 8://seleccion simple
                    lblRepaso.Text = cbConsulta.Text + ":" +
                    "Muestra los libros con cantidad mayor que 5 ";
                    varSql = "Select Titulo from Libro " +
                        "where Cantidad > 5 ";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 9: //union
                    lblRepaso.Text = cbConsulta.Text + ":" +
                        "Muestra los libros con Idoma  Hebreo y Noruego";
                    varSql = "Select * From Libro " +
                        " where IdIdioma = 18 " +
                        "union " +
                        "Select * From Libro where IdIdioma = 7";
                    Base.Listar(dgRepasoBase, varSql);
                    break;

            }
        }
    }
}
