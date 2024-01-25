namespace CompraInteractiva
{
    partial class CompraInteractiva
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
            this.grbEquiipo = new System.Windows.Forms.GroupBox();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCabecera = new System.Windows.Forms.Label();
            this.gpbEquipoOficina = new System.Windows.Forms.GroupBox();
            this.ckb3 = new System.Windows.Forms.CheckBox();
            this.ckb2 = new System.Windows.Forms.CheckBox();
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.ltbPeriferico = new System.Windows.Forms.ListBox();
            this.lblPerifericos = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.cbbFormaDePago = new System.Windows.Forms.ComboBox();
            this.ptbPerifericos = new System.Windows.Forms.PictureBox();
            this.ptbCalculadora = new System.Windows.Forms.PictureBox();
            this.ptbFotocopiadora = new System.Windows.Forms.PictureBox();
            this.ptbContestador = new System.Windows.Forms.PictureBox();
            this.ptbFormaDePago = new System.Windows.Forms.PictureBox();
            this.ptbEquipo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.lblObligatorio = new System.Windows.Forms.Label();
            this.grbEquiipo.SuspendLayout();
            this.gpbEquipoOficina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPerifericos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCalculadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotocopiadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContestador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFormaDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEquiipo
            // 
            this.grbEquiipo.Controls.Add(this.rdb3);
            this.grbEquiipo.Controls.Add(this.rdb1);
            this.grbEquiipo.Controls.Add(this.rdb2);
            this.grbEquiipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEquiipo.Location = new System.Drawing.Point(27, 160);
            this.grbEquiipo.Name = "grbEquiipo";
            this.grbEquiipo.Size = new System.Drawing.Size(198, 187);
            this.grbEquiipo.TabIndex = 0;
            this.grbEquiipo.TabStop = false;
            this.grbEquiipo.Text = "1. Equipo (obligatorio)";
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3.Location = new System.Drawing.Point(23, 137);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(108, 20);
            this.rdb3.TabIndex = 2;
            this.rdb3.Text = "Portátil (500€)";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.Click += new System.EventHandler(this.radioButtonChecked);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.Location = new System.Drawing.Point(23, 50);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(83, 20);
            this.rdb1.TabIndex = 0;
            this.rdb1.Text = "Pc (700€)";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.Click += new System.EventHandler(this.radioButtonChecked);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb2.Location = new System.Drawing.Point(23, 93);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(135, 20);
            this.rdb2.TabIndex = 1;
            this.rdb2.Text = "Macintosh (1000€)";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.Click += new System.EventHandler(this.radioButtonChecked);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Compra interactiva";
            // 
            // lblCabecera
            // 
            this.lblCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecera.Location = new System.Drawing.Point(24, 80);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(427, 46);
            this.lblCabecera.TabIndex = 2;
            this.lblCabecera.Text = "Actualice su oficina comprando los productos que necesite con casillas de verific" +
    "ación, botones de opción y cuadros de lista";
            // 
            // gpbEquipoOficina
            // 
            this.gpbEquipoOficina.Controls.Add(this.ckb3);
            this.gpbEquipoOficina.Controls.Add(this.ckb2);
            this.gpbEquipoOficina.Controls.Add(this.ckb1);
            this.gpbEquipoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEquipoOficina.Location = new System.Drawing.Point(501, 117);
            this.gpbEquipoOficina.Name = "gpbEquipoOficina";
            this.gpbEquipoOficina.Size = new System.Drawing.Size(192, 195);
            this.gpbEquipoOficina.TabIndex = 3;
            this.gpbEquipoOficina.TabStop = false;
            this.gpbEquipoOficina.Text = "2. Equipo de oficina";
            // 
            // ckb3
            // 
            this.ckb3.AutoSize = true;
            this.ckb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb3.Location = new System.Drawing.Point(27, 140);
            this.ckb3.Name = "ckb3";
            this.ckb3.Size = new System.Drawing.Size(157, 20);
            this.ckb3.TabIndex = 2;
            this.ckb3.Text = "Fotocopiadora (100€)";
            this.ckb3.UseVisualStyleBackColor = true;
            this.ckb3.CheckedChanged += new System.EventHandler(this.CheckBoxEvent);
            // 
            // ckb2
            // 
            this.ckb2.AutoSize = true;
            this.ckb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb2.Location = new System.Drawing.Point(27, 94);
            this.ckb2.Name = "ckb2";
            this.ckb2.Size = new System.Drawing.Size(134, 20);
            this.ckb2.TabIndex = 1;
            this.ckb2.Text = "Calculadora (20€)";
            this.ckb2.UseVisualStyleBackColor = true;
            this.ckb2.CheckedChanged += new System.EventHandler(this.CheckBoxEvent);
            // 
            // ckb1
            // 
            this.ckb1.AutoSize = true;
            this.ckb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb1.Location = new System.Drawing.Point(27, 49);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(134, 20);
            this.ckb1.TabIndex = 0;
            this.ckb1.Text = "Contestador (50€)";
            this.ckb1.UseVisualStyleBackColor = true;
            this.ckb1.CheckedChanged += new System.EventHandler(this.CheckBoxEvent);
            // 
            // ltbPeriferico
            // 
            this.ltbPeriferico.FormattingEnabled = true;
            this.ltbPeriferico.ItemHeight = 16;
            this.ltbPeriferico.Location = new System.Drawing.Point(495, 460);
            this.ltbPeriferico.Name = "ltbPeriferico";
            this.ltbPeriferico.Size = new System.Drawing.Size(179, 84);
            this.ltbPeriferico.TabIndex = 4;
            this.ltbPeriferico.SelectedIndexChanged += new System.EventHandler(this.ltbPeriferico_SelectedIndexChanged);
            // 
            // lblPerifericos
            // 
            this.lblPerifericos.AutoSize = true;
            this.lblPerifericos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerifericos.Location = new System.Drawing.Point(498, 419);
            this.lblPerifericos.Name = "lblPerifericos";
            this.lblPerifericos.Size = new System.Drawing.Size(192, 18);
            this.lblPerifericos.TabIndex = 5;
            this.lblPerifericos.Text = "4. Periféricos (solo uno)";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(24, 439);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(141, 18);
            this.lblPago.TabIndex = 6;
            this.lblPago.Text = "3. Forma de pago";
            // 
            // cbbFormaDePago
            // 
            this.cbbFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFormaDePago.FormattingEnabled = true;
            this.cbbFormaDePago.Items.AddRange(new object[] {
            "Tarjeta",
            "PayPal",
            "Bizum"});
            this.cbbFormaDePago.Location = new System.Drawing.Point(22, 481);
            this.cbbFormaDePago.Name = "cbbFormaDePago";
            this.cbbFormaDePago.Size = new System.Drawing.Size(121, 24);
            this.cbbFormaDePago.TabIndex = 7;
            this.cbbFormaDePago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ptbPerifericos
            // 
            this.ptbPerifericos.Image = global::CompraInteractiva.Properties.Resources.ant;
            this.ptbPerifericos.Location = new System.Drawing.Point(709, 396);
            this.ptbPerifericos.Name = "ptbPerifericos";
            this.ptbPerifericos.Size = new System.Drawing.Size(181, 177);
            this.ptbPerifericos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPerifericos.TabIndex = 13;
            this.ptbPerifericos.TabStop = false;
            this.ptbPerifericos.Visible = false;
            // 
            // ptbCalculadora
            // 
            this.ptbCalculadora.Image = global::CompraInteractiva.Properties.Resources.por;
            this.ptbCalculadora.Location = new System.Drawing.Point(874, 96);
            this.ptbCalculadora.Name = "ptbCalculadora";
            this.ptbCalculadora.Size = new System.Drawing.Size(133, 135);
            this.ptbCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCalculadora.TabIndex = 12;
            this.ptbCalculadora.TabStop = false;
            this.ptbCalculadora.Visible = false;
            // 
            // ptbFotocopiadora
            // 
            this.ptbFotocopiadora.Image = global::CompraInteractiva.Properties.Resources.por;
            this.ptbFotocopiadora.Location = new System.Drawing.Point(1022, 95);
            this.ptbFotocopiadora.Name = "ptbFotocopiadora";
            this.ptbFotocopiadora.Size = new System.Drawing.Size(133, 135);
            this.ptbFotocopiadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFotocopiadora.TabIndex = 11;
            this.ptbFotocopiadora.TabStop = false;
            this.ptbFotocopiadora.Visible = false;
            // 
            // ptbContestador
            // 
            this.ptbContestador.Image = global::CompraInteractiva.Properties.Resources.cont;
            this.ptbContestador.Location = new System.Drawing.Point(726, 96);
            this.ptbContestador.Name = "ptbContestador";
            this.ptbContestador.Size = new System.Drawing.Size(133, 135);
            this.ptbContestador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbContestador.TabIndex = 10;
            this.ptbContestador.TabStop = false;
            this.ptbContestador.Visible = false;
            // 
            // ptbFormaDePago
            // 
            this.ptbFormaDePago.Image = global::CompraInteractiva.Properties.Resources.tar;
            this.ptbFormaDePago.Location = new System.Drawing.Point(252, 396);
            this.ptbFormaDePago.Name = "ptbFormaDePago";
            this.ptbFormaDePago.Size = new System.Drawing.Size(181, 177);
            this.ptbFormaDePago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFormaDePago.TabIndex = 9;
            this.ptbFormaDePago.TabStop = false;
            this.ptbFormaDePago.Visible = false;
            // 
            // ptbEquipo
            // 
            this.ptbEquipo.Image = global::CompraInteractiva.Properties.Resources.por;
            this.ptbEquipo.Location = new System.Drawing.Point(252, 184);
            this.ptbEquipo.Name = "ptbEquipo";
            this.ptbEquipo.Size = new System.Drawing.Size(181, 177);
            this.ptbEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEquipo.TabIndex = 8;
            this.ptbEquipo.TabStop = false;
            this.ptbEquipo.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(997, 481);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 63);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Location = new System.Drawing.Point(997, 396);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(109, 61);
            this.btnPresupuesto.TabIndex = 15;
            this.btnPresupuesto.Text = "Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // lblObligatorio
            // 
            this.lblObligatorio.AutoSize = true;
            this.lblObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblObligatorio.Location = new System.Drawing.Point(854, 343);
            this.lblObligatorio.Name = "lblObligatorio";
            this.lblObligatorio.Size = new System.Drawing.Size(284, 18);
            this.lblObligatorio.TabIndex = 16;
            this.lblObligatorio.Text = "Los apartados 1 y 3 son obligatorios";
            this.lblObligatorio.Visible = false;
            // 
            // CompraInteractiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 603);
            this.Controls.Add(this.lblObligatorio);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.ptbPerifericos);
            this.Controls.Add(this.ptbCalculadora);
            this.Controls.Add(this.ptbFotocopiadora);
            this.Controls.Add(this.ptbContestador);
            this.Controls.Add(this.ptbFormaDePago);
            this.Controls.Add(this.ptbEquipo);
            this.Controls.Add(this.cbbFormaDePago);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblPerifericos);
            this.Controls.Add(this.ltbPeriferico);
            this.Controls.Add(this.gpbEquipoOficina);
            this.Controls.Add(this.lblCabecera);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbEquiipo);
            this.Name = "CompraInteractiva";
            this.Text = "Toñi Sanchez Maiquez";
            this.grbEquiipo.ResumeLayout(false);
            this.grbEquiipo.PerformLayout();
            this.gpbEquipoOficina.ResumeLayout(false);
            this.gpbEquipoOficina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPerifericos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCalculadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFotocopiadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbContestador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFormaDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEquiipo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.GroupBox gpbEquipoOficina;
        private System.Windows.Forms.CheckBox ckb3;
        private System.Windows.Forms.CheckBox ckb2;
        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.ListBox ltbPeriferico;
        private System.Windows.Forms.Label lblPerifericos;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cbbFormaDePago;
        private System.Windows.Forms.PictureBox ptbEquipo;
        private System.Windows.Forms.PictureBox ptbFormaDePago;
        private System.Windows.Forms.PictureBox ptbContestador;
        private System.Windows.Forms.PictureBox ptbFotocopiadora;
        private System.Windows.Forms.PictureBox ptbCalculadora;
        private System.Windows.Forms.PictureBox ptbPerifericos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Label lblObligatorio;
    }
}

