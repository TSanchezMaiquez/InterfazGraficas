namespace Examen1Rehecho
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
            this.lblRepetirClave2 = new System.Windows.Forms.Label();
            this.lblNuevaClave = new System.Windows.Forms.Label();
            this.txtContra2 = new System.Windows.Forms.TextBox();
            this.txtContra1 = new System.Windows.Forms.TextBox();
            this.btnCambiarContraseñaIntro = new System.Windows.Forms.Button();
            this.txtCambiarClaveClave = new System.Windows.Forms.TextBox();
            this.lblCambiarClaveClave = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1285, 28);
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
            // 
            // reintegroToolStripMenuItem
            // 
            this.reintegroToolStripMenuItem.Name = "reintegroToolStripMenuItem";
            this.reintegroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reintegroToolStripMenuItem.Text = "Reintegro";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
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
            this.grbCambiarClave.Controls.Add(this.btnLimpiar);
            this.grbCambiarClave.Controls.Add(this.btnCerrar);
            this.grbCambiarClave.Controls.Add(this.btnCambiar);
            this.grbCambiarClave.Controls.Add(this.lblRepetirClave2);
            this.grbCambiarClave.Controls.Add(this.lblNuevaClave);
            this.grbCambiarClave.Controls.Add(this.txtContra2);
            this.grbCambiarClave.Controls.Add(this.txtContra1);
            this.grbCambiarClave.Controls.Add(this.btnCambiarContraseñaIntro);
            this.grbCambiarClave.Controls.Add(this.txtCambiarClaveClave);
            this.grbCambiarClave.Controls.Add(this.lblCambiarClaveClave);
            this.grbCambiarClave.Location = new System.Drawing.Point(12, 61);
            this.grbCambiarClave.Name = "grbCambiarClave";
            this.grbCambiarClave.Size = new System.Drawing.Size(406, 285);
            this.grbCambiarClave.TabIndex = 1;
            this.grbCambiarClave.TabStop = false;
            // 
            // lblRepetirClave2
            // 
            this.lblRepetirClave2.AutoSize = true;
            this.lblRepetirClave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirClave2.Location = new System.Drawing.Point(34, 160);
            this.lblRepetirClave2.Name = "lblRepetirClave2";
            this.lblRepetirClave2.Size = new System.Drawing.Size(106, 18);
            this.lblRepetirClave2.TabIndex = 6;
            this.lblRepetirClave2.Text = "Repetir clave";
            this.lblRepetirClave2.Visible = false;
            // 
            // lblNuevaClave
            // 
            this.lblNuevaClave.AutoSize = true;
            this.lblNuevaClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaClave.Location = new System.Drawing.Point(34, 109);
            this.lblNuevaClave.Name = "lblNuevaClave";
            this.lblNuevaClave.Size = new System.Drawing.Size(99, 18);
            this.lblNuevaClave.TabIndex = 5;
            this.lblNuevaClave.Text = "Nueva clave";
            this.lblNuevaClave.Visible = false;
            // 
            // txtContra2
            // 
            this.txtContra2.Location = new System.Drawing.Point(160, 160);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.Size = new System.Drawing.Size(100, 22);
            this.txtContra2.TabIndex = 4;
            this.txtContra2.Visible = false;
            // 
            // txtContra1
            // 
            this.txtContra1.Location = new System.Drawing.Point(160, 108);
            this.txtContra1.Name = "txtContra1";
            this.txtContra1.Size = new System.Drawing.Size(100, 22);
            this.txtContra1.TabIndex = 3;
            this.txtContra1.UseSystemPasswordChar = true;
            this.txtContra1.Visible = false;
            // 
            // btnCambiarContraseñaIntro
            // 
            this.btnCambiarContraseñaIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseñaIntro.Location = new System.Drawing.Point(220, 40);
            this.btnCambiarContraseñaIntro.Name = "btnCambiarContraseñaIntro";
            this.btnCambiarContraseñaIntro.Size = new System.Drawing.Size(75, 32);
            this.btnCambiarContraseñaIntro.TabIndex = 2;
            this.btnCambiarContraseñaIntro.Text = "Intro";
            this.btnCambiarContraseñaIntro.UseVisualStyleBackColor = true;
            this.btnCambiarContraseñaIntro.Click += new System.EventHandler(this.btnCambiarContraseñaIntro_Click);
            // 
            // txtCambiarClaveClave
            // 
            this.txtCambiarClaveClave.Location = new System.Drawing.Point(89, 45);
            this.txtCambiarClaveClave.Name = "txtCambiarClaveClave";
            this.txtCambiarClaveClave.Size = new System.Drawing.Size(100, 22);
            this.txtCambiarClaveClave.TabIndex = 1;
            this.txtCambiarClaveClave.UseSystemPasswordChar = true;
            // 
            // lblCambiarClaveClave
            // 
            this.lblCambiarClaveClave.AutoSize = true;
            this.lblCambiarClaveClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarClaveClave.Location = new System.Drawing.Point(20, 45);
            this.lblCambiarClaveClave.Name = "lblCambiarClaveClave";
            this.lblCambiarClaveClave.Size = new System.Drawing.Size(50, 18);
            this.lblCambiarClaveClave.TabIndex = 0;
            this.lblCambiarClaveClave.Text = "Clave";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(303, 128);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(97, 32);
            this.btnCambiar.TabIndex = 7;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Visible = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(183, 216);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 32);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(89, 216);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 699);
            this.Controls.Add(this.grbCambiarClave);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.TextBox txtCambiarClaveClave;
        private System.Windows.Forms.Label lblCambiarClaveClave;
        private System.Windows.Forms.Button btnCambiarContraseñaIntro;
        private System.Windows.Forms.Label lblRepetirClave2;
        private System.Windows.Forms.Label lblNuevaClave;
        private System.Windows.Forms.TextBox txtContra2;
        private System.Windows.Forms.TextBox txtContra1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCambiar;
    }
}