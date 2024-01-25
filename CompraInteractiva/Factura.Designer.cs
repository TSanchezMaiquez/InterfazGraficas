namespace CompraInteractiva
{
    partial class Factura
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
            this.rtbFactura = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPresupuesto = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.btnLeerArchvo = new System.Windows.Forms.Button();
            this.rtbFichero = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbFactura
            // 
            this.rtbFactura.Location = new System.Drawing.Point(387, 118);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.Size = new System.Drawing.Size(499, 304);
            this.rtbFactura.TabIndex = 0;
            this.rtbFactura.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPresupuesto);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(47, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnPresupuesto
            // 
            this.BtnPresupuesto.Location = new System.Drawing.Point(195, 207);
            this.BtnPresupuesto.Name = "BtnPresupuesto";
            this.BtnPresupuesto.Size = new System.Drawing.Size(119, 57);
            this.BtnPresupuesto.TabIndex = 5;
            this.BtnPresupuesto.Text = "Presupuesto";
            this.BtnPresupuesto.UseVisualStyleBackColor = true;
            this.BtnPresupuesto.Click += new System.EventHandler(this.BtnPresupuesto_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(23, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(119, 80);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(158, 22);
            this.txtDni.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(23, 86);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(34, 16);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "Dni:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(23, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(925, 492);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(129, 41);
            this.btnCrearArchivo.TabIndex = 2;
            this.btnCrearArchivo.Text = "Crear archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // btnLeerArchvo
            // 
            this.btnLeerArchvo.Location = new System.Drawing.Point(1295, 492);
            this.btnLeerArchvo.Name = "btnLeerArchvo";
            this.btnLeerArchvo.Size = new System.Drawing.Size(129, 41);
            this.btnLeerArchvo.TabIndex = 3;
            this.btnLeerArchvo.Text = "Leer archivo";
            this.btnLeerArchvo.UseVisualStyleBackColor = true;
            this.btnLeerArchvo.Click += new System.EventHandler(this.btnLeerArchvo_Click);
            // 
            // rtbFichero
            // 
            this.rtbFichero.Location = new System.Drawing.Point(925, 121);
            this.rtbFichero.Name = "rtbFichero";
            this.rtbFichero.Size = new System.Drawing.Size(499, 304);
            this.rtbFichero.TabIndex = 4;
            this.rtbFichero.Text = "";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 636);
            this.Controls.Add(this.rtbFichero);
            this.Controls.Add(this.btnLeerArchvo);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbFactura);
            this.Name = "Factura";
            this.Text = "Presu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button BtnPresupuesto;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.Button btnLeerArchvo;
        private System.Windows.Forms.RichTextBox rtbFichero;
    }
}