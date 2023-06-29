using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED.Estructura
{
    internal class clsBaseDeDato
    {
        private OleDbConnection conexion = new OleDbConnection();//Establece la conexion con la base de datos
        private OleDbCommand comando = new OleDbCommand();//Ordena comandos
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//Adapta los datos 

        private string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Libreria.mdb";

        public void Listar(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = cadena;//abrir la conexion
                conexion.Open();
               
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";//nombre de la tabla 

                adaptador = new OleDbDataAdapter(comando);//adptar los datos 
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Libro");//lleno con datos de la tabla 

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Libro"];
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                conexion.Close();

            }
        }

        public void Listar(DataGridView grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();
                
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Resultado"];
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }


    }
}
