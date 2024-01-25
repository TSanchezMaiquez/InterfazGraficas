namespace Examen1Toñi
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reintegroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbCambiarClave = new System.Windows.Forms.GroupBox();
            this.txtClaveContraseña = new System.Windows.Forms.TextBox();
            this.lblClaveContraseñas = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnContraseña = new System.Windows.Forms.Button();
            this.lblNuevaContra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbCambiarClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.cambiarClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reintegroToolStripMenuItem,
            this.ingresoToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            this.operacionesToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenu);
            // 
            // reintegroToolStripMenuItem
            // 
            this.reintegroToolStripMenuItem.Name = "reintegroToolStripMenuItem";
            this.reintegroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reintegroToolStripMenuItem.Text = "Reintegro";
            this.reintegroToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenu);
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenu);
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // grbCambiarClave
            // 
            this.grbCambiarClave.Controls.Add(this.label2);
            this.grbCambiarClave.Controls.Add(this.lblNuevaContra);
            this.grbCambiarClave.Controls.Add(this.btnContraseña);
            this.grbCambiarClave.Controls.Add(this.lblContraseña);
            this.grbCambiarClave.Controls.Add(this.lblClaveContraseñas);
            this.grbCambiarClave.Controls.Add(this.txtClaveContraseña);
            this.grbCambiarClave.Location = new System.Drawing.Point(38, 67);
            this.grbCambiarClave.Name = "grbCambiarClave";
            this.grbCambiarClave.Size = new System.Drawing.Size(274, 337);
            this.grbCambiarClave.TabIndex = 1;
            this.grbCambiarClave.TabStop = false;
            // 
            // txtClaveContraseña
            // 
            this.txtClaveContraseña.Location = new System.Drawing.Point(137, 81);
            this.txtClaveContraseña.Name = "txtClaveContraseña";
            this.txtClaveContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtClaveContraseña.TabIndex = 0;
            // 
            // lblClaveContraseñas
            // 
            this.lblClaveContraseñas.AutoSize = true;
            this.lblClaveContraseñas.Location = new System.Drawing.Point(33, 81);
            this.lblClaveContraseñas.Name = "lblClaveContraseñas";
            this.lblClaveContraseñas.Size = new System.Drawing.Size(81, 16);
            this.lblClaveContraseñas.TabIndex = 1;
            this.lblClaveContraseñas.Text = "Clave actual";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(41, 30);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(196, 24);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Cambiar contraseña";
            // 
            // btnContraseña
            // 
            this.btnContraseña.Location = new System.Drawing.Point(79, 136);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(112, 34);
            this.btnContraseña.TabIndex = 3;
            this.btnContraseña.Text = "Comprobar";
            this.btnContraseña.UseVisualStyleBackColor = true;
            this.btnContraseña.Click += new System.EventHandler(this.btnContraseña_Click);
            // 
            // lblNuevaContra
            // 
            this.lblNuevaContra.AutoSize = true;
            this.lblNuevaContra.Location = new System.Drawing.Point(27, 213);
            this.lblNuevaContra.Name = "lblNuevaContra";
            this.lblNuevaContra.Size = new System.Drawing.Size(117, 16);
            this.lblNuevaContra.TabIndex = 4;
            this.lblNuevaContra.Text = "Nueva contraseña";
            this.lblNuevaContra.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbCambiarClave);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Lalala";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbCambiarClave.ResumeLayout(false);
            this.grbCambiarClave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reintegroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbCambiarClave;
        private System.Windows.Forms.Button btnContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblClaveContraseñas;
        private System.Windows.Forms.TextBox txtClaveContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNuevaContra;
    }
}