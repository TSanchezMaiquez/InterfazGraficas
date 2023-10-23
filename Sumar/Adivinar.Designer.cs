namespace Sumar
{
    partial class Adivinar
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
            this.lblInformativo = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblPista = new System.Windows.Forms.Label();
            this.txtMayorMenor = new System.Windows.Forms.TextBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.lblPAso2 = new System.Windows.Forms.Label();
            this.lblDerrotaVictoria = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlDecorativo = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlDecorativo.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformativo
            // 
            this.lblInformativo.AutoSize = true;
            this.lblInformativo.BackColor = System.Drawing.Color.Transparent;
            this.lblInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInformativo.Location = new System.Drawing.Point(27, 12);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(446, 25);
            this.lblInformativo.TabIndex = 0;
            this.lblInformativo.Text = "Intenta adivinar el numero. Tienes 7 intentos:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(120, 68);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(57, 22);
            this.txtNum.TabIndex = 2;
            // 
            // lblPista
            // 
            this.lblPista.AutoSize = true;
            this.lblPista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPista.Location = new System.Drawing.Point(140, 442);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(225, 20);
            this.lblPista.TabIndex = 3;
            this.lblPista.Text = "El numero introducido es:";
            // 
            // txtMayorMenor
            // 
            this.txtMayorMenor.Location = new System.Drawing.Point(405, 440);
            this.txtMayorMenor.Name = "txtMayorMenor";
            this.txtMayorMenor.Size = new System.Drawing.Size(96, 22);
            this.txtMayorMenor.TabIndex = 4;
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.ForeColor = System.Drawing.Color.Black;
            this.btnComprobar.Location = new System.Drawing.Point(6, 9);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(122, 70);
            this.btnComprobar.TabIndex = 5;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.ForeColor = System.Drawing.Color.Black;
            this.lblIntentos.Location = new System.Drawing.Point(577, 199);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(167, 20);
            this.lblIntentos.TabIndex = 6;
            this.lblIntentos.Text = "Intentos restantes:";
            // 
            // txtIntentos
            // 
            this.txtIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntentos.Location = new System.Drawing.Point(648, 235);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.Size = new System.Drawing.Size(32, 22);
            this.txtIntentos.TabIndex = 7;
            this.txtIntentos.Text = "7";
            this.txtIntentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPaso1
            // 
            this.lblPaso1.AutoSize = true;
            this.lblPaso1.BackColor = System.Drawing.Color.Transparent;
            this.lblPaso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaso1.ForeColor = System.Drawing.Color.Black;
            this.lblPaso1.Location = new System.Drawing.Point(22, 44);
            this.lblPaso1.Name = "lblPaso1";
            this.lblPaso1.Size = new System.Drawing.Size(254, 24);
            this.lblPaso1.TabIndex = 8;
            this.lblPaso1.Text = "1. Crear numero aleatorio:";
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatorio.ForeColor = System.Drawing.Color.Black;
            this.btnAleatorio.Location = new System.Drawing.Point(6, 7);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(100, 45);
            this.btnAleatorio.TabIndex = 9;
            this.btnAleatorio.Text = "!A jugar!";
            this.btnAleatorio.UseVisualStyleBackColor = false;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // lblPAso2
            // 
            this.lblPAso2.AutoSize = true;
            this.lblPAso2.BackColor = System.Drawing.Color.Transparent;
            this.lblPAso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAso2.ForeColor = System.Drawing.Color.Black;
            this.lblPAso2.Location = new System.Drawing.Point(22, 25);
            this.lblPAso2.Name = "lblPAso2";
            this.lblPAso2.Size = new System.Drawing.Size(247, 24);
            this.lblPAso2.TabIndex = 10;
            this.lblPAso2.Text = "2. Introdudce un numero:";
            // 
            // lblDerrotaVictoria
            // 
            this.lblDerrotaVictoria.AutoSize = true;
            this.lblDerrotaVictoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerrotaVictoria.ForeColor = System.Drawing.Color.Red;
            this.lblDerrotaVictoria.Location = new System.Drawing.Point(802, 373);
            this.lblDerrotaVictoria.Name = "lblDerrotaVictoria";
            this.lblDerrotaVictoria.Size = new System.Drawing.Size(0, 20);
            this.lblDerrotaVictoria.TabIndex = 11;
            this.lblDerrotaVictoria.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolver.Location = new System.Drawing.Point(665, 406);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 71);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.White;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Brown;
            this.lblError.Location = new System.Drawing.Point(76, 103);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(230, 16);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "El valor introducido no es valido";
            this.lblError.Visible = false;
            // 
            // pnlDecorativo
            // 
            this.pnlDecorativo.BackColor = System.Drawing.Color.Gray;
            this.pnlDecorativo.Controls.Add(this.lblInformativo);
            this.pnlDecorativo.Location = new System.Drawing.Point(151, 31);
            this.pnlDecorativo.Name = "pnlDecorativo";
            this.pnlDecorativo.Size = new System.Drawing.Size(539, 47);
            this.pnlDecorativo.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PowderBlue;
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Location = new System.Drawing.Point(368, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(133, 81);
            this.panel6.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Controls.Add(this.btnAleatorio);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 59);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblPaso1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 116);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblPAso2);
            this.panel2.Controls.Add(this.txtNum);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Location = new System.Drawing.Point(12, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 134);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(351, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 106);
            this.panel3.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.btnComprobar);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Adivinar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(209)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDecorativo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDerrotaVictoria);
            this.Controls.Add(this.txtIntentos);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.txtMayorMenor);
            this.Controls.Add(this.lblPista);
            this.Name = "Adivinar";
            this.Text = "Adivinar";
            this.pnlDecorativo.ResumeLayout(false);
            this.pnlDecorativo.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.TextBox txtMayorMenor;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.TextBox txtIntentos;
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.Label lblPAso2;
        private System.Windows.Forms.Label lblDerrotaVictoria;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlDecorativo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}