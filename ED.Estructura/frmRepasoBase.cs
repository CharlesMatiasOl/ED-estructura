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
                
                case 0:
                    lblRepaso.Text = cbConsulta.Text + ":       "
                        + "Idiomas que no tienen libros ";
                    varSql = "Select * from idioma where " +
                        "Ididioma not in " + "(Select IdIdioma from Libro) ";//diferencia
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                
                case 1:
                    lblRepaso.Text = cbConsulta.Text + ":             " +
                        "Idiomas que si tienen libros ";
                    varSql = "Select * From Idioma where " +
                        " IdIdioma in " +
                        " (Select IdIdioma from Libro) ";//Interseccion
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
                case 4: 
                    lblRepaso.Text = cbConsulta.Text + ":" +
                        "Muestra Pais, Titulo y Cantidad";
                    varSql = "Select IdPais, Titulo, Cantidad from Libro";//Proyeccion multiatributo
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 5:
                    lblRepaso.Text = cbConsulta.Text + ":" +
                        "Muestra todos los libros Alemanes con su precio ";//seleccion 
                    varSql = "Select * from Libro " +
                        "where IdPais =  5 AND Precio ";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 6:
                    lblRepaso.Text = cbConsulta.Text + ":" +
                     "Muestra todos los libros que su autor sea Carlos o Virginia ";//Seleccion multiatributo 
                    varSql = "Select * from Libro " +
                        "where IdAutor = 2 OR IdAutor = 3 ";
                    Base.Listar(dgRepasoBase, varSql);

                    break;

                case 7:
                    lblRepaso.Text = cbConsulta.Text + ":" +
                     "Muestra los libros de Alemania con cantidad mayor que 2 ";//Seleccion multiatributo 
                    varSql = "Select * From " +
                        "(Select  Titulo, Cantidad, IdPais, IdIdioma From Libro where Cantidad > 2) as X " +
                        "Where IdIdioma = 3 ";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 8:
                    lblRepaso.Text = cbConsulta.Text + ":" +
                    "Muestra los libros con cantidad mayor que 5 ";//seleccion simple
                    varSql = "Select Titulo from Libro " +
                        "where Cantidad > 5 ";
                    Base.Listar(dgRepasoBase, varSql);
                    break;
                case 9: 
                    lblRepaso.Text = cbConsulta.Text + ":" +
                        "Muestra los libros con Idoma  Hebreo y Noruego";//union
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
