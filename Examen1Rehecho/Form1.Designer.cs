namespace Examen1Rehecho
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
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearDesbloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbAlta = new System.Windows.Forms.GroupBox();
            this.lblAltaClave = new System.Windows.Forms.Label();
            this.txtAltaClave = new System.Windows.Forms.TextBox();
            this.btnaltaCerrar = new System.Windows.Forms.Button();
            this.btnAltaLimpiar = new System.Windows.Forms.Button();
            this.btnAltaCrear = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtAltaSaldo = new System.Windows.Forms.TextBox();
            this.lblAltaNombre = new System.Windows.Forms.Label();
            this.txtAltaNombre = new System.Windows.Forms.TextBox();
            this.lblAltaDni = new System.Windows.Forms.Label();
            this.txtAltaDni = new System.Windows.Forms.TextBox();
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.btnConsultaCerrar = new System.Windows.Forms.Button();
            this.ckbConsulta = new System.Windows.Forms.CheckBox();
            this.rtbConsulta = new System.Windows.Forms.RichTextBox();
            this.btnConsultaBuscar = new System.Windows.Forms.Button();
            this.lblConsultaNombre = new System.Windows.Forms.Label();
            this.txtConsultaNombre = new System.Windows.Forms.TextBox();
            this.grbCajero = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCajeroClave = new System.Windows.Forms.Button();
            this.btnCajeroDni = new System.Windows.Forms.Button();
            this.lblCajeroClave = new System.Windows.Forms.Label();
            this.txtCajeroClave = new System.Windows.Forms.TextBox();
            this.lblCajeroDni = new System.Windows.Forms.Label();
            this.txtCajeroDni = new System.Windows.Forms.TextBox();
            this.grbBloqueoDesbl = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBloqueoDesbloqueo = new System.Windows.Forms.Button();
            this.btnBloqueoIntro = new System.Windows.Forms.Button();
            this.lblBloqueoClave = new System.Windows.Forms.Label();
            this.txtBloqueoClave = new System.Windows.Forms.TextBox();
            this.lblBloqueoDni = new System.Windows.Forms.Label();
            this.txtBloqueoDbi = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grbAlta.SuspendLayout();
            this.grbConsulta.SuspendLayout();
            this.grbCajero.SuspendLayout();
            this.grbBloqueoDesbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.cajeroToolStripMenuItem,
            this.tarjetaToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1566, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
            this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.cajeroToolStripMenuItem.Text = "Cajero";
            this.cajeroToolStripMenuItem.Click += new System.EventHandler(this.cajeroToolStripMenuItem_Click);
            // 
            // tarjetaToolStripMenuItem
            // 
            this.tarjetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloquearDesbloquearToolStripMenuItem});
            this.tarjetaToolStripMenuItem.Name = "tarjetaToolStripMenuItem";
            this.tarjetaToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.tarjetaToolStripMenuItem.Text = "Tarjeta";
            // 
            // bloquearDesbloquearToolStripMenuItem
            // 
            this.bloquearDesbloquearToolStripMenuItem.Name = "bloquearDesbloquearToolStripMenuItem";
            this.bloquearDesbloquearToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.bloquearDesbloquearToolStripMenuItem.Text = "Bloquear/Desbloquear";
            this.bloquearDesbloquearToolStripMenuItem.Click += new System.EventHandler(this.bloquearDesbloquearToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // grbAlta
            // 
            this.grbAlta.Controls.Add(this.lblAltaClave);
            this.grbAlta.Controls.Add(this.txtAltaClave);
            this.grbAlta.Controls.Add(this.btnaltaCerrar);
            this.grbAlta.Controls.Add(this.btnAltaLimpiar);
            this.grbAlta.Controls.Add(this.btnAltaCrear);
            this.grbAlta.Controls.Add(this.lblSaldo);
            this.grbAlta.Controls.Add(this.txtAltaSaldo);
            this.grbAlta.Controls.Add(this.lblAltaNombre);
            this.grbAlta.Controls.Add(this.txtAltaNombre);
            this.grbAlta.Controls.Add(this.lblAltaDni);
            this.grbAlta.Controls.Add(this.txtAltaDni);
            this.grbAlta.Location = new System.Drawing.Point(12, 61);
            this.grbAlta.Name = "grbAlta";
            this.grbAlta.Size = new System.Drawing.Size(332, 289);
            this.grbAlta.TabIndex = 1;
            this.grbAlta.TabStop = false;
            this.grbAlta.Visible = false;
            // 
            // lblAltaClave
            // 
            this.lblAltaClave.AutoSize = true;
            this.lblAltaClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaClave.Location = new System.Drawing.Point(28, 165);
            this.lblAltaClave.Name = "lblAltaClave";
            this.lblAltaClave.Size = new System.Drawing.Size(50, 18);
            this.lblAltaClave.TabIndex = 10;
            this.lblAltaClave.Text = "Clave";
            // 
            // txtAltaClave
            // 
            this.txtAltaClave.Location = new System.Drawing.Point(112, 165);
            this.txtAltaClave.Name = "txtAltaClave";
            this.txtAltaClave.Size = new System.Drawing.Size(100, 22);
            this.txtAltaClave.TabIndex = 9;
            // 
            // btnaltaCerrar
            // 
            this.btnaltaCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaltaCerrar.Location = new System.Drawing.Point(212, 229);
            this.btnaltaCerrar.Name = "btnaltaCerrar";
            this.btnaltaCerrar.Size = new System.Drawing.Size(80, 31);
            this.btnaltaCerrar.TabIndex = 8;
            this.btnaltaCerrar.Text = "Cerrar";
            this.btnaltaCerrar.UseVisualStyleBackColor = true;
            this.btnaltaCerrar.Click += new System.EventHandler(this.btnaltaCerrar_Click);
            // 
            // btnAltaLimpiar
            // 
            this.btnAltaLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaLimpiar.Location = new System.Drawing.Point(112, 229);
            this.btnAltaLimpiar.Name = "btnAltaLimpiar";
            this.btnAltaLimpiar.Size = new System.Drawing.Size(80, 31);
            this.btnAltaLimpiar.TabIndex = 7;
            this.btnAltaLimpiar.Text = "Limpiar";
            this.btnAltaLimpiar.UseVisualStyleBackColor = true;
            this.btnAltaLimpiar.Click += new System.EventHandler(this.btnAltaLimpiar_Click);
            // 
            // btnAltaCrear
            // 
            this.btnAltaCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCrear.Location = new System.Drawing.Point(11, 229);
            this.btnAltaCrear.Name = "btnAltaCrear";
            this.btnAltaCrear.Size = new System.Drawing.Size(80, 31);
            this.btnAltaCrear.TabIndex = 6;
            this.btnAltaCrear.Text = "Crear";
            this.btnAltaCrear.UseVisualStyleBackColor = true;
            this.btnAltaCrear.Click += new System.EventHandler(this.btnAltaCrear_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(28, 125);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(51, 18);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtAltaSaldo
            // 
            this.txtAltaSaldo.Location = new System.Drawing.Point(112, 125);
            this.txtAltaSaldo.Name = "txtAltaSaldo";
            this.txtAltaSaldo.Size = new System.Drawing.Size(100, 22);
            this.txtAltaSaldo.TabIndex = 4;
            // 
            // lblAltaNombre
            // 
            this.lblAltaNombre.AutoSize = true;
            this.lblAltaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaNombre.Location = new System.Drawing.Point(28, 82);
            this.lblAltaNombre.Name = "lblAltaNombre";
            this.lblAltaNombre.Size = new System.Drawing.Size(68, 18);
            this.lblAltaNombre.TabIndex = 3;
            this.lblAltaNombre.Text = "Nombre";
            // 
            // txtAltaNombre
            // 
            this.txtAltaNombre.Location = new System.Drawing.Point(112, 82);
            this.txtAltaNombre.Name = "txtAltaNombre";
            this.txtAltaNombre.Size = new System.Drawing.Size(100, 22);
            this.txtAltaNombre.TabIndex = 2;
            // 
            // lblAltaDni
            // 
            this.lblAltaDni.AutoSize = true;
            this.lblAltaDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaDni.Location = new System.Drawing.Point(28, 45);
            this.lblAltaDni.Name = "lblAltaDni";
            this.lblAltaDni.Size = new System.Drawing.Size(33, 18);
            this.lblAltaDni.TabIndex = 1;
            this.lblAltaDni.Text = "Dni";
            // 
            // txtAltaDni
            // 
            this.txtAltaDni.Location = new System.Drawing.Point(112, 45);
            this.txtAltaDni.Name = "txtAltaDni";
            this.txtAltaDni.Size = new System.Drawing.Size(100, 22);
            this.txtAltaDni.TabIndex = 0;
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.btnConsultaCerrar);
            this.grbConsulta.Controls.Add(this.ckbConsulta);
            this.grbConsulta.Controls.Add(this.rtbConsulta);
            this.grbConsulta.Controls.Add(this.btnConsultaBuscar);
            this.grbConsulta.Controls.Add(this.lblConsultaNombre);
            this.grbConsulta.Controls.Add(this.txtConsultaNombre);
            this.grbConsulta.Location = new System.Drawing.Point(350, 61);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(321, 338);
            this.grbConsulta.TabIndex = 2;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Visible = false;
            // 
            // btnConsultaCerrar
            // 
            this.btnConsultaCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCerrar.Location = new System.Drawing.Point(209, 289);
            this.btnConsultaCerrar.Name = "btnConsultaCerrar";
            this.btnConsultaCerrar.Size = new System.Drawing.Size(80, 31);
            this.btnConsultaCerrar.TabIndex = 10;
            this.btnConsultaCerrar.Text = "Cerrar";
            this.btnConsultaCerrar.UseVisualStyleBackColor = true;
            this.btnConsultaCerrar.Click += new System.EventHandler(this.btnConsultaCerrar_Click);
            // 
            // ckbConsulta
            // 
            this.ckbConsulta.AutoSize = true;
            this.ckbConsulta.Enabled = false;
            this.ckbConsulta.Location = new System.Drawing.Point(150, 94);
            this.ckbConsulta.Name = "ckbConsulta";
            this.ckbConsulta.Size = new System.Drawing.Size(120, 20);
            this.ckbConsulta.TabIndex = 9;
            this.ckbConsulta.Text = "Bloqueo tarjeta";
            this.ckbConsulta.UseVisualStyleBackColor = true;
            this.ckbConsulta.Visible = false;
            // 
            // rtbConsulta
            // 
            this.rtbConsulta.Location = new System.Drawing.Point(25, 136);
            this.rtbConsulta.Name = "rtbConsulta";
            this.rtbConsulta.Size = new System.Drawing.Size(276, 124);
            this.rtbConsulta.TabIndex = 8;
            this.rtbConsulta.Text = "";
            // 
            // btnConsultaBuscar
            // 
            this.btnConsultaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaBuscar.Location = new System.Drawing.Point(221, 36);
            this.btnConsultaBuscar.Name = "btnConsultaBuscar";
            this.btnConsultaBuscar.Size = new System.Drawing.Size(80, 31);
            this.btnConsultaBuscar.TabIndex = 7;
            this.btnConsultaBuscar.Text = "Buscar";
            this.btnConsultaBuscar.UseVisualStyleBackColor = true;
            this.btnConsultaBuscar.Click += new System.EventHandler(this.btnConsultaBuscar_Click);
            // 
            // lblConsultaNombre
            // 
            this.lblConsultaNombre.AutoSize = true;
            this.lblConsultaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaNombre.Location = new System.Drawing.Point(22, 41);
            this.lblConsultaNombre.Name = "lblConsultaNombre";
            this.lblConsultaNombre.Size = new System.Drawing.Size(68, 18);
            this.lblConsultaNombre.TabIndex = 5;
            this.lblConsultaNombre.Text = "Nombre";
            // 
            // txtConsultaNombre
            // 
            this.txtConsultaNombre.Location = new System.Drawing.Point(106, 41);
            this.txtConsultaNombre.Name = "txtConsultaNombre";
            this.txtConsultaNombre.Size = new System.Drawing.Size(100, 22);
            this.txtConsultaNombre.TabIndex = 4;
            // 
            // grbCajero
            // 
            this.grbCajero.Controls.Add(this.button1);
            this.grbCajero.Controls.Add(this.btnCajeroClave);
            this.grbCajero.Controls.Add(this.btnCajeroDni);
            this.grbCajero.Controls.Add(this.lblCajeroClave);
            this.grbCajero.Controls.Add(this.txtCajeroClave);
            this.grbCajero.Controls.Add(this.lblCajeroDni);
            this.grbCajero.Controls.Add(this.txtCajeroDni);
            this.grbCajero.Location = new System.Drawing.Point(677, 61);
            this.grbCajero.Name = "grbCajero";
            this.grbCajero.Size = new System.Drawing.Size(329, 227);
            this.grbCajero.TabIndex = 3;
            this.grbCajero.TabStop = false;
            this.grbCajero.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(122, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCajeroClave
            // 
            this.btnCajeroClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajeroClave.Location = new System.Drawing.Point(232, 77);
            this.btnCajeroClave.Name = "btnCajeroClave";
            this.btnCajeroClave.Size = new System.Drawing.Size(80, 31);
            this.btnCajeroClave.TabIndex = 14;
            this.btnCajeroClave.Text = "Intro";
            this.btnCajeroClave.UseVisualStyleBackColor = true;
            this.btnCajeroClave.Visible = false;
            this.btnCajeroClave.Click += new System.EventHandler(this.btnCajeroClave_Click);
            // 
            // btnCajeroDni
            // 
            this.btnCajeroDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajeroDni.Location = new System.Drawing.Point(232, 30);
            this.btnCajeroDni.Name = "btnCajeroDni";
            this.btnCajeroDni.Size = new System.Drawing.Size(80, 31);
            this.btnCajeroDni.TabIndex = 13;
            this.btnCajeroDni.Text = "Intro";
            this.btnCajeroDni.UseVisualStyleBackColor = true;
            this.btnCajeroDni.Click += new System.EventHandler(this.btnCajeroIntro_Click);
            // 
            // lblCajeroClave
            // 
            this.lblCajeroClave.AutoSize = true;
            this.lblCajeroClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajeroClave.Location = new System.Drawing.Point(27, 81);
            this.lblCajeroClave.Name = "lblCajeroClave";
            this.lblCajeroClave.Size = new System.Drawing.Size(50, 18);
            this.lblCajeroClave.TabIndex = 12;
            this.lblCajeroClave.Text = "Clave";
            this.lblCajeroClave.Visible = false;
            // 
            // txtCajeroClave
            // 
            this.txtCajeroClave.Location = new System.Drawing.Point(111, 81);
            this.txtCajeroClave.Name = "txtCajeroClave";
            this.txtCajeroClave.Size = new System.Drawing.Size(100, 22);
            this.txtCajeroClave.TabIndex = 11;
            this.txtCajeroClave.UseSystemPasswordChar = true;
            this.txtCajeroClave.Visible = false;
            // 
            // lblCajeroDni
            // 
            this.lblCajeroDni.AutoSize = true;
            this.lblCajeroDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajeroDni.Location = new System.Drawing.Point(27, 36);
            this.lblCajeroDni.Name = "lblCajeroDni";
            this.lblCajeroDni.Size = new System.Drawing.Size(33, 18);
            this.lblCajeroDni.TabIndex = 7;
            this.lblCajeroDni.Text = "Dni";
            // 
            // txtCajeroDni
            // 
            this.txtCajeroDni.Location = new System.Drawing.Point(111, 36);
            this.txtCajeroDni.Name = "txtCajeroDni";
            this.txtCajeroDni.Size = new System.Drawing.Size(100, 22);
            this.txtCajeroDni.TabIndex = 6;
            // 
            // grbBloqueoDesbl
            // 
            this.grbBloqueoDesbl.Controls.Add(this.button2);
            this.grbBloqueoDesbl.Controls.Add(this.btnBloqueoDesbloqueo);
            this.grbBloqueoDesbl.Controls.Add(this.btnBloqueoIntro);
            this.grbBloqueoDesbl.Controls.Add(this.lblBloqueoClave);
            this.grbBloqueoDesbl.Controls.Add(this.txtBloqueoClave);
            this.grbBloqueoDesbl.Controls.Add(this.lblBloqueoDni);
            this.grbBloqueoDesbl.Controls.Add(this.txtBloqueoDbi);
            this.grbBloqueoDesbl.Location = new System.Drawing.Point(1012, 61);
            this.grbBloqueoDesbl.Name = "grbBloqueoDesbl";
            this.grbBloqueoDesbl.Size = new System.Drawing.Size(325, 289);
            this.grbBloqueoDesbl.TabIndex = 4;
            this.grbBloqueoDesbl.TabStop = false;
            this.grbBloqueoDesbl.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(225, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBloqueoDesbloqueo
            // 
            this.btnBloqueoDesbloqueo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloqueoDesbloqueo.Location = new System.Drawing.Point(20, 165);
            this.btnBloqueoDesbloqueo.Name = "btnBloqueoDesbloqueo";
            this.btnBloqueoDesbloqueo.Size = new System.Drawing.Size(157, 31);
            this.btnBloqueoDesbloqueo.TabIndex = 18;
            this.btnBloqueoDesbloqueo.UseVisualStyleBackColor = true;
            this.btnBloqueoDesbloqueo.Visible = false;
            // 
            // btnBloqueoIntro
            // 
            this.btnBloqueoIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloqueoIntro.Location = new System.Drawing.Point(225, 47);
            this.btnBloqueoIntro.Name = "btnBloqueoIntro";
            this.btnBloqueoIntro.Size = new System.Drawing.Size(80, 31);
            this.btnBloqueoIntro.TabIndex = 17;
            this.btnBloqueoIntro.Text = "Intro";
            this.btnBloqueoIntro.UseVisualStyleBackColor = true;
            this.btnBloqueoIntro.Click += new System.EventHandler(this.btnBloqueoIntro_Click);
            // 
            // lblBloqueoClave
            // 
            this.lblBloqueoClave.AutoSize = true;
            this.lblBloqueoClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloqueoClave.Location = new System.Drawing.Point(17, 75);
            this.lblBloqueoClave.Name = "lblBloqueoClave";
            this.lblBloqueoClave.Size = new System.Drawing.Size(50, 18);
            this.lblBloqueoClave.TabIndex = 16;
            this.lblBloqueoClave.Text = "Clave";
            // 
            // txtBloqueoClave
            // 
            this.txtBloqueoClave.Location = new System.Drawing.Point(101, 75);
            this.txtBloqueoClave.Name = "txtBloqueoClave";
            this.txtBloqueoClave.Size = new System.Drawing.Size(100, 22);
            this.txtBloqueoClave.TabIndex = 15;
            this.txtBloqueoClave.UseSystemPasswordChar = true;
            // 
            // lblBloqueoDni
            // 
            this.lblBloqueoDni.AutoSize = true;
            this.lblBloqueoDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloqueoDni.Location = new System.Drawing.Point(17, 30);
            this.lblBloqueoDni.Name = "lblBloqueoDni";
            this.lblBloqueoDni.Size = new System.Drawing.Size(33, 18);
            this.lblBloqueoDni.TabIndex = 14;
            this.lblBloqueoDni.Text = "Dni";
            // 
            // txtBloqueoDbi
            // 
            this.txtBloqueoDbi.Location = new System.Drawing.Point(101, 30);
            this.txtBloqueoDbi.Name = "txtBloqueoDbi";
            this.txtBloqueoDbi.Size = new System.Drawing.Size(100, 22);
            this.txtBloqueoDbi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 726);
            this.Controls.Add(this.grbBloqueoDesbl);
            this.Controls.Add(this.grbCajero);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.grbAlta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbAlta.ResumeLayout(false);
            this.grbAlta.PerformLayout();
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.grbCajero.ResumeLayout(false);
            this.grbCajero.PerformLayout();
            this.grbBloqueoDesbl.ResumeLayout(false);
            this.grbBloqueoDesbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearDesbloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbAlta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtAltaSaldo;
        private System.Windows.Forms.Label lblAltaNombre;
        private System.Windows.Forms.TextBox txtAltaNombre;
        private System.Windows.Forms.Label lblAltaDni;
        private System.Windows.Forms.TextBox txtAltaDni;
        private System.Windows.Forms.Button btnaltaCerrar;
        private System.Windows.Forms.Button btnAltaLimpiar;
        private System.Windows.Forms.Button btnAltaCrear;
        private System.Windows.Forms.Label lblAltaClave;
        private System.Windows.Forms.TextBox txtAltaClave;
        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.Button btnConsultaBuscar;
        private System.Windows.Forms.Label lblConsultaNombre;
        private System.Windows.Forms.TextBox txtConsultaNombre;
        private System.Windows.Forms.CheckBox ckbConsulta;
        private System.Windows.Forms.RichTextBox rtbConsulta;
        private System.Windows.Forms.GroupBox grbCajero;
        private System.Windows.Forms.Label lblCajeroClave;
        private System.Windows.Forms.TextBox txtCajeroClave;
        private System.Windows.Forms.Label lblCajeroDni;
        private System.Windows.Forms.TextBox txtCajeroDni;
        private System.Windows.Forms.Button btnConsultaCerrar;
        private System.Windows.Forms.Button btnCajeroDni;
        private System.Windows.Forms.Button btnCajeroClave;
        private System.Windows.Forms.GroupBox grbBloqueoDesbl;
        private System.Windows.Forms.Label lblBloqueoClave;
        private System.Windows.Forms.TextBox txtBloqueoClave;
        private System.Windows.Forms.Label lblBloqueoDni;
        private System.Windows.Forms.TextBox txtBloqueoDbi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBloqueoDesbloqueo;
        private System.Windows.Forms.Button btnBloqueoIntro;
        private System.Windows.Forms.Button button2;
    }
}

