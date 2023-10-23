namespace Ejercicio3SMT
{
    partial class Ejercicio3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSesion = new System.Windows.Forms.Label();
            this.lblUsusario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnSesion = new System.Windows.Forms.Button();
            this.lblComprobacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.BackColor = System.Drawing.Color.White;
            this.lblSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.ForeColor = System.Drawing.Color.Black;
            this.lblSesion.Location = new System.Drawing.Point(61, 29);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(157, 24);
            this.lblSesion.TabIndex = 0;
            this.lblSesion.Text = "Inicio de sesión";
            // 
            // lblUsusario
            // 
            this.lblUsusario.AutoSize = true;
            this.lblUsusario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsusario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsusario.ForeColor = System.Drawing.Color.Black;
            this.lblUsusario.Location = new System.Drawing.Point(30, 94);
            this.lblUsusario.Name = "lblUsusario";
            this.lblUsusario.Size = new System.Drawing.Size(69, 17);
            this.lblUsusario.TabIndex = 1;
            this.lblUsusario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(30, 132);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 17);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsuario.Location = new System.Drawing.Point(150, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "usu1";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtContraseña.Location = new System.Drawing.Point(150, 133);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.Text = "pw1";
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.ForeColor = System.Drawing.Color.White;
            this.btnSesion.Location = new System.Drawing.Point(75, 192);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(124, 64);
            this.btnSesion.TabIndex = 5;
            this.btnSesion.Text = "Iniciar sesión";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // lblComprobacion
            // 
            this.lblComprobacion.AutoSize = true;
            this.lblComprobacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobacion.ForeColor = System.Drawing.Color.Red;
            this.lblComprobacion.Location = new System.Drawing.Point(17, 280);
            this.lblComprobacion.Name = "lblComprobacion";
            this.lblComprobacion.Size = new System.Drawing.Size(236, 16);
            this.lblComprobacion.TabIndex = 6;
            this.lblComprobacion.Text = "Usuario o contrasñea incorrectos";
            this.lblComprobacion.Visible = false;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 330);
            this.Controls.Add(this.lblComprobacion);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsusario);
            this.Controls.Add(this.lblSesion);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3 Toñi Sanchez Maiquez";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.Label lblUsusario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Label lblComprobacion;
    }
}

