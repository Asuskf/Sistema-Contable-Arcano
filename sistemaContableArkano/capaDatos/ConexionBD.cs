using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace capaDatos
{
    public class ConexionBD
    {
        //cadena de conexion
        private string cadenaBD = "Data Source=DESKTOP-A4GPQL3;Initial Catalog=SistemaContableArcano2;Integrated Security=True";
        //private string cadenaBD = "Data Source=DESKTOP-TL8NQ49\\ALEXGD;Initial Catalog=SistemaContableArcano; Persist Security Info= True; Integrated Security=True";
        public SqlConnection cnn;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();  //el data set guarda varias tablas llamadas Datatable que nos servira para mostrar los datos
        public SqlDataAdapter adapt;
        public DataRow dr;
        public SqlCommand comando;
        public DataTable dt1;
        private Image nothing;

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

        public string insertarUsuario(string usuNombre, string usuApellido, string usuDireccion, string usuCorreo, string usuNombreUsuario, string usuContrasena) {
            string mensaje = "Usuario creado con exito";
            cnn.Open();
            try
            {
                comando = new SqlCommand("insert into TB_USUARIO (usuNombre,usuApellido,usuDireccion,usuCorreo,usuNombreUsuario,usuContrasena) values ('" + usuNombre + "', '" + usuApellido + "', '" + usuDireccion + "', " +
                    "'" + usuCorreo + "', '" + usuNombreUsuario + "',  '" + usuContrasena + "')", cnn);
                comando.ExecuteNonQuery();
                
            }
            catch (SqlException){
                 
               mensaje = "Este nombre de usuario ya está tomado. Porfavor cabielo y vuelva a intentarlo";
            }
            cnn.Close();
            return mensaje;
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

       
        public void verImagen(PictureBox pbIconoUsuario, string usuNombreUsuario) {
            try {
                adapt = new SqlDataAdapter("Select usuFoto from TB_USUARIO where usuNombreUsuario = '" + usuNombreUsuario + "' ", cnn);
                ds = new DataSet();
                adapt.Fill(ds, "TB_USUARIO");
                byte[] datos = new byte[0];
                dr = ds.Tables["TB_USUARIO"].Rows[0];
                datos = (byte[])dr["usuFoto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pbIconoUsuario.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception e) {

                pbIconoUsuario.Image = pbIconoUsuario.InitialImage;
            }
        }

        public void verClientes(DataGridView grid, String tipoUsuario) {

            cnn.Open();
            comando = new SqlCommand("select dt.detperID as 'Codigo Cliente', dt.detperCedulaRuc as 'Cedula/Ruc', dt.detperNombre as 'Nombre', dt.detperApellido as 'Apellido', dt.detperDireccion as 'Dirección', dt.detperCorreo as 'Correo'  from TB_PERFILES p left join TB_DETALLE_PERFIL dt on p.perID = dt.perID where perDescripcion = '" + tipoUsuario + "' ; ", cnn);
            adapt = new SqlDataAdapter(comando);
            dt1 = new DataTable();
            adapt.Fill(dt1);
            grid.DataSource = dt1;
            cnn.Close();

        }

        public string guardarImagen(PictureBox usuImagen, string usuNombreUsuario)
        {
            string mensaje = "Tu foto de perfil se actualizo";
            try
            {
                cnn.Open();
                comando = new SqlCommand("update TB_USUARIO set usuFoto = @usuImagen where  usuNombreUsuario = '" + usuNombreUsuario + "'", cnn);
                comando.Parameters.Add("@usuImagen", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                usuImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                comando.Parameters["@usuImagen"].Value = ms.GetBuffer();
                comando.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                mensaje = "Tu foto de perfil no se actualizo ";
            }
            return mensaje;
        }


        
    }
}
