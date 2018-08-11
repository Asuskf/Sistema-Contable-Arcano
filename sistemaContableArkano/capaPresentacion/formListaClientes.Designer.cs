namespace capaPresentacion
{
    partial class formListaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dgvListaCliente = new System.Windows.Forms.DataGridView();
            this.clmDetallePersoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetallePersoCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetallePersNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetallePersoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetallePersonDireccio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetallePersoCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblClientes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvListaCliente, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.777778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClientes.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(3, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(794, 44);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Lista Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListaCliente
            // 
            this.dgvListaCliente.AllowUserToAddRows = false;
            this.dgvListaCliente.AllowUserToDeleteRows = false;
            this.dgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDetallePersoID,
            this.clmDetallePersoCedula,
            this.clmDetallePersNombre,
            this.clmDetallePersoApellido,
            this.clmDetallePersonDireccio,
            this.clmDetallePersoCorreo});
            this.dgvListaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaCliente.Location = new System.Drawing.Point(3, 47);
            this.dgvListaCliente.Name = "dgvListaCliente";
            this.dgvListaCliente.ReadOnly = true;
            this.dgvListaCliente.Size = new System.Drawing.Size(794, 391);
            this.dgvListaCliente.TabIndex = 74;
            // 
            // clmDetallePersoID
            // 
            this.clmDetallePersoID.DataPropertyName = "detperID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmDetallePersoID.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmDetallePersoID.HeaderText = "Código cliente";
            this.clmDetallePersoID.Name = "clmDetallePersoID";
            this.clmDetallePersoID.ReadOnly = true;
            this.clmDetallePersoID.Width = 50;
            // 
            // clmDetallePersoCedula
            // 
            this.clmDetallePersoCedula.DataPropertyName = "detperCedulaRuc";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmDetallePersoCedula.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmDetallePersoCedula.HeaderText = "Cédula/Ruc";
            this.clmDetallePersoCedula.Name = "clmDetallePersoCedula";
            this.clmDetallePersoCedula.ReadOnly = true;
            this.clmDetallePersoCedula.Width = 120;
            // 
            // clmDetallePersNombre
            // 
            this.clmDetallePersNombre.DataPropertyName = "detperNombre";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmDetallePersNombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmDetallePersNombre.HeaderText = "Nombre";
            this.clmDetallePersNombre.Name = "clmDetallePersNombre";
            this.clmDetallePersNombre.ReadOnly = true;
            this.clmDetallePersNombre.Width = 180;
            // 
            // clmDetallePersoApellido
            // 
            this.clmDetallePersoApellido.DataPropertyName = "detperApellido";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmDetallePersoApellido.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmDetallePersoApellido.HeaderText = "Apellido";
            this.clmDetallePersoApellido.Name = "clmDetallePersoApellido";
            this.clmDetallePersoApellido.ReadOnly = true;
            this.clmDetallePersoApellido.Width = 180;
            // 
            // clmDetallePersonDireccio
            // 
            this.clmDetallePersonDireccio.DataPropertyName = "detperDireccion";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmDetallePersonDireccio.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmDetallePersonDireccio.HeaderText = "Dirección";
            this.clmDetallePersonDireccio.Name = "clmDetallePersonDireccio";
            this.clmDetallePersonDireccio.ReadOnly = true;
            this.clmDetallePersonDireccio.Width = 250;
            // 
            // clmDetallePersoCorreo
            // 
            this.clmDetallePersoCorreo.DataPropertyName = "detperCorreo";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmDetallePersoCorreo.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmDetallePersoCorreo.HeaderText = "Correo";
            this.clmDetallePersoCorreo.Name = "clmDetallePersoCorreo";
            this.clmDetallePersoCorreo.ReadOnly = true;
            this.clmDetallePersoCorreo.Width = 250;
            // 
            // formListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formListaClientes";
            this.Text = "formClientes";
            this.Load += new System.EventHandler(this.formListaClientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.DataGridView dgvListaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetallePersoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetallePersoCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetallePersNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetallePersoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetallePersonDireccio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetallePersoCorreo;
    }
}