namespace capaPresentacion
{
    partial class formReporteAsiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReporteAsiento));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReporteAsientos = new System.Windows.Forms.Label();
            this.dgvReporteCompras = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.cmbValor = new System.Windows.Forms.ComboBox();
            this.lblDesCodigo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompras)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblReporteAsientos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvReporteCompras, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.444445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.888889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.777778F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblReporteAsientos
            // 
            this.lblReporteAsientos.AutoSize = true;
            this.lblReporteAsientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReporteAsientos.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteAsientos.Location = new System.Drawing.Point(3, 0);
            this.lblReporteAsientos.Name = "lblReporteAsientos";
            this.lblReporteAsientos.Size = new System.Drawing.Size(794, 38);
            this.lblReporteAsientos.TabIndex = 0;
            this.lblReporteAsientos.Text = "Reporte de Asiento";
            this.lblReporteAsientos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvReporteCompras
            // 
            this.dgvReporteCompras.AllowUserToAddRows = false;
            this.dgvReporteCompras.AllowUserToDeleteRows = false;
            this.dgvReporteCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteCompras.Location = new System.Drawing.Point(3, 81);
            this.dgvReporteCompras.Name = "dgvReporteCompras";
            this.dgvReporteCompras.ReadOnly = true;
            this.dgvReporteCompras.Size = new System.Drawing.Size(794, 296);
            this.dgvReporteCompras.TabIndex = 74;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblDesCodigo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbValor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMostrarReporte, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 34);
            this.tableLayoutPanel2.TabIndex = 76;
            // 
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.Location = new System.Drawing.Point(638, 3);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(152, 23);
            this.btnMostrarReporte.TabIndex = 2;
            this.btnMostrarReporte.Text = "Mostrar reporte";
            this.btnMostrarReporte.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 383);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 55);
            this.tableLayoutPanel5.TabIndex = 78;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.btnExportarPDF, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(788, 49);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.btnExportarPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExportarPDF.FlatAppearance.BorderSize = 0;
            this.btnExportarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarPDF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarPDF.Image")));
            this.btnExportarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarPDF.Location = new System.Drawing.Point(3, 3);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExportarPDF.Size = new System.Drawing.Size(782, 38);
            this.btnExportarPDF.TabIndex = 47;
            this.btnExportarPDF.TabStop = false;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            // 
            // cmbValor
            // 
            this.cmbValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbValor.FormattingEnabled = true;
            this.cmbValor.Location = new System.Drawing.Point(3, 3);
            this.cmbValor.Name = "cmbValor";
            this.cmbValor.Size = new System.Drawing.Size(232, 21);
            this.cmbValor.TabIndex = 77;
            // 
            // lblDesCodigo
            // 
            this.lblDesCodigo.AutoSize = true;
            this.lblDesCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesCodigo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesCodigo.Location = new System.Drawing.Point(241, 0);
            this.lblDesCodigo.Name = "lblDesCodigo";
            this.lblDesCodigo.Size = new System.Drawing.Size(391, 34);
            this.lblDesCodigo.TabIndex = 78;
            this.lblDesCodigo.Text = "Descripción código";
            this.lblDesCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formReporteAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formReporteAsiento";
            this.Text = "formReporteAsiento";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompras)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblReporteAsientos;
        private System.Windows.Forms.DataGridView dgvReporteCompras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnMostrarReporte;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.ComboBox cmbValor;
        private System.Windows.Forms.Label lblDesCodigo;
    }
}