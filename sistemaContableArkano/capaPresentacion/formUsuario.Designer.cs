namespace capaPresentacion
{
    partial class formUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuario));
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.lblCrearUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearUsuario.Image")));
            this.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearUsuario.Location = new System.Drawing.Point(271, 350);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCrearUsuario.Size = new System.Drawing.Size(209, 45);
            this.btnCrearUsuario.TabIndex = 9;
            this.btnCrearUsuario.Text = "Añadir usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            // 
            // lblCrearUsuario
            // 
            this.lblCrearUsuario.AutoSize = true;
            this.lblCrearUsuario.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearUsuario.Location = new System.Drawing.Point(215, 24);
            this.lblCrearUsuario.Name = "lblCrearUsuario";
            this.lblCrearUsuario.Size = new System.Drawing.Size(326, 33);
            this.lblCrearUsuario.TabIndex = 10;
            this.lblCrearUsuario.Text = "Datos del nuevo usuario";
            // 
            // formUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCrearUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formUsuario";
            this.Text = "formUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Label lblCrearUsuario;
    }
}