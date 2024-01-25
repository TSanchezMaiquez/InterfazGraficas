namespace Examen1Toñi
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
            this.mstMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearDesbloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbAltas = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.lblAltas = new System.Windows.Forms.Label();
            this.lblAltasExito = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbBloqueo = new System.Windows.Forms.CheckBox();
            this.rtbConsulta = new System.Windows.Forms.RichTextBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.grbCajero = new System.Windows.Forms.GroupBox();
            this.cajeroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDniCajero = new System.Windows.Forms.TextBox();
            this.lblDniCajero = new System.Windows.Forms.Label();
            this.txtClaveCajero = new System.Windows.Forms.TextBox();
            this.lblClaveCajero = new System.Windows.Forms.Label();
            this.lblCajero = new System.Windows.Forms.Label();
            this.btnCajero = new System.Windows.Forms.Button();
            this.grbTarjeta = new System.Windows.Forms.GroupBox();
            this.txtClaveTarjeta = new System.Windows.Forms.TextBox();
            this.lblClaveTarjeta = new System.Windows.Forms.Label();
            this.txtDniTarjeta = new System.Windows.Forms.TextBox();
            this.lblDniTarjeta = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btnTarjetaBloqDes = new System.Windows.Forms.Button();
            this.lblErrorTarjeta = new System.Windows.Forms.Label();
            this.mstMenuPrincipal.SuspendLayout();
            this.grbAltas.SuspendLayout();
            this.grbConsulta.SuspendLayout();
            this.grbCajero.SuspendLayout();
            this.grbTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenuPrincipal
            // 
            this.mstMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.cajeroToolStripMenuItem,
            this.tarjetaToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.mstMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstMenuPrincipal.Name = "mstMenuPrincipal";
            this.mstMenuPrincipal.Size = new System.Drawing.Size(1494, 28);
            this.mstMenuPrincipal.TabIndex = 0;
            this.mstMenuPrincipal.Text = "menuStrip1";
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
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.menuCliente);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.menuCliente);
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajeroToolStripMenuItem1});
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
            // grbAltas
            // 
            this.grbAltas.Controls.Add(this.lblError);
            this.grbAltas.Controls.Add(this.lblAltasExito);
            this.grbAltas.Controls.Add(this.lblAltas);
            this.grbAltas.Controls.Add(this.btnCancelarAlta);
            this.grbAltas.Controls.Add(this.btnAlta);
            this.grbAltas.Controls.Add(this.txtSaldo);
            this.grbAltas.Controls.Add(this.txtNombre);
            this.grbAltas.Controls.Add(this.txtClave);
            this.grbAltas.Controls.Add(this.txtDni);
            this.grbAltas.Controls.Add(this.lblSaldo);
            this.grbAltas.Controls.Add(this.lblClave);
            this.grbAltas.Controls.Add(this.lblNombre);
            this.grbAltas.Controls.Add(this.lblDni);
            this.grbAltas.Location = new System.Drawing.Point(12, 83);
            this.grbAltas.Name = "grbAltas";
            this.grbAltas.Size = new System.Drawing.Size(314, 396);
            this.grbAltas.TabIndex = 1;
            this.grbAltas.TabStop = false;
            this.grbAltas.Visible = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(19, 75);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 18);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Dni:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(19, 150);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(55, 18);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(19, 186);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(56, 18);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(115, 75);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(155, 22);
            this.txtDni.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(115, 150);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(155, 22);
            this.txtClave.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(115, 182);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(155, 22);
            this.txtSaldo.TabIndex = 3;
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(65, 234);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(98, 41);
            this.btnAlta.TabIndex = 4;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAlta.Location = new System.Drawing.Point(201, 234);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(98, 41);
            this.btnCancelarAlta.TabIndex = 5;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // lblAltas
            // 
            this.lblAltas.AutoSize = true;
            this.lblAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltas.Location = new System.Drawing.Point(148, 31);
            this.lblAltas.Name = "lblAltas";
            this.lblAltas.Size = new System.Drawing.Size(45, 24);
            this.lblAltas.TabIndex = 10;
            this.lblAltas.Text = "Alta";
            // 
            // lblAltasExito
            // 
            this.lblAltasExito.AutoSize = true;
            this.lblAltasExito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltasExito.Location = new System.Drawing.Point(28, 296);
            this.lblAltasExito.Name = "lblAltasExito";
            this.lblAltasExito.Size = new System.Drawing.Size(124, 17);
            this.lblAltasExito.TabIndex = 11;
            this.lblAltasExito.Text = "Registro creado";
            this.lblAltasExito.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(171, 296);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(129, 17);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Datos no validos";
            this.lblError.Visible = false;
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.btnConsultas);
            this.grbConsulta.Controls.Add(this.rtbConsulta);
            this.grbConsulta.Controls.Add(this.ckbBloqueo);
            this.grbConsulta.Controls.Add(this.txtConsulta);
            this.grbConsulta.Controls.Add(this.label1);
            this.grbConsulta.Controls.Add(this.lblConsulta);
            this.grbConsulta.Location = new System.Drawing.Point(362, 94);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(304, 385);
            this.grbConsulta.TabIndex = 2;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Visible = false;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(119, 30);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(91, 24);
            this.lblConsulta.TabIndex = 11;
            this.lblConsulta.Text = "Consulta";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(123, 74);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(155, 22);
            this.txtConsulta.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // ckbBloqueo
            // 
            this.ckbBloqueo.AutoSize = true;
            this.ckbBloqueo.Enabled = false;
            this.ckbBloqueo.Location = new System.Drawing.Point(78, 171);
            this.ckbBloqueo.Name = "ckbBloqueo";
            this.ckbBloqueo.Size = new System.Drawing.Size(138, 20);
            this.ckbBloqueo.TabIndex = 14;
            this.ckbBloqueo.Text = "CuentaBloqueada";
            this.ckbBloqueo.UseVisualStyleBackColor = true;
            this.ckbBloqueo.Visible = false;
            // 
            // rtbConsulta
            // 
            this.rtbConsulta.Location = new System.Drawing.Point(30, 206);
            this.rtbConsulta.Name = "rtbConsulta";
            this.rtbConsulta.Size = new System.Drawing.Size(239, 135);
            this.rtbConsulta.TabIndex = 15;
            this.rtbConsulta.Text = "";
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(157, 114);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(80, 31);
            this.btnConsultas.TabIndex = 16;
            this.btnConsultas.Text = "Buscar";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // grbCajero
            // 
            this.grbCajero.Controls.Add(this.btnCajero);
            this.grbCajero.Controls.Add(this.lblCajero);
            this.grbCajero.Controls.Add(this.txtClaveCajero);
            this.grbCajero.Controls.Add(this.lblClaveCajero);
            this.grbCajero.Controls.Add(this.txtDniCajero);
            this.grbCajero.Controls.Add(this.lblDniCajero);
            this.grbCajero.Location = new System.Drawing.Point(705, 104);
            this.grbCajero.Name = "grbCajero";
            this.grbCajero.Size = new System.Drawing.Size(307, 234);
            this.grbCajero.TabIndex = 3;
            this.grbCajero.TabStop = false;
            this.grbCajero.Visible = false;
            // 
            // cajeroToolStripMenuItem1
            // 
            this.cajeroToolStripMenuItem1.Name = "cajeroToolStripMenuItem1";
            this.cajeroToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cajeroToolStripMenuItem1.Text = "Cajero";
            // 
            // txtDniCajero
            // 
            this.txtDniCajero.Location = new System.Drawing.Point(124, 81);
            this.txtDniCajero.Name = "txtDniCajero";
            this.txtDniCajero.Size = new System.Drawing.Size(155, 22);
            this.txtDniCajero.TabIndex = 1;
            // 
            // lblDniCajero
            // 
            this.lblDniCajero.AutoSize = true;
            this.lblDniCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCajero.Location = new System.Drawing.Point(28, 81);
            this.lblDniCajero.Name = "lblDniCajero";
            this.lblDniCajero.Size = new System.Drawing.Size(38, 18);
            this.lblDniCajero.TabIndex = 2;
            this.lblDniCajero.Text = "Dni:";
            // 
            // txtClaveCajero
            // 
            this.txtClaveCajero.Location = new System.Drawing.Point(124, 117);
            this.txtClaveCajero.Name = "txtClaveCajero";
            this.txtClaveCajero.Size = new System.Drawing.Size(155, 22);
            this.txtClaveCajero.TabIndex = 3;
            this.txtClaveCajero.UseSystemPasswordChar = true;
            // 
            // lblClaveCajero
            // 
            this.lblClaveCajero.AutoSize = true;
            this.lblClaveCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCajero.Location = new System.Drawing.Point(28, 117);
            this.lblClaveCajero.Name = "lblClaveCajero";
            this.lblClaveCajero.Size = new System.Drawing.Size(55, 18);
            this.lblClaveCajero.TabIndex = 4;
            this.lblClaveCajero.Text = "Clave:";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.Location = new System.Drawing.Point(91, 34);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(71, 24);
            this.lblCajero.TabIndex = 12;
            this.lblCajero.Text = "Cajero";
            // 
            // btnCajero
            // 
            this.btnCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajero.Location = new System.Drawing.Point(161, 165);
            this.btnCajero.Name = "btnCajero";
            this.btnCajero.Size = new System.Drawing.Size(80, 31);
            this.btnCajero.TabIndex = 17;
            this.btnCajero.Text = "Entrar";
            this.btnCajero.UseVisualStyleBackColor = true;
            this.btnCajero.Click += new System.EventHandler(this.btnCajero_Click);
            // 
            // grbTarjeta
            // 
            this.grbTarjeta.Controls.Add(this.lblErrorTarjeta);
            this.grbTarjeta.Controls.Add(this.btnTarjetaBloqDes);
            this.grbTarjeta.Controls.Add(this.btnTarjeta);
            this.grbTarjeta.Controls.Add(this.lblTarjeta);
            this.grbTarjeta.Controls.Add(this.txtClaveTarjeta);
            this.grbTarjeta.Controls.Add(this.lblClaveTarjeta);
            this.grbTarjeta.Controls.Add(this.txtDniTarjeta);
            this.grbTarjeta.Controls.Add(this.lblDniTarjeta);
            this.grbTarjeta.Location = new System.Drawing.Point(1055, 150);
            this.grbTarjeta.Name = "grbTarjeta";
            this.grbTarjeta.Size = new System.Drawing.Size(313, 329);
            this.grbTarjeta.TabIndex = 4;
            this.grbTarjeta.TabStop = false;
            this.grbTarjeta.Visible = false;
            // 
            // txtClaveTarjeta
            // 
            this.txtClaveTarjeta.Location = new System.Drawing.Point(112, 111);
            this.txtClaveTarjeta.Name = "txtClaveTarjeta";
            this.txtClaveTarjeta.Size = new System.Drawing.Size(155, 22);
            this.txtClaveTarjeta.TabIndex = 7;
            // 
            // lblClaveTarjeta
            // 
            this.lblClaveTarjeta.AutoSize = true;
            this.lblClaveTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveTarjeta.Location = new System.Drawing.Point(16, 111);
            this.lblClaveTarjeta.Name = "lblClaveTarjeta";
            this.lblClaveTarjeta.Size = new System.Drawing.Size(55, 18);
            this.lblClaveTarjeta.TabIndex = 8;
            this.lblClaveTarjeta.Text = "Clave:";
            // 
            // txtDniTarjeta
            // 
            this.txtDniTarjeta.Location = new System.Drawing.Point(112, 75);
            this.txtDniTarjeta.Name = "txtDniTarjeta";
            this.txtDniTarjeta.Size = new System.Drawing.Size(155, 22);
            this.txtDniTarjeta.TabIndex = 5;
            // 
            // lblDniTarjeta
            // 
            this.lblDniTarjeta.AutoSize = true;
            this.lblDniTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniTarjeta.Location = new System.Drawing.Point(16, 75);
            this.lblDniTarjeta.Name = "lblDniTarjeta";
            this.lblDniTarjeta.Size = new System.Drawing.Size(38, 18);
            this.lblDniTarjeta.TabIndex = 6;
            this.lblDniTarjeta.Text = "Dni:";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(129, 29);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(74, 24);
            this.lblTarjeta.TabIndex = 13;
            this.lblTarjeta.Text = "Tarjeta";
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.Location = new System.Drawing.Point(144, 201);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(80, 31);
            this.btnTarjeta.TabIndex = 18;
            this.btnTarjeta.Text = "Buscar";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btnTarjetaBloqDes
            // 
            this.btnTarjetaBloqDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjetaBloqDes.Location = new System.Drawing.Point(79, 260);
            this.btnTarjetaBloqDes.Name = "btnTarjetaBloqDes";
            this.btnTarjetaBloqDes.Size = new System.Drawing.Size(188, 41);
            this.btnTarjetaBloqDes.TabIndex = 19;
            this.btnTarjetaBloqDes.Text = "Buscar";
            this.btnTarjetaBloqDes.UseVisualStyleBackColor = true;
            this.btnTarjetaBloqDes.Visible = false;
            this.btnTarjetaBloqDes.Click += new System.EventHandler(this.btnTarjetaBloqDes_Click);
            // 
            // lblErrorTarjeta
            // 
            this.lblErrorTarjeta.AutoSize = true;
            this.lblErrorTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTarjeta.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTarjeta.Location = new System.Drawing.Point(121, 153);
            this.lblErrorTarjeta.Name = "lblErrorTarjeta";
            this.lblErrorTarjeta.Size = new System.Drawing.Size(129, 17);
            this.lblErrorTarjeta.TabIndex = 20;
            this.lblErrorTarjeta.Text = "Datos no validos";
            this.lblErrorTarjeta.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 711);
            this.Controls.Add(this.grbTarjeta);
            this.Controls.Add(this.grbCajero);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.grbAltas);
            this.Controls.Add(this.mstMenuPrincipal);
            this.MainMenuStrip = this.mstMenuPrincipal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mstMenuPrincipal.ResumeLayout(false);
            this.mstMenuPrincipal.PerformLayout();
            this.grbAltas.ResumeLayout(false);
            this.grbAltas.PerformLayout();
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.grbCajero.ResumeLayout(false);
            this.grbCajero.PerformLayout();
            this.grbTarjeta.ResumeLayout(false);
            this.grbTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearDesbloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbAltas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblAltas;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAltasExito;
        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.CheckBox ckbBloqueo;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.RichTextBox rtbConsulta;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem1;
        private System.Windows.Forms.GroupBox grbCajero;
        private System.Windows.Forms.Button btnCajero;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.TextBox txtClaveCajero;
        private System.Windows.Forms.Label lblClaveCajero;
        private System.Windows.Forms.TextBox txtDniCajero;
        private System.Windows.Forms.Label lblDniCajero;
        private System.Windows.Forms.GroupBox grbTarjeta;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.TextBox txtClaveTarjeta;
        private System.Windows.Forms.Label lblClaveTarjeta;
        private System.Windows.Forms.TextBox txtDniTarjeta;
        private System.Windows.Forms.Label lblDniTarjeta;
        private System.Windows.Forms.Button btnTarjetaBloqDes;
        private System.Windows.Forms.Label lblErrorTarjeta;
    }
}

