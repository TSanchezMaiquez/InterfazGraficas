namespace archivosTextoTSM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarAgendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarAgendaPorInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerAgendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerAgendaPorInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbAltas = new System.Windows.Forms.GroupBox();
            this.lblAltasCreacion = new System.Windows.Forms.Label();
            this.lblAltasError = new System.Windows.Forms.Label();
            this.btnAltasBorrar = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.rtbConsultas = new System.Windows.Forms.RichTextBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.txtNombreConsultas = new System.Windows.Forms.TextBox();
            this.lblNombreConsultas = new System.Windows.Forms.Label();
            this.grbGuardar = new System.Windows.Forms.GroupBox();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbGuardarPorInicial = new System.Windows.Forms.GroupBox();
            this.btnGuardarGuardarI = new System.Windows.Forms.Button();
            this.rtbGuardar = new System.Windows.Forms.RichTextBox();
            this.btnBuscarGuardarI = new System.Windows.Forms.Button();
            this.txtGuardarI = new System.Windows.Forms.TextBox();
            this.lblNombreGuardarI = new System.Windows.Forms.Label();
            this.grbLectura = new System.Windows.Forms.GroupBox();
            this.rtbLectura = new System.Windows.Forms.RichTextBox();
            this.eliminarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbEliminar = new System.Windows.Forms.GroupBox();
            this.btnBuscarElim = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.lblNomElim = new System.Windows.Forms.Label();
            this.ltbEliminar = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbAltas.SuspendLayout();
            this.grbConsulta.SuspendLayout();
            this.grbGuardar.SuspendLayout();
            this.grbGuardarPorInicial.SuspendLayout();
            this.grbLectura.SuspendLayout();
            this.grbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.guardarAgendaToolStripMenuItem,
            this.guardarAgendaPorInicialToolStripMenuItem,
            this.leerAgendaToolStripMenuItem,
            this.leerAgendaPorInicialToolStripMenuItem,
            this.eliminarContactoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1511, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // guardarAgendaToolStripMenuItem
            // 
            this.guardarAgendaToolStripMenuItem.Name = "guardarAgendaToolStripMenuItem";
            this.guardarAgendaToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.guardarAgendaToolStripMenuItem.Text = "Guardar agenda";
            this.guardarAgendaToolStripMenuItem.Click += new System.EventHandler(this.guardarAgendaToolStripMenuItem_Click);
            // 
            // guardarAgendaPorInicialToolStripMenuItem
            // 
            this.guardarAgendaPorInicialToolStripMenuItem.Name = "guardarAgendaPorInicialToolStripMenuItem";
            this.guardarAgendaPorInicialToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.guardarAgendaPorInicialToolStripMenuItem.Text = "Guardar agenda por inicial";
            this.guardarAgendaPorInicialToolStripMenuItem.Click += new System.EventHandler(this.guardarAgendaPorInicialToolStripMenuItem_Click);
            // 
            // leerAgendaToolStripMenuItem
            // 
            this.leerAgendaToolStripMenuItem.Name = "leerAgendaToolStripMenuItem";
            this.leerAgendaToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.leerAgendaToolStripMenuItem.Text = "Leer agenda";
            this.leerAgendaToolStripMenuItem.Click += new System.EventHandler(this.leerAgendaToolStripMenuItem_Click);
            // 
            // leerAgendaPorInicialToolStripMenuItem
            // 
            this.leerAgendaPorInicialToolStripMenuItem.Name = "leerAgendaPorInicialToolStripMenuItem";
            this.leerAgendaPorInicialToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.leerAgendaPorInicialToolStripMenuItem.Text = "Leer agenda por inicial";
            this.leerAgendaPorInicialToolStripMenuItem.Click += new System.EventHandler(this.leerAgendaToolStripMenuItem_Click);
            // 
            // grbAltas
            // 
            this.grbAltas.Controls.Add(this.lblAltasCreacion);
            this.grbAltas.Controls.Add(this.lblAltasError);
            this.grbAltas.Controls.Add(this.btnAltasBorrar);
            this.grbAltas.Controls.Add(this.btnAltas);
            this.grbAltas.Controls.Add(this.txtName);
            this.grbAltas.Controls.Add(this.lblName);
            this.grbAltas.Controls.Add(this.txtPhone);
            this.grbAltas.Controls.Add(this.lblPhone);
            this.grbAltas.Controls.Add(this.txtId);
            this.grbAltas.Controls.Add(this.lblId);
            this.grbAltas.Location = new System.Drawing.Point(12, 60);
            this.grbAltas.Name = "grbAltas";
            this.grbAltas.Size = new System.Drawing.Size(408, 264);
            this.grbAltas.TabIndex = 1;
            this.grbAltas.TabStop = false;
            this.grbAltas.Visible = false;
            // 
            // lblAltasCreacion
            // 
            this.lblAltasCreacion.AutoSize = true;
            this.lblAltasCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltasCreacion.Location = new System.Drawing.Point(59, 220);
            this.lblAltasCreacion.Name = "lblAltasCreacion";
            this.lblAltasCreacion.Size = new System.Drawing.Size(243, 18);
            this.lblAltasCreacion.TabIndex = 9;
            this.lblAltasCreacion.Text = "Registro creado correctamente";
            this.lblAltasCreacion.Visible = false;
            // 
            // lblAltasError
            // 
            this.lblAltasError.AutoSize = true;
            this.lblAltasError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltasError.ForeColor = System.Drawing.Color.Red;
            this.lblAltasError.Location = new System.Drawing.Point(125, 183);
            this.lblAltasError.Name = "lblAltasError";
            this.lblAltasError.Size = new System.Drawing.Size(124, 18);
            this.lblAltasError.TabIndex = 8;
            this.lblAltasError.Text = "Datos invalidos";
            this.lblAltasError.Visible = false;
            // 
            // btnAltasBorrar
            // 
            this.btnAltasBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltasBorrar.Location = new System.Drawing.Point(304, 125);
            this.btnAltasBorrar.Name = "btnAltasBorrar";
            this.btnAltasBorrar.Size = new System.Drawing.Size(80, 35);
            this.btnAltasBorrar.TabIndex = 7;
            this.btnAltasBorrar.Text = "Borrar";
            this.btnAltasBorrar.UseVisualStyleBackColor = true;
            this.btnAltasBorrar.Click += new System.EventHandler(this.btnAltasBorrar_Click);
            // 
            // btnAltas
            // 
            this.btnAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.Location = new System.Drawing.Point(304, 54);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(80, 35);
            this.btnAltas.TabIndex = 6;
            this.btnAltas.Text = "Alta";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(32, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 18);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 138);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(32, 138);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 18);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefono";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(32, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.rtbConsultas);
            this.grbConsulta.Controls.Add(this.btnConsultas);
            this.grbConsulta.Controls.Add(this.txtNombreConsultas);
            this.grbConsulta.Controls.Add(this.lblNombreConsultas);
            this.grbConsulta.Location = new System.Drawing.Point(427, 60);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(361, 334);
            this.grbConsulta.TabIndex = 2;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Visible = false;
            // 
            // rtbConsultas
            // 
            this.rtbConsultas.Location = new System.Drawing.Point(53, 86);
            this.rtbConsultas.Name = "rtbConsultas";
            this.rtbConsultas.Size = new System.Drawing.Size(222, 220);
            this.rtbConsultas.TabIndex = 8;
            this.rtbConsultas.Text = "";
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(255, 29);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(80, 35);
            this.btnConsultas.TabIndex = 7;
            this.btnConsultas.Text = "Buscar";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // txtNombreConsultas
            // 
            this.txtNombreConsultas.Location = new System.Drawing.Point(131, 35);
            this.txtNombreConsultas.Name = "txtNombreConsultas";
            this.txtNombreConsultas.Size = new System.Drawing.Size(100, 22);
            this.txtNombreConsultas.TabIndex = 5;
            // 
            // lblNombreConsultas
            // 
            this.lblNombreConsultas.AutoSize = true;
            this.lblNombreConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreConsultas.Location = new System.Drawing.Point(24, 35);
            this.lblNombreConsultas.Name = "lblNombreConsultas";
            this.lblNombreConsultas.Size = new System.Drawing.Size(68, 18);
            this.lblNombreConsultas.TabIndex = 6;
            this.lblNombreConsultas.Text = "Nombre";
            // 
            // grbGuardar
            // 
            this.grbGuardar.Controls.Add(this.lblGuardar);
            this.grbGuardar.Controls.Add(this.btnGuardar);
            this.grbGuardar.Location = new System.Drawing.Point(437, 414);
            this.grbGuardar.Name = "grbGuardar";
            this.grbGuardar.Size = new System.Drawing.Size(366, 198);
            this.grbGuardar.TabIndex = 3;
            this.grbGuardar.TabStop = false;
            this.grbGuardar.Visible = false;
            // 
            // lblGuardar
            // 
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardar.Location = new System.Drawing.Point(32, 36);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(293, 18);
            this.lblGuardar.TabIndex = 9;
            this.lblGuardar.Text = "Guardar totos los registros en fichero";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(139, 94);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 40);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grbGuardarPorInicial
            // 
            this.grbGuardarPorInicial.Controls.Add(this.btnGuardarGuardarI);
            this.grbGuardarPorInicial.Controls.Add(this.rtbGuardar);
            this.grbGuardarPorInicial.Controls.Add(this.btnBuscarGuardarI);
            this.grbGuardarPorInicial.Controls.Add(this.txtGuardarI);
            this.grbGuardarPorInicial.Controls.Add(this.lblNombreGuardarI);
            this.grbGuardarPorInicial.Location = new System.Drawing.Point(0, 330);
            this.grbGuardarPorInicial.Name = "grbGuardarPorInicial";
            this.grbGuardarPorInicial.Size = new System.Drawing.Size(421, 357);
            this.grbGuardarPorInicial.TabIndex = 4;
            this.grbGuardarPorInicial.TabStop = false;
            this.grbGuardarPorInicial.Visible = false;
            // 
            // btnGuardarGuardarI
            // 
            this.btnGuardarGuardarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGuardarI.Location = new System.Drawing.Point(140, 305);
            this.btnGuardarGuardarI.Name = "btnGuardarGuardarI";
            this.btnGuardarGuardarI.Size = new System.Drawing.Size(80, 35);
            this.btnGuardarGuardarI.TabIndex = 11;
            this.btnGuardarGuardarI.Text = "Guardar";
            this.btnGuardarGuardarI.UseVisualStyleBackColor = true;
            this.btnGuardarGuardarI.Visible = false;
            this.btnGuardarGuardarI.Click += new System.EventHandler(this.btnGuardarGuardarI_Click);
            // 
            // rtbGuardar
            // 
            this.rtbGuardar.Location = new System.Drawing.Point(47, 81);
            this.rtbGuardar.Name = "rtbGuardar";
            this.rtbGuardar.Size = new System.Drawing.Size(302, 201);
            this.rtbGuardar.TabIndex = 10;
            this.rtbGuardar.Text = "";
            // 
            // btnBuscarGuardarI
            // 
            this.btnBuscarGuardarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarGuardarI.Location = new System.Drawing.Point(269, 40);
            this.btnBuscarGuardarI.Name = "btnBuscarGuardarI";
            this.btnBuscarGuardarI.Size = new System.Drawing.Size(80, 35);
            this.btnBuscarGuardarI.TabIndex = 9;
            this.btnBuscarGuardarI.Text = "Buscar";
            this.btnBuscarGuardarI.UseVisualStyleBackColor = true;
            this.btnBuscarGuardarI.Click += new System.EventHandler(this.btnBuscarGuardarI_Click);
            // 
            // txtGuardarI
            // 
            this.txtGuardarI.Location = new System.Drawing.Point(126, 46);
            this.txtGuardarI.Name = "txtGuardarI";
            this.txtGuardarI.Size = new System.Drawing.Size(100, 22);
            this.txtGuardarI.TabIndex = 8;
            // 
            // lblNombreGuardarI
            // 
            this.lblNombreGuardarI.AutoSize = true;
            this.lblNombreGuardarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGuardarI.Location = new System.Drawing.Point(44, 46);
            this.lblNombreGuardarI.Name = "lblNombreGuardarI";
            this.lblNombreGuardarI.Size = new System.Drawing.Size(51, 18);
            this.lblNombreGuardarI.TabIndex = 7;
            this.lblNombreGuardarI.Text = "Inicial";
            // 
            // grbLectura
            // 
            this.grbLectura.Controls.Add(this.rtbLectura);
            this.grbLectura.Location = new System.Drawing.Point(796, 60);
            this.grbLectura.Name = "grbLectura";
            this.grbLectura.Size = new System.Drawing.Size(315, 348);
            this.grbLectura.TabIndex = 5;
            this.grbLectura.TabStop = false;
            this.grbLectura.Visible = false;
            // 
            // rtbLectura
            // 
            this.rtbLectura.Location = new System.Drawing.Point(34, 56);
            this.rtbLectura.Name = "rtbLectura";
            this.rtbLectura.Size = new System.Drawing.Size(246, 249);
            this.rtbLectura.TabIndex = 9;
            this.rtbLectura.Text = "";
            // 
            // eliminarContactoToolStripMenuItem
            // 
            this.eliminarContactoToolStripMenuItem.Name = "eliminarContactoToolStripMenuItem";
            this.eliminarContactoToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.eliminarContactoToolStripMenuItem.Text = "Eliminar contacto";
            this.eliminarContactoToolStripMenuItem.Click += new System.EventHandler(this.eliminarContactoToolStripMenuItem_Click);
            // 
            // grbEliminar
            // 
            this.grbEliminar.Controls.Add(this.btnEliminar);
            this.grbEliminar.Controls.Add(this.ltbEliminar);
            this.grbEliminar.Controls.Add(this.btnBuscarElim);
            this.grbEliminar.Controls.Add(this.txtEliminar);
            this.grbEliminar.Controls.Add(this.lblNomElim);
            this.grbEliminar.Location = new System.Drawing.Point(1132, 60);
            this.grbEliminar.Name = "grbEliminar";
            this.grbEliminar.Size = new System.Drawing.Size(367, 348);
            this.grbEliminar.TabIndex = 6;
            this.grbEliminar.TabStop = false;
            this.grbEliminar.Visible = false;
            // 
            // btnBuscarElim
            // 
            this.btnBuscarElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarElim.Location = new System.Drawing.Point(213, 69);
            this.btnBuscarElim.Name = "btnBuscarElim";
            this.btnBuscarElim.Size = new System.Drawing.Size(80, 35);
            this.btnBuscarElim.TabIndex = 10;
            this.btnBuscarElim.Text = "Buscar";
            this.btnBuscarElim.UseVisualStyleBackColor = true;
            this.btnBuscarElim.Click += new System.EventHandler(this.btnBuscarElim_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(97, 75);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 22);
            this.txtEliminar.TabIndex = 8;
            // 
            // lblNomElim
            // 
            this.lblNomElim.AutoSize = true;
            this.lblNomElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomElim.Location = new System.Drawing.Point(104, 29);
            this.lblNomElim.Name = "lblNomElim";
            this.lblNomElim.Size = new System.Drawing.Size(176, 18);
            this.lblNomElim.TabIndex = 9;
            this.lblNomElim.Text = "Buscar por caracteres";
            // 
            // ltbEliminar
            // 
            this.ltbEliminar.FormattingEnabled = true;
            this.ltbEliminar.ItemHeight = 16;
            this.ltbEliminar.Location = new System.Drawing.Point(97, 125);
            this.ltbEliminar.Name = "ltbEliminar";
            this.ltbEliminar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ltbEliminar.Size = new System.Drawing.Size(196, 100);
            this.ltbEliminar.TabIndex = 11;
            this.ltbEliminar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(160, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 35);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 699);
            this.Controls.Add(this.grbEliminar);
            this.Controls.Add(this.grbLectura);
            this.Controls.Add(this.grbGuardarPorInicial);
            this.Controls.Add(this.grbGuardar);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.grbAltas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Toñi Sanchez Maiquez";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbAltas.ResumeLayout(false);
            this.grbAltas.PerformLayout();
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.grbGuardar.ResumeLayout(false);
            this.grbGuardar.PerformLayout();
            this.grbGuardarPorInicial.ResumeLayout(false);
            this.grbGuardarPorInicial.PerformLayout();
            this.grbLectura.ResumeLayout(false);
            this.grbEliminar.ResumeLayout(false);
            this.grbEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarAgendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarAgendaPorInicialToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbAltas;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAltasBorrar;
        private System.Windows.Forms.Label lblAltasError;
        private System.Windows.Forms.Label lblAltasCreacion;
        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.TextBox txtNombreConsultas;
        private System.Windows.Forms.Label lblNombreConsultas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.RichTextBox rtbConsultas;
        private System.Windows.Forms.ToolStripMenuItem leerAgendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerAgendaPorInicialToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbGuardar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.GroupBox grbGuardarPorInicial;
        private System.Windows.Forms.Button btnBuscarGuardarI;
        private System.Windows.Forms.TextBox txtGuardarI;
        private System.Windows.Forms.Label lblNombreGuardarI;
        private System.Windows.Forms.Button btnGuardarGuardarI;
        private System.Windows.Forms.RichTextBox rtbGuardar;
        private System.Windows.Forms.GroupBox grbLectura;
        private System.Windows.Forms.RichTextBox rtbLectura;
        private System.Windows.Forms.ToolStripMenuItem eliminarContactoToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbEliminar;
        private System.Windows.Forms.Button btnBuscarElim;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label lblNomElim;
        private System.Windows.Forms.ListBox ltbEliminar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

