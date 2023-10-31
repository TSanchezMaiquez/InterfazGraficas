namespace EjercicioClases
{
    partial class Form1
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
            this.grbAltas = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblcódigo = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblCategoriaError = new System.Windows.Forms.Label();
            this.lblExistError = new System.Windows.Forms.Label();
            this.lblPrecioError = new System.Windows.Forms.Label();
            this.lblNombreError = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAltas = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.grbConsultas = new System.Windows.Forms.GroupBox();
            this.btnElimArt = new System.Windows.Forms.Button();
            this.lblElimArt = new System.Windows.Forms.Label();
            this.lblInfoElim = new System.Windows.Forms.Label();
            this.lblConError = new System.Windows.Forms.Label();
            this.rtbConsultas = new System.Windows.Forms.RichTextBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.txtConsultas = new System.Windows.Forms.TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mínimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grbPedido = new System.Windows.Forms.GroupBox();
            this.lblPedRealizado = new System.Windows.Forms.Label();
            this.lblCodNoExiste = new System.Windows.Forms.Label();
            this.bntStock = new System.Windows.Forms.Button();
            this.txtCantPed = new System.Windows.Forms.TextBox();
            this.lblCanPed = new System.Windows.Forms.Label();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.lblcodPed = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.grbListado = new System.Windows.Forms.GroupBox();
            this.cbbListado = new System.Windows.Forms.ComboBox();
            this.lblCatList = new System.Windows.Forms.Label();
            this.lblTipoListado = new System.Windows.Forms.Label();
            this.rtbListado = new System.Windows.Forms.RichTextBox();
            this.lblListado = new System.Windows.Forms.Label();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCodAct = new System.Windows.Forms.Label();
            this.txtcodAct = new System.Windows.Forms.TextBox();
            this.btnActArt = new System.Windows.Forms.Button();
            this.grbAltas.SuspendLayout();
            this.grbConsultas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grbPedido.SuspendLayout();
            this.grbListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAltas
            // 
            this.grbAltas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.grbAltas.Controls.Add(this.btnActArt);
            this.grbAltas.Controls.Add(this.txtcodAct);
            this.grbAltas.Controls.Add(this.lblCodAct);
            this.grbAltas.Controls.Add(this.txtCodigo);
            this.grbAltas.Controls.Add(this.lblcódigo);
            this.grbAltas.Controls.Add(this.lblRegistro);
            this.grbAltas.Controls.Add(this.lblCategoriaError);
            this.grbAltas.Controls.Add(this.lblExistError);
            this.grbAltas.Controls.Add(this.lblPrecioError);
            this.grbAltas.Controls.Add(this.lblNombreError);
            this.grbAltas.Controls.Add(this.btnCancelar);
            this.grbAltas.Controls.Add(this.btnAceptar);
            this.grbAltas.Controls.Add(this.lblAltas);
            this.grbAltas.Controls.Add(this.txtExistencias);
            this.grbAltas.Controls.Add(this.lblExistencias);
            this.grbAltas.Controls.Add(this.txtPrecio);
            this.grbAltas.Controls.Add(this.lblPrecio);
            this.grbAltas.Controls.Add(this.lblCategoria);
            this.grbAltas.Controls.Add(this.txtNombre);
            this.grbAltas.Controls.Add(this.lblNombre);
            this.grbAltas.Controls.Add(this.cbbCategoria);
            this.grbAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAltas.Location = new System.Drawing.Point(149, 115);
            this.grbAltas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAltas.Name = "grbAltas";
            this.grbAltas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbAltas.Size = new System.Drawing.Size(707, 452);
            this.grbAltas.TabIndex = 0;
            this.grbAltas.TabStop = false;
            this.grbAltas.Text = "Altas";
            this.grbAltas.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(319, 177);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(128, 23);
            this.txtCodigo.TabIndex = 17;
            // 
            // lblcódigo
            // 
            this.lblcódigo.AutoSize = true;
            this.lblcódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcódigo.Location = new System.Drawing.Point(197, 177);
            this.lblcódigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcódigo.Name = "lblcódigo";
            this.lblcódigo.Size = new System.Drawing.Size(67, 20);
            this.lblcódigo.TabIndex = 16;
            this.lblcódigo.Text = "Código";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.Olive;
            this.lblRegistro.Location = new System.Drawing.Point(198, 404);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(146, 18);
            this.lblRegistro.TabIndex = 15;
            this.lblRegistro.Text = "Registro realizado";
            this.lblRegistro.Visible = false;
            // 
            // lblCategoriaError
            // 
            this.lblCategoriaError.AutoSize = true;
            this.lblCategoriaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaError.ForeColor = System.Drawing.Color.Red;
            this.lblCategoriaError.Location = new System.Drawing.Point(465, 269);
            this.lblCategoriaError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaError.Name = "lblCategoriaError";
            this.lblCategoriaError.Size = new System.Drawing.Size(142, 17);
            this.lblCategoriaError.TabIndex = 14;
            this.lblCategoriaError.Text = "Debes seleccionar";
            this.lblCategoriaError.Visible = false;
            // 
            // lblExistError
            // 
            this.lblExistError.AutoSize = true;
            this.lblExistError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistError.ForeColor = System.Drawing.Color.Red;
            this.lblExistError.Location = new System.Drawing.Point(465, 348);
            this.lblExistError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExistError.Name = "lblExistError";
            this.lblExistError.Size = new System.Drawing.Size(76, 17);
            this.lblExistError.TabIndex = 13;
            this.lblExistError.Text = "No valido";
            this.lblExistError.Visible = false;
            // 
            // lblPrecioError
            // 
            this.lblPrecioError.AutoSize = true;
            this.lblPrecioError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioError.ForeColor = System.Drawing.Color.Red;
            this.lblPrecioError.Location = new System.Drawing.Point(465, 311);
            this.lblPrecioError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioError.Name = "lblPrecioError";
            this.lblPrecioError.Size = new System.Drawing.Size(76, 17);
            this.lblPrecioError.TabIndex = 12;
            this.lblPrecioError.Text = "No valido";
            this.lblPrecioError.Visible = false;
            // 
            // lblNombreError
            // 
            this.lblNombreError.AutoSize = true;
            this.lblNombreError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreError.ForeColor = System.Drawing.Color.Red;
            this.lblNombreError.Location = new System.Drawing.Point(465, 223);
            this.lblNombreError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreError.Name = "lblNombreError";
            this.lblNombreError.Size = new System.Drawing.Size(76, 17);
            this.lblNombreError.TabIndex = 11;
            this.lblNombreError.Text = "No valido";
            this.lblNombreError.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(467, 400);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Reiniciar campos";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(381, 400);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(67, 29);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAltas
            // 
            this.lblAltas.AutoSize = true;
            this.lblAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltas.Location = new System.Drawing.Point(316, 126);
            this.lblAltas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltas.Name = "lblAltas";
            this.lblAltas.Size = new System.Drawing.Size(66, 26);
            this.lblAltas.TabIndex = 8;
            this.lblAltas.Text = "Altas";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(317, 348);
            this.txtExistencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(132, 23);
            this.txtExistencias.TabIndex = 7;
            this.txtExistencias.Text = "Ni nº negativos ni 0";
            this.txtExistencias.Click += new System.EventHandler(this.textBoxReinicio_Click);
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencias.Location = new System.Drawing.Point(197, 348);
            this.lblExistencias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(106, 20);
            this.lblExistencias.TabIndex = 6;
            this.lblExistencias.Text = "Existencias";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(320, 307);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 23);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "2 decimales y coma";
            this.txtPrecio.Click += new System.EventHandler(this.textBoxReinicio_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(197, 307);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(63, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(197, 264);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(90, 20);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(320, 223);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Minimo 3 carácteres";
            this.txtNombre.Click += new System.EventHandler(this.textBoxReinicio_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(197, 223);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(143, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre artículo";
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Items.AddRange(new object[] {
            "Informática",
            "Imagen",
            "Telefonía",
            "Sonido"});
            this.cbbCategoria.Location = new System.Drawing.Point(320, 264);
            this.cbbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(128, 24);
            this.cbbCategoria.TabIndex = 0;
            // 
            // grbConsultas
            // 
            this.grbConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.grbConsultas.Controls.Add(this.btnElimArt);
            this.grbConsultas.Controls.Add(this.lblElimArt);
            this.grbConsultas.Controls.Add(this.lblInfoElim);
            this.grbConsultas.Controls.Add(this.lblConError);
            this.grbConsultas.Controls.Add(this.rtbConsultas);
            this.grbConsultas.Controls.Add(this.btnConsultas);
            this.grbConsultas.Controls.Add(this.txtConsultas);
            this.grbConsultas.Controls.Add(this.lblCon);
            this.grbConsultas.Controls.Add(this.lblConsultas);
            this.grbConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConsultas.Location = new System.Drawing.Point(233, 92);
            this.grbConsultas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbConsultas.Name = "grbConsultas";
            this.grbConsultas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbConsultas.Size = new System.Drawing.Size(619, 432);
            this.grbConsultas.TabIndex = 18;
            this.grbConsultas.TabStop = false;
            this.grbConsultas.Text = "Consultas";
            this.grbConsultas.Visible = false;
            // 
            // btnElimArt
            // 
            this.btnElimArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnElimArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimArt.Location = new System.Drawing.Point(464, 375);
            this.btnElimArt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElimArt.Name = "btnElimArt";
            this.btnElimArt.Size = new System.Drawing.Size(98, 37);
            this.btnElimArt.TabIndex = 27;
            this.btnElimArt.Text = "Eliminar";
            this.btnElimArt.UseVisualStyleBackColor = false;
            this.btnElimArt.Visible = false;
            this.btnElimArt.Click += new System.EventHandler(this.btnElimArt_Click);
            // 
            // lblElimArt
            // 
            this.lblElimArt.AutoSize = true;
            this.lblElimArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimArt.Location = new System.Drawing.Point(64, 384);
            this.lblElimArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElimArt.Name = "lblElimArt";
            this.lblElimArt.Size = new System.Drawing.Size(373, 20);
            this.lblElimArt.TabIndex = 26;
            this.lblElimArt.Text = "El artículo consultado puede ser eliminado ";
            this.lblElimArt.Visible = false;
            // 
            // lblInfoElim
            // 
            this.lblInfoElim.AutoSize = true;
            this.lblInfoElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoElim.Location = new System.Drawing.Point(194, 76);
            this.lblInfoElim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoElim.Name = "lblInfoElim";
            this.lblInfoElim.Size = new System.Drawing.Size(213, 20);
            this.lblInfoElim.TabIndex = 25;
            this.lblInfoElim.Text = "Solo artículos sin stock ";
            this.lblInfoElim.Visible = false;
            // 
            // lblConError
            // 
            this.lblConError.AutoSize = true;
            this.lblConError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConError.ForeColor = System.Drawing.Color.Red;
            this.lblConError.Location = new System.Drawing.Point(218, 158);
            this.lblConError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConError.Name = "lblConError";
            this.lblConError.Size = new System.Drawing.Size(129, 17);
            this.lblConError.TabIndex = 24;
            this.lblConError.Text = "Código no valido";
            this.lblConError.Visible = false;
            // 
            // rtbConsultas
            // 
            this.rtbConsultas.Location = new System.Drawing.Point(113, 190);
            this.rtbConsultas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbConsultas.Name = "rtbConsultas";
            this.rtbConsultas.Size = new System.Drawing.Size(378, 163);
            this.rtbConsultas.TabIndex = 23;
            this.rtbConsultas.Text = "";
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(349, 111);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(119, 45);
            this.btnConsultas.TabIndex = 22;
            this.btnConsultas.Text = "Buscar artículo";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // txtConsultas
            // 
            this.txtConsultas.Location = new System.Drawing.Point(207, 124);
            this.txtConsultas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConsultas.Name = "txtConsultas";
            this.txtConsultas.Size = new System.Drawing.Size(128, 23);
            this.txtConsultas.TabIndex = 19;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(131, 124);
            this.lblCon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(74, 20);
            this.lblCon.TabIndex = 18;
            this.lblCon.Text = "Nombre";
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(238, 44);
            this.lblConsultas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(118, 26);
            this.lblConsultas.TabIndex = 9;
            this.lblConsultas.Text = "Consultas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1162, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.artículosToolStripMenuItem.Text = "&Artículos";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altasToolStripMenuItem.Text = "&Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pedidosToolStripMenuItem.Text = "&Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(221, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem1.Text = "&Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porCodigoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porNombreToolStripMenuItem.Text = "Por &Nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // porCodigoToolStripMenuItem
            // 
            this.porCodigoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.porCodigoToolStripMenuItem.Name = "porCodigoToolStripMenuItem";
            this.porCodigoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porCodigoToolStripMenuItem.Text = "Por &Codigo";
            this.porCodigoToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mínimosToolStripMenuItem,
            this.porCategoríaToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.listadosToolStripMenuItem.Text = "&Listados";
            // 
            // mínimosToolStripMenuItem
            // 
            this.mínimosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mínimosToolStripMenuItem.Name = "mínimosToolStripMenuItem";
            this.mínimosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mínimosToolStripMenuItem.Text = "&Mínimos";
            this.mínimosToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // porCategoríaToolStripMenuItem
            // 
            this.porCategoríaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.porCategoríaToolStripMenuItem.Name = "porCategoríaToolStripMenuItem";
            this.porCategoríaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.porCategoríaToolStripMenuItem.Text = "Por &Categoría";
            this.porCategoríaToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.todosToolStripMenuItem.Text = "&Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.autorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem1});
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.autorToolStripMenuItem.Text = "Acerca &de";
            // 
            // autorToolStripMenuItem1
            // 
            this.autorToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.autorToolStripMenuItem1.Name = "autorToolStripMenuItem1";
            this.autorToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.autorToolStripMenuItem1.Text = "Autor";
            this.autorToolStripMenuItem1.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // grbPedido
            // 
            this.grbPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.grbPedido.Controls.Add(this.lblPedRealizado);
            this.grbPedido.Controls.Add(this.lblCodNoExiste);
            this.grbPedido.Controls.Add(this.bntStock);
            this.grbPedido.Controls.Add(this.txtCantPed);
            this.grbPedido.Controls.Add(this.lblCanPed);
            this.grbPedido.Controls.Add(this.txtCodPed);
            this.grbPedido.Controls.Add(this.lblcodPed);
            this.grbPedido.Controls.Add(this.lblPedido);
            this.grbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPedido.Location = new System.Drawing.Point(184, 97);
            this.grbPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPedido.Name = "grbPedido";
            this.grbPedido.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPedido.Size = new System.Drawing.Size(554, 399);
            this.grbPedido.TabIndex = 2;
            this.grbPedido.TabStop = false;
            this.grbPedido.Text = "Pedidos";
            this.grbPedido.Visible = false;
            // 
            // lblPedRealizado
            // 
            this.lblPedRealizado.AutoSize = true;
            this.lblPedRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedRealizado.ForeColor = System.Drawing.Color.Olive;
            this.lblPedRealizado.Location = new System.Drawing.Point(139, 278);
            this.lblPedRealizado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedRealizado.Name = "lblPedRealizado";
            this.lblPedRealizado.Size = new System.Drawing.Size(208, 18);
            this.lblPedRealizado.TabIndex = 24;
            this.lblPedRealizado.Text = "Pedido realizado con exito";
            this.lblPedRealizado.Visible = false;
            // 
            // lblCodNoExiste
            // 
            this.lblCodNoExiste.AutoSize = true;
            this.lblCodNoExiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodNoExiste.ForeColor = System.Drawing.Color.Red;
            this.lblCodNoExiste.Location = new System.Drawing.Point(139, 308);
            this.lblCodNoExiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodNoExiste.Name = "lblCodNoExiste";
            this.lblCodNoExiste.Size = new System.Drawing.Size(218, 17);
            this.lblCodNoExiste.TabIndex = 23;
            this.lblCodNoExiste.Text = "Codigo o cantidad no validos";
            this.lblCodNoExiste.Visible = false;
            // 
            // bntStock
            // 
            this.bntStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bntStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntStock.Location = new System.Drawing.Point(318, 191);
            this.bntStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntStock.Name = "bntStock";
            this.bntStock.Size = new System.Drawing.Size(139, 59);
            this.bntStock.TabIndex = 21;
            this.bntStock.Text = "Comprobar Stock";
            this.bntStock.UseVisualStyleBackColor = false;
            this.bntStock.Click += new System.EventHandler(this.bntStock_Click);
            // 
            // txtCantPed
            // 
            this.txtCantPed.Location = new System.Drawing.Point(141, 235);
            this.txtCantPed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantPed.Name = "txtCantPed";
            this.txtCantPed.Size = new System.Drawing.Size(128, 23);
            this.txtCantPed.TabIndex = 20;
            // 
            // lblCanPed
            // 
            this.lblCanPed.AutoSize = true;
            this.lblCanPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanPed.Location = new System.Drawing.Point(63, 236);
            this.lblCanPed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanPed.Name = "lblCanPed";
            this.lblCanPed.Size = new System.Drawing.Size(83, 20);
            this.lblCanPed.TabIndex = 19;
            this.lblCanPed.Text = "Cantidad";
            // 
            // txtCodPed
            // 
            this.txtCodPed.Location = new System.Drawing.Point(141, 185);
            this.txtCodPed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(128, 23);
            this.txtCodPed.TabIndex = 18;
            // 
            // lblcodPed
            // 
            this.lblcodPed.AutoSize = true;
            this.lblcodPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodPed.Location = new System.Drawing.Point(63, 187);
            this.lblcodPed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodPed.Name = "lblcodPed";
            this.lblcodPed.Size = new System.Drawing.Size(67, 20);
            this.lblcodPed.TabIndex = 17;
            this.lblcodPed.Text = "Código";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(166, 125);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(98, 26);
            this.lblPedido.TabIndex = 9;
            this.lblPedido.Text = "Pedidos";
            // 
            // grbListado
            // 
            this.grbListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.grbListado.Controls.Add(this.cbbListado);
            this.grbListado.Controls.Add(this.lblCatList);
            this.grbListado.Controls.Add(this.lblTipoListado);
            this.grbListado.Controls.Add(this.rtbListado);
            this.grbListado.Controls.Add(this.lblListado);
            this.grbListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListado.Location = new System.Drawing.Point(301, 79);
            this.grbListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbListado.Name = "grbListado";
            this.grbListado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbListado.Size = new System.Drawing.Size(555, 417);
            this.grbListado.TabIndex = 18;
            this.grbListado.TabStop = false;
            this.grbListado.Text = "Listado";
            this.grbListado.Visible = false;
            // 
            // cbbListado
            // 
            this.cbbListado.FormattingEnabled = true;
            this.cbbListado.Items.AddRange(new object[] {
            "Informática",
            "Imagen",
            "Telefonía",
            "Sonido"});
            this.cbbListado.Location = new System.Drawing.Point(238, 129);
            this.cbbListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbListado.Name = "cbbListado";
            this.cbbListado.Size = new System.Drawing.Size(128, 24);
            this.cbbListado.TabIndex = 27;
            this.cbbListado.Text = "Selecciona una";
            this.cbbListado.Visible = false;
            this.cbbListado.SelectedIndexChanged += new System.EventHandler(this.cbbListado_SelectedIndexChanged);
            // 
            // lblCatList
            // 
            this.lblCatList.AutoSize = true;
            this.lblCatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatList.Location = new System.Drawing.Point(148, 129);
            this.lblCatList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatList.Name = "lblCatList";
            this.lblCatList.Size = new System.Drawing.Size(90, 20);
            this.lblCatList.TabIndex = 26;
            this.lblCatList.Text = "Categoría";
            this.lblCatList.Visible = false;
            // 
            // lblTipoListado
            // 
            this.lblTipoListado.AutoSize = true;
            this.lblTipoListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoListado.Location = new System.Drawing.Point(240, 78);
            this.lblTipoListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoListado.Name = "lblTipoListado";
            this.lblTipoListado.Size = new System.Drawing.Size(24, 26);
            this.lblTipoListado.TabIndex = 25;
            this.lblTipoListado.Text = "x";
            // 
            // rtbListado
            // 
            this.rtbListado.Location = new System.Drawing.Point(53, 171);
            this.rtbListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbListado.Name = "rtbListado";
            this.rtbListado.Size = new System.Drawing.Size(449, 213);
            this.rtbListado.TabIndex = 24;
            this.rtbListado.Text = "";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(164, 78);
            this.lblListado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(78, 26);
            this.lblListado.TabIndex = 9;
            this.lblListado.Text = "Listar:";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // lblCodAct
            // 
            this.lblCodAct.AutoSize = true;
            this.lblCodAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAct.Location = new System.Drawing.Point(143, 70);
            this.lblCodAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodAct.Name = "lblCodAct";
            this.lblCodAct.Size = new System.Drawing.Size(241, 20);
            this.lblCodAct.TabIndex = 18;
            this.lblCodAct.Text = "Código artículo a actualizar";
            this.lblCodAct.Visible = false;
            // 
            // txtcodAct
            // 
            this.txtcodAct.Location = new System.Drawing.Point(398, 70);
            this.txtcodAct.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodAct.Name = "txtcodAct";
            this.txtcodAct.Size = new System.Drawing.Size(128, 23);
            this.txtcodAct.TabIndex = 19;
            this.txtcodAct.Visible = false;
            // 
            // btnActArt
            // 
            this.btnActArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnActArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActArt.Location = new System.Drawing.Point(567, 67);
            this.btnActArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnActArt.Name = "btnActArt";
            this.btnActArt.Size = new System.Drawing.Size(67, 29);
            this.btnActArt.TabIndex = 20;
            this.btnActArt.Text = "Buscar";
            this.btnActArt.UseVisualStyleBackColor = false;
            this.btnActArt.Visible = false;
            this.btnActArt.Click += new System.EventHandler(this.btnActArt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1162, 655);
            this.Controls.Add(this.grbAltas);
            this.Controls.Add(this.grbConsultas);
            this.Controls.Add(this.grbPedido);
            this.Controls.Add(this.grbListado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Toñi Sanchez Maiquez";
            this.grbAltas.ResumeLayout(false);
            this.grbAltas.PerformLayout();
            this.grbConsultas.ResumeLayout(false);
            this.grbConsultas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbPedido.ResumeLayout(false);
            this.grbPedido.PerformLayout();
            this.grbListado.ResumeLayout(false);
            this.grbListado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAltas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mínimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAltas;
        private System.Windows.Forms.Label lblPrecioError;
        private System.Windows.Forms.Label lblNombreError;
        private System.Windows.Forms.Label lblExistError;
        private System.Windows.Forms.Label lblCategoriaError;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblcódigo;
        private System.Windows.Forms.GroupBox grbPedido;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.Label lblcodPed;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button bntStock;
        private System.Windows.Forms.TextBox txtCantPed;
        private System.Windows.Forms.Label lblCanPed;
        private System.Windows.Forms.Label lblCodNoExiste;
        private System.Windows.Forms.Label lblPedRealizado;
        private System.Windows.Forms.GroupBox grbConsultas;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.TextBox txtConsultas;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.RichTextBox rtbConsultas;
        private System.Windows.Forms.Label lblConError;
        private System.Windows.Forms.GroupBox grbListado;
        private System.Windows.Forms.RichTextBox rtbListado;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Label lblTipoListado;
        private System.Windows.Forms.Label lblCatList;
        private System.Windows.Forms.ComboBox cbbListado;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label lblInfoElim;
        private System.Windows.Forms.Button btnElimArt;
        private System.Windows.Forms.Label lblElimArt;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.Label lblCodAct;
        private System.Windows.Forms.TextBox txtcodAct;
        private System.Windows.Forms.Button btnActArt;
    }
}

