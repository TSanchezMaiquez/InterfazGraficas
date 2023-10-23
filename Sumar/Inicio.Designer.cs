namespace Sumar
{
    partial class Inicio
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
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblFunciones = new System.Windows.Forms.Label();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblAdivinar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.BackColor = System.Drawing.Color.Transparent;
            this.lblCalculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.Location = new System.Drawing.Point(15, 30);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(117, 18);
            this.lblCalculadora.TabIndex = 0;
            this.lblCalculadora.Text = "1. Calculadora";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(15, 76);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(61, 18);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "2. Area";
            // 
            // lblFunciones
            // 
            this.lblFunciones.AutoSize = true;
            this.lblFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunciones.Location = new System.Drawing.Point(15, 126);
            this.lblFunciones.Name = "lblFunciones";
            this.lblFunciones.Size = new System.Drawing.Size(105, 18);
            this.lblFunciones.TabIndex = 2;
            this.lblFunciones.Text = "3. Funciones";
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(348, 333);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(44, 22);
            this.txtOpcion.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(209)))), ((int)(((byte)(206)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceptar.Location = new System.Drawing.Point(416, 328);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 32);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Gray;
            this.lblInformacion.Location = new System.Drawing.Point(48, 42);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(418, 25);
            this.lblInformacion.TabIndex = 5;
            this.lblInformacion.Text = "-- Elige una de las opciones disponibles --";
            this.lblInformacion.Click += new System.EventHandler(this.lblInformacion_Click);
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(73, 333);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(221, 20);
            this.lblOpcion.TabIndex = 6;
            this.lblOpcion.Text = "Introduce numero de opcion:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(126, 379);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(230, 16);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "El valor introducido no es valido";
            this.lblError.Visible = false;
            // 
            // lblAdivinar
            // 
            this.lblAdivinar.AutoSize = true;
            this.lblAdivinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdivinar.Location = new System.Drawing.Point(199, 53);
            this.lblAdivinar.Name = "lblAdivinar";
            this.lblAdivinar.Size = new System.Drawing.Size(80, 18);
            this.lblAdivinar.TabIndex = 8;
            this.lblAdivinar.Text = "4.adivinar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "5.Salir";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(87, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 194);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(225)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.lblCalculadora);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Controls.Add(this.lblAdivinar);
            this.panel2.Controls.Add(this.lblFunciones);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 170);
            this.panel2.TabIndex = 0;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(546, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtOpcion);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblFunciones;
        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAdivinar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}