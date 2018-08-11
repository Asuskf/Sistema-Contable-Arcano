namespace capaPresentacion
{
    partial class formListaProveedores
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
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.clmProverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedorApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedorDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedorCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.AllowUserToAddRows = false;
            this.dgvListaProveedores.AllowUserToDeleteRows = false;
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProverID,
            this.clmProveedorCedula,
            this.clmProveedorNombre,
            this.clmProveedorApellido,
            this.clmProveedorDireccion,
            this.clmProveedorCorreo});
            this.dgvListaProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaProveedores.Location = new System.Drawing.Point(3, 47);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.ReadOnly = true;
            this.dgvListaProveedores.Size = new System.Drawing.Size(794, 391);
            this.dgvListaProveedores.TabIndex = 74;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblListaProveedores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvListaProveedores, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.777778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListaProveedores.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.Location = new System.Drawing.Point(3, 0);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(794, 44);
            this.lblListaProveedores.TabIndex = 0;
            this.lblListaProveedores.Text = "Lista Proveedores";
            this.lblListaProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clmProverID
            // 
            this.clmProverID.DataPropertyName = "detperID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmProverID.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmProverID.HeaderText = "Código Proveedor";
            this.clmProverID.Name = "clmProverID";
            this.clmProverID.ReadOnly = true;
            this.clmProverID.Width = 50;
            // 
            // clmProveedorCedula
            // 
            this.clmProveedorCedula.DataPropertyName = "detperCedulaRuc";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmProveedorCedula.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmProveedorCedula.HeaderText = "Cédula/Ruc";
            this.clmProveedorCedula.Name = "clmProveedorCedula";
            this.clmProveedorCedula.ReadOnly = true;
            this.clmProveedorCedula.Width = 150;
            // 
            // clmProveedorNombre
            // 
            this.clmProveedorNombre.DataPropertyName = "detperNombre";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmProveedorNombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmProveedorNombre.HeaderText = "Nombre";
            this.clmProveedorNombre.Name = "clmProveedorNombre";
            this.clmProveedorNombre.ReadOnly = true;
            this.clmProveedorNombre.Width = 220;
            // 
            // clmProveedorApellido
            // 
            this.clmProveedorApellido.DataPropertyName = "detperApellido";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmProveedorApellido.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmProveedorApellido.HeaderText = "Apellido";
            this.clmProveedorApellido.Name = "clmProveedorApellido";
            this.clmProveedorApellido.ReadOnly = true;
            this.clmProveedorApellido.Width = 220;
            // 
            // clmProveedorDireccion
            // 
            this.clmProveedorDireccion.DataPropertyName = "detperDireccion";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmProveedorDireccion.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmProveedorDireccion.HeaderText = "Dirección";
            this.clmProveedorDireccion.Name = "clmProveedorDireccion";
            this.clmProveedorDireccion.ReadOnly = true;
            this.clmProveedorDireccion.Width = 250;
            // 
            // clmProveedorCorreo
            // 
            this.clmProveedorCorreo.DataPropertyName = "detperCorreo";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold);
            this.clmProveedorCorreo.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmProveedorCorreo.HeaderText = "Correo";
            this.clmProveedorCorreo.Name = "clmProveedorCorreo";
            this.clmProveedorCorreo.ReadOnly = true;
            this.clmProveedorCorreo.Width = 250;
            // 
            // formListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formListaProveedores";
            this.Text = "formListaProveedores";
            this.Load += new System.EventHandler(this.formListaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProveedores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedorCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedorApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedorDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedorCorreo;
    }
}