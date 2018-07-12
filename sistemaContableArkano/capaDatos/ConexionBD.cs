using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace capaDatos
{
    public class ConexionBD
    {
        //cadena de conexion
        private string cadenaBD = "Data Source=SMLAB304PC21_17;Initial Catalog=SistemaContableArcano; Persist Security Info= True;User ID=sa;Password=Uisrael2018";
        //private string cadenaBD = "Data Source=DESKTOP-TL8NQ49\\ALEXGD;Initial Catalog=SistemaContableArcano; Persist Security Info= True; Integrated Security=True";
        public SqlConnection cnn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();  //el data set guarda varias tablas llamadas Datatable que nos servira para mostrar los datos
        public SqlDataAdapter adapt;

        public SqlCommand comando;
        public DataTable dt1;

        public void conectar()
        {
            cnn = new SqlConnection(cadenaBD);
        }

        public ConexionBD()
        {
            conectar();

        }

        //////Metodo para consultar sentencias "select"  
        public void consultar(string sql, string tabla)
        {
            try
            {
                //codigo que posiblemente puede fallar
                ds.Tables.Clear();
                adapt = new SqlDataAdapter(sql, cnn);
                cmb = new SqlCommandBuilder(adapt);
                adapt.Fill(ds, tabla);
            }
            catch (Exception ex)
            {
                //codigo que se ejecutara si hay el fallo

            }
        }


        /////////Metodo para eliminar
        public bool eliminar(string setencia2)
        {
            cnn.Open();
            comando = new SqlCommand(setencia2, cnn);
            int i = comando.ExecuteNonQuery();
            cnn.Close();
            if (1 > 0)
                return true;
            else
                return false;

        }


        /////////Metodo para actualizar
        public bool actualizar(string sentencia)
        {
            cnn.Open();
            comando = new SqlCommand(sentencia, cnn);
            int i = comando.ExecuteNonQuery();
            cnn.Close();

            if (i > 0)
                return true;
            else
                return false;
        }


        ///////////Metodo para insertar
        public bool insertar(string sql4)
        {
            cnn.Open();
            comando = new SqlCommand(sql4, cnn);
            int i = comando.ExecuteNonQuery();
            cnn.Close();
            if (i > 0)
                return true;
            else
                return false;

        }

        public void LLenarGrid(DataGridView grid, string sql5)
        {
            cnn.Open();
            comando = new SqlCommand(sql5, cnn);
            adapt = new SqlDataAdapter(comando);
            dt1 = new DataTable();
            adapt.Fill(dt1);
            grid.DataSource = dt1;
            cnn.Close();
        }

    }
}
