namespace Sumar
{
    partial class Calculadora
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
            this.LBLNum1 = new System.Windows.Forms.Label();
            this.LBLNum2 = new System.Windows.Forms.Label();
            this.TXTNum1 = new System.Windows.Forms.TextBox();
            this.TXTNum2 = new System.Windows.Forms.TextBox();
            this.BTNSumar = new System.Windows.Forms.Button();
            this.BTNResta = new System.Windows.Forms.Button();
            this.BTNMultiplicacion = new System.Windows.Forms.Button();
            this.LBLError = new System.Windows.Forms.Label();
            this.LBLResultado = new System.Windows.Forms.Label();
            this.TXTResultado = new System.Windows.Forms.TextBox();
            this.BTNDividir = new System.Windows.Forms.Button();
            this.lblInformativo1 = new System.Windows.Forms.Label();
            this.lblInformativo2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDecorativo = new System.Windows.Forms.Panel();
            this.lblInformativo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDecorativo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLNum1
            // 
            this.LBLNum1.AutoSize = true;
            this.LBLNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNum1.ForeColor = System.Drawing.Color.Black;
            this.LBLNum1.Location = new System.Drawing.Point(27, 27);
            this.LBLNum1.Name = "LBLNum1";
            this.LBLNum1.Size = new System.Drawing.Size(46, 16);
            this.LBLNum1.TabIndex = 1;
            this.LBLNum1.Text = "Num1";
            // 
            // LBLNum2
            // 
            this.LBLNum2.AutoSize = true;
            this.LBLNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNum2.ForeColor = System.Drawing.Color.Black;
            this.LBLNum2.Location = new System.Drawing.Point(27, 55);
            this.LBLNum2.Name = "LBLNum2";
            this.LBLNum2.Size = new System.Drawing.Size(46, 16);
            this.LBLNum2.TabIndex = 2;
            this.LBLNum2.Text = "Num2";
            // 
            // TXTNum1
            // 
            this.TXTNum1.Location = new System.Drawing.Point(97, 21);
            this.TXTNum1.Name = "TXTNum1";
            this.TXTNum1.Size = new System.Drawing.Size(53, 22);
            this.TXTNum1.TabIndex = 3;
            // 
            // TXTNum2
            // 
            this.TXTNum2.Location = new System.Drawing.Point(97, 49);
            this.TXTNum2.Name = "TXTNum2";
            this.TXTNum2.Size = new System.Drawing.Size(53, 22);
            this.TXTNum2.TabIndex = 4;
            // 
            // BTNSumar
            // 
            this.BTNSumar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTNSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSumar.ForeColor = System.Drawing.Color.Black;
            this.BTNSumar.Location = new System.Drawing.Point(33, 21);
            this.BTNSumar.Name = "BTNSumar";
            this.BTNSumar.Size = new System.Drawing.Size(48, 52);
            this.BTNSumar.TabIndex = 5;
            this.BTNSumar.Text = "+";
            this.BTNSumar.UseVisualStyleBackColor = false;
            this.BTNSumar.Click += new System.EventHandler(this.BTNSumar_Click);
            // 
            // BTNResta
            // 
            this.BTNResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTNResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNResta.ForeColor = System.Drawing.Color.Black;
            this.BTNResta.Location = new System.Drawing.Point(98, 21);
            this.BTNResta.Name = "BTNResta";
            this.BTNResta.Size = new System.Drawing.Size(47, 52);
            this.BTNResta.TabIndex = 6;
            this.BTNResta.Text = "-";
            this.BTNResta.UseVisualStyleBackColor = false;
            this.BTNResta.Click += new System.EventHandler(this.BTNResta_Click);
            // 
            // BTNMultiplicacion
            // 
            this.BTNMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTNMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMultiplicacion.ForeColor = System.Drawing.Color.Black;
            this.BTNMultiplicacion.Location = new System.Drawing.Point(33, 79);
            this.BTNMultiplicacion.Name = "BTNMultiplicacion";
            this.BTNMultiplicacion.Size = new System.Drawing.Size(48, 51);
            this.BTNMultiplicacion.TabIndex = 7;
            this.BTNMultiplicacion.Text = "x";
            this.BTNMultiplicacion.UseVisualStyleBackColor = false;
            this.BTNMultiplicacion.Click += new System.EventHandler(this.BTNMultiplicacion_Click);
            // 
            // LBLError
            // 
            this.LBLError.AutoSize = true;
            this.LBLError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLError.ForeColor = System.Drawing.Color.Brown;
            this.LBLError.Location = new System.Drawing.Point(1, 206);
            this.LBLError.Name = "LBLError";
            this.LBLError.Size = new System.Drawing.Size(302, 20);
            this.LBLError.TabIndex = 9;
            this.LBLError.Text = "Numero/s introducido/s no valido/s";
            this.LBLError.Visible = false;
            // 
            // LBLResultado
            // 
            this.LBLResultado.AutoSize = true;
            this.LBLResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLResultado.ForeColor = System.Drawing.Color.Black;
            this.LBLResultado.Location = new System.Drawing.Point(28, 13);
            this.LBLResultado.Name = "LBLResultado";
            this.LBLResultado.Size = new System.Drawing.Size(114, 20);
            this.LBLResultado.TabIndex = 10;
            this.LBLResultado.Text = "3. Resultado";
            // 
            // TXTResultado
            // 
            this.TXTResultado.Location = new System.Drawing.Point(11, 12);
            this.TXTResultado.Name = "TXTResultado";
            this.TXTResultado.Size = new System.Drawing.Size(69, 22);
            this.TXTResultado.TabIndex = 11;
            // 
            // BTNDividir
            // 
            this.BTNDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BTNDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDividir.ForeColor = System.Drawing.Color.Black;
            this.BTNDividir.Location = new System.Drawing.Point(98, 79);
            this.BTNDividir.Name = "BTNDividir";
            this.BTNDividir.Size = new System.Drawing.Size(47, 51);
            this.BTNDividir.TabIndex = 12;
            this.BTNDividir.Text = "/";
            this.BTNDividir.UseVisualStyleBackColor = false;
            this.BTNDividir.Click += new System.EventHandler(this.BTNDividir_Click);
            // 
            // lblInformativo1
            // 
            this.lblInformativo1.AutoSize = true;
            this.lblInformativo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo1.ForeColor = System.Drawing.Color.Black;
            this.lblInformativo1.Location = new System.Drawing.Point(3, 15);
            this.lblInformativo1.Name = "lblInformativo1";
            this.lblInformativo1.Size = new System.Drawing.Size(300, 20);
            this.lblInformativo1.TabIndex = 13;
            this.lblInformativo1.Text = "1. Introduce numeros de operacion";
            // 
            // lblInformativo2
            // 
            this.lblInformativo2.AutoSize = true;
            this.lblInformativo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo2.ForeColor = System.Drawing.Color.Black;
            this.lblInformativo2.Location = new System.Drawing.Point(11, 15);
            this.lblInformativo2.Name = "lblInformativo2";
            this.lblInformativo2.Size = new System.Drawing.Size(246, 20);
            this.lblInformativo2.TabIndex = 14;
            this.lblInformativo2.Text = "2. Elige operación a realizar";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVolver.Location = new System.Drawing.Point(537, 521);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 56);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(34, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 127);
            this.panel4.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.LBLNum1);
            this.groupBox1.Controls.Add(this.LBLNum2);
            this.groupBox1.Controls.Add(this.TXTNum1);
            this.groupBox1.Controls.Add(this.TXTNum2);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblInformativo1);
            this.panel1.Controls.Add(this.LBLError);
            this.panel1.Location = new System.Drawing.Point(23, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 250);
            this.panel1.TabIndex = 28;
            // 
            // pnlDecorativo
            // 
            this.pnlDecorativo.BackColor = System.Drawing.Color.Gray;
            this.pnlDecorativo.Controls.Add(this.lblInformativo);
            this.pnlDecorativo.Location = new System.Drawing.Point(265, 59);
            this.pnlDecorativo.Name = "pnlDecorativo";
            this.pnlDecorativo.Size = new System.Drawing.Size(191, 56);
            this.pnlDecorativo.TabIndex = 29;
            // 
            // lblInformativo
            // 
            this.lblInformativo.AutoSize = true;
            this.lblInformativo.BackColor = System.Drawing.Color.Gray;
            this.lblInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo.ForeColor = System.Drawing.Color.White;
            this.lblInformativo.Location = new System.Drawing.Point(21, 15);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(168, 25);
            this.lblInformativo.TabIndex = 0;
            this.lblInformativo.Text = "MiniCalculadora";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblInformativo2);
            this.panel2.Location = new System.Drawing.Point(366, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 274);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(15, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 193);
            this.panel3.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox2.Controls.Add(this.BTNMultiplicacion);
            this.groupBox2.Controls.Add(this.BTNDividir);
            this.groupBox2.Controls.Add(this.BTNSumar);
            this.groupBox2.Controls.Add(this.BTNResta);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(20, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 157);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.LBLResultado);
            this.panel5.Location = new System.Drawing.Point(84, 417);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 160);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PowderBlue;
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Location = new System.Drawing.Point(30, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(128, 73);
            this.panel6.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox3.Controls.Add(this.TXTResultado);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(16, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(94, 47);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(209)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(693, 589);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDecorativo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Calculadora";
            this.Text = "Operaciones";
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDecorativo.ResumeLayout(false);
            this.pnlDecorativo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBLNum1;
        private System.Windows.Forms.Label LBLNum2;
        private System.Windows.Forms.TextBox TXTNum1;
        private System.Windows.Forms.TextBox TXTNum2;
        private System.Windows.Forms.Button BTNSumar;
        private System.Windows.Forms.Button BTNResta;
        private System.Windows.Forms.Button BTNMultiplicacion;
        private System.Windows.Forms.Label LBLError;
        private System.Windows.Forms.Label LBLResultado;
        private System.Windows.Forms.TextBox TXTResultado;
        private System.Windows.Forms.Button BTNDividir;
        private System.Windows.Forms.Label lblInformativo1;
        private System.Windows.Forms.Label lblInformativo2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDecorativo;
        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

