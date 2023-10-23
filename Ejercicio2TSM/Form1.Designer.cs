namespace Ejercicio2TSM
{
    partial class Ejercicio2
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
            this.lblInformativo = new System.Windows.Forms.Label();
            this.btnIntroducir = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.LtbNumeros = new System.Windows.Forms.ListBox();
            this.lblPrimo = new System.Windows.Forms.Label();
            this.txtPrimo = new System.Windows.Forms.TextBox();
            this.lblNumRepetido = new System.Windows.Forms.Label();
            this.txtNumRepe = new System.Windows.Forms.TextBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.btnAscendente = new System.Windows.Forms.Button();
            this.btnDescendente = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pnlDecorativo = new System.Windows.Forms.Panel();
            this.lblMayor = new System.Windows.Forms.Label();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.lblMenor = new System.Windows.Forms.Label();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.pnlDecorativo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformativo
            // 
            this.lblInformativo.AutoSize = true;
            this.lblInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformativo.ForeColor = System.Drawing.Color.Black;
            this.lblInformativo.Location = new System.Drawing.Point(20, 33);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(193, 20);
            this.lblInformativo.TabIndex = 0;
            this.lblInformativo.Text = "Introducir 10 numeros";
            // 
            // btnIntroducir
            // 
            this.btnIntroducir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnIntroducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntroducir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIntroducir.Location = new System.Drawing.Point(346, 22);
            this.btnIntroducir.Name = "btnIntroducir";
            this.btnIntroducir.Size = new System.Drawing.Size(102, 45);
            this.btnIntroducir.TabIndex = 1;
            this.btnIntroducir.Text = "Introducir";
            this.btnIntroducir.UseVisualStyleBackColor = false;
            this.btnIntroducir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(258, 33);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(55, 22);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LtbNumeros
            // 
            this.LtbNumeros.FormattingEnabled = true;
            this.LtbNumeros.ItemHeight = 16;
            this.LtbNumeros.Location = new System.Drawing.Point(596, 33);
            this.LtbNumeros.Name = "LtbNumeros";
            this.LtbNumeros.Size = new System.Drawing.Size(43, 164);
            this.LtbNumeros.TabIndex = 3;
            // 
            // lblPrimo
            // 
            this.lblPrimo.AutoSize = true;
            this.lblPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimo.Location = new System.Drawing.Point(20, 150);
            this.lblPrimo.Name = "lblPrimo";
            this.lblPrimo.Size = new System.Drawing.Size(293, 20);
            this.lblPrimo.TabIndex = 4;
            this.lblPrimo.Text = "¿Es primo el número introducido?";
            // 
            // txtPrimo
            // 
            this.txtPrimo.Location = new System.Drawing.Point(382, 148);
            this.txtPrimo.Name = "txtPrimo";
            this.txtPrimo.Size = new System.Drawing.Size(53, 22);
            this.txtPrimo.TabIndex = 5;
            this.txtPrimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumRepetido
            // 
            this.lblNumRepetido.AutoSize = true;
            this.lblNumRepetido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRepetido.Location = new System.Drawing.Point(20, 236);
            this.lblNumRepetido.Name = "lblNumRepetido";
            this.lblNumRepetido.Size = new System.Drawing.Size(415, 20);
            this.lblNumRepetido.TabIndex = 6;
            this.lblNumRepetido.Text = "¿Cuántas veces se ha introducido este número?";
            // 
            // txtNumRepe
            // 
            this.txtNumRepe.Location = new System.Drawing.Point(506, 236);
            this.txtNumRepe.Name = "txtNumRepe";
            this.txtNumRepe.Size = new System.Drawing.Size(53, 22);
            this.txtNumRepe.TabIndex = 7;
            this.txtNumRepe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.Location = new System.Drawing.Point(20, 295);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(275, 20);
            this.lblOrdenar.TabIndex = 8;
            this.lblOrdenar.Text = "¿Quieres ordenar los números?";
            this.lblOrdenar.Visible = false;
            // 
            // btnAscendente
            // 
            this.btnAscendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscendente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAscendente.Location = new System.Drawing.Point(344, 285);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(123, 43);
            this.btnAscendente.TabIndex = 9;
            this.btnAscendente.Text = "Ascendente";
            this.btnAscendente.UseVisualStyleBackColor = false;
            this.btnAscendente.Visible = false;
            this.btnAscendente.Click += new System.EventHandler(this.btnAscendente_Click);
            // 
            // btnDescendente
            // 
            this.btnDescendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescendente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDescendente.Location = new System.Drawing.Point(494, 285);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(123, 43);
            this.btnDescendente.TabIndex = 10;
            this.btnDescendente.Text = "Descendente";
            this.btnDescendente.UseVisualStyleBackColor = false;
            this.btnDescendente.Visible = false;
            this.btnDescendente.Click += new System.EventHandler(this.btnDescendente_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(149, 84);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(209, 17);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "El valor introducido no es valido";
            this.lblError.Visible = false;
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArray.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblArray.Location = new System.Drawing.Point(213, 344);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(0, 24);
            this.lblArray.TabIndex = 12;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(689, 320);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(90, 48);
            this.btnReiniciar.TabIndex = 13;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnlDecorativo
            // 
            this.pnlDecorativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlDecorativo.Controls.Add(this.txtMedia);
            this.pnlDecorativo.Controls.Add(this.lblMedia);
            this.pnlDecorativo.Controls.Add(this.txtMenor);
            this.pnlDecorativo.Controls.Add(this.lblMenor);
            this.pnlDecorativo.Controls.Add(this.txtMayor);
            this.pnlDecorativo.Controls.Add(this.lblMayor);
            this.pnlDecorativo.Controls.Add(this.lblInformativo);
            this.pnlDecorativo.Controls.Add(this.btnReiniciar);
            this.pnlDecorativo.Controls.Add(this.btnIntroducir);
            this.pnlDecorativo.Controls.Add(this.lblArray);
            this.pnlDecorativo.Controls.Add(this.txtNum);
            this.pnlDecorativo.Controls.Add(this.lblError);
            this.pnlDecorativo.Controls.Add(this.LtbNumeros);
            this.pnlDecorativo.Controls.Add(this.btnDescendente);
            this.pnlDecorativo.Controls.Add(this.lblPrimo);
            this.pnlDecorativo.Controls.Add(this.btnAscendente);
            this.pnlDecorativo.Controls.Add(this.txtPrimo);
            this.pnlDecorativo.Controls.Add(this.lblOrdenar);
            this.pnlDecorativo.Controls.Add(this.lblNumRepetido);
            this.pnlDecorativo.Controls.Add(this.txtNumRepe);
            this.pnlDecorativo.Location = new System.Drawing.Point(33, 25);
            this.pnlDecorativo.Name = "pnlDecorativo";
            this.pnlDecorativo.Size = new System.Drawing.Size(804, 456);
            this.pnlDecorativo.TabIndex = 14;
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayor.Location = new System.Drawing.Point(53, 403);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(54, 16);
            this.lblMayor.TabIndex = 14;
            this.lblMayor.Text = "Mayor:";
            this.lblMayor.Visible = false;
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(132, 400);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(58, 22);
            this.txtMayor.TabIndex = 15;
            this.txtMayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMayor.Visible = false;
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(230, 403);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(54, 16);
            this.lblMenor.TabIndex = 16;
            this.lblMenor.Text = "Menor:";
            this.lblMenor.Visible = false;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(313, 400);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(58, 22);
            this.txtMenor.TabIndex = 17;
            this.txtMenor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMenor.Visible = false;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(413, 403);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(54, 16);
            this.lblMedia.TabIndex = 18;
            this.lblMedia.Text = "Media:";
            this.lblMedia.Visible = false;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(484, 397);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(58, 22);
            this.txtMedia.TabIndex = 19;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMedia.Visible = false;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(879, 517);
            this.Controls.Add(this.pnlDecorativo);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2 Toñi Sanchez Maiquez";
            this.pnlDecorativo.ResumeLayout(false);
            this.pnlDecorativo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.Button btnIntroducir;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox LtbNumeros;
        private System.Windows.Forms.Label lblPrimo;
        private System.Windows.Forms.TextBox txtPrimo;
        private System.Windows.Forms.Label lblNumRepetido;
        private System.Windows.Forms.TextBox txtNumRepe;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Button btnAscendente;
        private System.Windows.Forms.Button btnDescendente;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Panel pnlDecorativo;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtMenor;
    }
}

