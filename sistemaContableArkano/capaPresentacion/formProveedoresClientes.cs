using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using capaDatos;

namespace capaPresentacion
{
    public partial class formProveedoresClientes : Form
    {
        ConexionBD ingresarUsuario = new ConexionBD();  //instanciamos la clase para ingresar un nuevo usuario
        ConexionBD clienProveedor = new ConexionBD();  //instanciamos la clase para ingresar un nuevo usuario
        int IDProductoModif;
        int presionado;

        public formProveedoresClientes()
        {
            InitializeComponent();
            llenarGridCliente();
            comboTipoPerfil();

        }
        Controladores.controladores controladores = new Controladores.controladores();
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtCedula, lblCedula.Text);
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
           controladores.cuadrosSinTextoMouse(txtCedula, lblCedula.Text);
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtNombre, lblNombre.Text);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
           controladores.cuadrosSinTextoMouse(txtNombre, lblNombre.Text);
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtApellido, lblApellido.Text);
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtApellido, lblApellido.Text);
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtCorreo, lblCorreo.Text);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtCorreo, lblCorreo.Text);
        }

        private void txtDirección_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtDirección, lblDireccion.Text);
        }

        private void txtDirección_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtDirección, lblDireccion.Text);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            controladores.colorBotones(btnClientes, btnProveedor, 218, 154, 72,lblLista,"Lista Clientes");
            llenarGridCliente();
            presionado = 1;
            txtBuscar.Text = "";
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            controladores.colorBotones(btnProveedor,btnClientes,142,81,4,lblLista,"Lista Proveedores");
            llenarGridProveedor();
            presionado = 2;
            txtBuscar.Text = "";
        }

        //////Funcion que llenara el comboBox del tipo de perfil
        public void comboTipoPerfil()
        {
            SqlCommand sqlComb = new SqlCommand("select perID,perDescripcion from TB_PERFILES", clienProveedor.cnn);
            SqlDataAdapter adaptad = new SqlDataAdapter(sqlComb);
            DataTable dt3 = new DataTable();
            adaptad.Fill(dt3);

            cmbTipo.ValueMember = "perID";
            cmbTipo.DisplayMember = "perDescripcion";
            cmbTipo.DataSource = dt3;

            //codigo para autocompletado en el combobox
            AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
            foreach (DataRow row2 in dt3.Rows)
            {
                coleccion2.Add(Convert.ToString(row2["perDescripcion"]));
            }

            cmbTipo.AutoCompleteCustomSource = coleccion2;
            cmbTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTipo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        ///////Metodo para agregar un nuevo cliente o proveedor
        string tipoPerfil;
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtCorreo.Text == "" && txtDirección.Text == "")
                MessageBox.Show("Favor, debe llenar el registro");
            else
            {
                if (txtCedula.Text == "")
                {
                    MessageBox.Show("Favor, debe ingresar la cédula de identidad");
                    txtCedula.Focus();
                }
                else
                {
                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Favor, debe ingresar el nombre");
                        txtNombre.Focus();
                    }
                    else
                    {
                        if (txtApellido.Text == "")
                        {
                            MessageBox.Show("Favor, debe ingresar el apellido");
                            txtApellido.Focus();
                        }
                        else
                        {
                            if (txtCorreo.Text == "")
                            {
                                MessageBox.Show("Favor, debe ingresar un correo electrónico valido");
                                txtCorreo.Focus();
                            }
                            else
                            {
                                if (txtDirección.Text == "")
                                {
                                    MessageBox.Show("Favor, debe ingresar la dirección");
                                    txtDirección.Focus();
                                }
                                else
                                {
                                    tipoPerfil = cmbTipo.Text;
                                    string sInsertarUsuario = "insert into TB_DETALLE_PERFIL (perID,detperCedulaRuc,detperNombre,detperApellido,detperDireccion,detperCorreo) values ('" + this.cmbTipo.SelectedValue.ToString() + "', '" + this.txtCedula.Text + "', '" + this.txtNombre.Text + "', '" + this.txtApellido.Text + "', '" + this.txtDirección.Text + "', '" + this.txtCorreo.Text + "')"; //sentencia para ingresar los datos a la BD

                                    if (ingresarUsuario.insertar(sInsertarUsuario))
                                    {
                                        MessageBox.Show(tipoPerfil + " creado correctamente");
                                        if (tipoPerfil == "Cliente")
                                        {
                                            llenarGridCliente();
                                            limpiarControles();
                                        }
                                        else
                                        {
                                            llenarGridProveedor();
                                            limpiarControles();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al añadir los datos");
                                        txtCedula.Focus();
                                    }

                                }
                            }
                        }
                    }
                }

            }
        }


        ///////Metodo que servira para editar la informacion del cliente o usuario
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tipoPerfil = cmbTipo.Text;
            string sentenActualizar;


            if (txtCedula.Text == "" && txtNombre.Text == "" && txtApellido.Text == "" && txtCorreo.Text == "" && txtDirección.Text == "")
            {
                MessageBox.Show("Los datos a modificar se encuentran vacíos. Favor, debe digitar los valores deseados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (txtCedula.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para la Cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCedula.Focus();
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (txtApellido.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para el Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para el Correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
            }
            else if (txtDirección.Text == "")
            {
                MessageBox.Show("No se ha digitado ningun valor para la Dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDirección.Focus();
            }
            else
            {
                if (MessageBox.Show("¿Desea realmente modificar los valores?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sentenActualizar = "update TB_DETALLE_PERFIL set perID ='" + cmbTipo.SelectedValue.ToString() + "', detperCedulaRuc='" + txtCedula.Text + "', detperNombre ='" + txtNombre.Text + "', detperApellido ='" + txtApellido.Text + "', detperDireccion ='" + txtDirección.Text + "', detperCorreo ='" + txtCorreo.Text + "' where detperID='" + IDdetallePerfil + "'";
                    if (ingresarUsuario.actualizar(sentenActualizar) == false)
                    {
                        MessageBox.Show("Ocurrio un error al actualizar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(tipoPerfil + " editado correctamente");
                        if (tipoPerfil == "Cliente")
                        {
                            llenarGridCliente();
                        }
                        else
                        {
                            llenarGridProveedor();
                        }
                    }
                }
            }
        }

        ///////Funcion para limpiar los textBox
        public void limpiarControles()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDirección.Text = "";
            txtCorreo.Text = "";
        }

        ////////Metodo que llenara el DtaGridView con la lista de clientes o proveedores existentes
        public void llenarGridCliente()
        {
            string sentenCliProvedor;
            sentenCliProvedor = "select deper.detperID,per.perDescripcion,deper.detperCedulaRuc,deper.detperNombre,deper.detperApellido,deper.detperCorreo,deper.detperDireccion from TB_DETALLE_PERFIL deper inner join TB_PERFILES per on per.perID = deper.perID where per.perDescripcion='Cliente'";

            ingresarUsuario.LLenarGrid(dgvClienProveedor, sentenCliProvedor); //me listara todos los productos que tienen subcategoria
        }

        public void llenarGridProveedor()
        {
            string sentenCliProvedor;
            sentenCliProvedor = "select deper.detperID,per.perDescripcion,deper.detperCedulaRuc,deper.detperNombre,deper.detperApellido,deper.detperCorreo,deper.detperDireccion from TB_DETALLE_PERFIL deper inner join TB_PERFILES per on per.perID = deper.perID where per.perDescripcion='Proveedor'";

            ingresarUsuario.LLenarGrid(dgvClienProveedor, sentenCliProvedor); //me listara todos los productos que tienen subcategoria
        }


        ///////Metodo que servira eliminar cliente o proveedor 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tipoPerfil = cmbTipo.Text;
            if (MessageBox.Show("¿Desea realmente eliminar al " + tipoPerfil, "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sentencEliminar = "delete from TB_DETALLE_PERFIL where detperID = '" + IDdetallePerfil + "'";
                if (ingresarUsuario.eliminar(sentencEliminar) == true)
                {
                    MessageBox.Show(tipoPerfil + " eliminado correctamente");
                    if (tipoPerfil == "Cliente")
                    {
                        llenarGridCliente();
                        limpiarControles();
                    }
                    else
                    {
                        llenarGridProveedor();
                        limpiarControles();
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar " + tipoPerfil, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /////Metodo que servira cuando al dar clic en alguna celda del Grid devuelva los valores a los textBox para editar al cliente o proveedor
        int IDdetallePerfil;
        private void dgvClienProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDdetallePerfil = Convert.ToInt32(dgvClienProveedor.CurrentRow.Cells[0].Value);
            cmbTipo.Text = Convert.ToString(dgvClienProveedor.CurrentRow.Cells[1].Value);
            txtCedula.Text = Convert.ToString(dgvClienProveedor.CurrentRow.Cells[2].Value);
            txtNombre.Text = Convert.ToString(dgvClienProveedor.CurrentRow.Cells[3].Value);
            txtApellido.Text = Convert.ToString(dgvClienProveedor.CurrentRow.Cells[4].Value);
            txtCorreo.Text = Convert.ToString(dgvClienProveedor.CurrentRow.Cells[5].Value);
            txtDirección.Text = Convert.ToString(dgvClienProveedor.CurrentRow.Cells[6].Value);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            controladores.cuadrosTextoMouse(txtBuscar, lblBuscar.Text);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            controladores.cuadrosSinTextoMouse(txtBuscar, lblBuscar.Text);

        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvClienProveedor.CurrentCell = null;
                foreach (DataGridViewRow grid in dgvClienProveedor.Rows)
                {
                    grid.Visible = false;
                }
                foreach (DataGridViewRow grid in dgvClienProveedor.Rows)
                {
                    foreach (DataGridViewCell celdas in grid.Cells)
                    {
                        if ((celdas.Value.ToString().ToUpper().IndexOf(txtBuscar.Text.ToUpper())) == 0)
                        {
                            grid.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                if (presionado == 1)
                    llenarGridCliente();
                else
                    llenarGridProveedor();
            }
        }
    }
}
