namespace SiGIProV.Interfaces
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.bHome = new FontAwesome.Sharp.IconButton();
            this.buttonRestaurar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.panelSubMenuCliente = new System.Windows.Forms.Panel();
            this.botonListarCliente = new FontAwesome.Sharp.IconButton();
            this.botonModificarCliente = new FontAwesome.Sharp.IconButton();
            this.botonRegistrarCliente = new FontAwesome.Sharp.IconButton();
            this.botonCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.botonRegistarNuevoCliente = new FontAwesome.Sharp.IconButton();
            this.botonPedido = new FontAwesome.Sharp.IconButton();
            this.lEmpresa = new System.Windows.Forms.Label();
            this.botonInicio = new System.Windows.Forms.PictureBox();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureUsuario = new System.Windows.Forms.PictureBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.panelTitulo.SuspendLayout();
            this.panelMenuVertical.SuspendLayout();
            this.panelSubMenuCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonInicio)).BeginInit();
            this.panelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.panelTitulo.Controls.Add(this.bHome);
            this.panelTitulo.Controls.Add(this.buttonRestaurar);
            this.panelTitulo.Controls.Add(this.buttonMinimizar);
            this.panelTitulo.Controls.Add(this.buttonMaximizar);
            this.panelTitulo.Controls.Add(this.buttonCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1300, 35);
            this.panelTitulo.TabIndex = 3;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // bHome
            // 
            this.bHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.bHome.FlatAppearance.BorderSize = 0;
            this.bHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.bHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.bHome.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.bHome.IconColor = System.Drawing.Color.Gainsboro;
            this.bHome.IconSize = 16;
            this.bHome.Location = new System.Drawing.Point(221, 5);
            this.bHome.Name = "bHome";
            this.bHome.Rotation = 0D;
            this.bHome.Size = new System.Drawing.Size(75, 23);
            this.bHome.TabIndex = 10;
            this.bHome.Text = "Home";
            this.bHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bHome.UseVisualStyleBackColor = false;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRestaurar.BackgroundImage")));
            this.buttonRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestaurar.FlatAppearance.BorderSize = 0;
            this.buttonRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.buttonRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurar.Location = new System.Drawing.Point(1223, 2);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(30, 30);
            this.buttonRestaurar.TabIndex = 9;
            this.buttonRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonRestaurar.UseVisualStyleBackColor = true;
            this.buttonRestaurar.Visible = false;
            this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.BackgroundImage")));
            this.buttonMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimizar.FlatAppearance.BorderSize = 0;
            this.buttonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.buttonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizar.Location = new System.Drawing.Point(1186, 2);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimizar.TabIndex = 8;
            this.buttonMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMinimizar.UseVisualStyleBackColor = true;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximizar.BackgroundImage")));
            this.buttonMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximizar.FlatAppearance.BorderSize = 0;
            this.buttonMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.buttonMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizar.Location = new System.Drawing.Point(1223, 2);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Size = new System.Drawing.Size(30, 30);
            this.buttonMaximizar.TabIndex = 7;
            this.buttonMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonMaximizar.UseVisualStyleBackColor = true;
            this.buttonMaximizar.Click += new System.EventHandler(this.buttonMaximizar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCerrar.BackgroundImage")));
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(1258, 2);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(30, 30);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuVertical.Controls.Add(this.panelSubMenuCliente);
            this.panelMenuVertical.Controls.Add(this.botonCerrarSesion);
            this.panelMenuVertical.Controls.Add(this.botonRegistarNuevoCliente);
            this.panelMenuVertical.Controls.Add(this.botonPedido);
            this.panelMenuVertical.Controls.Add(this.lEmpresa);
            this.panelMenuVertical.Controls.Add(this.botonInicio);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 35);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(220, 615);
            this.panelMenuVertical.TabIndex = 4;
            // 
            // panelSubMenuCliente
            // 
            this.panelSubMenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuCliente.Controls.Add(this.botonListarCliente);
            this.panelSubMenuCliente.Controls.Add(this.botonModificarCliente);
            this.panelSubMenuCliente.Controls.Add(this.botonRegistrarCliente);
            this.panelSubMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCliente.Location = new System.Drawing.Point(0, 276);
            this.panelSubMenuCliente.Name = "panelSubMenuCliente";
            this.panelSubMenuCliente.Size = new System.Drawing.Size(220, 141);
            this.panelSubMenuCliente.TabIndex = 17;
            // 
            // botonListarCliente
            // 
            this.botonListarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonListarCliente.FlatAppearance.BorderSize = 0;
            this.botonListarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.botonListarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonListarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonListarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonListarCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonListarCliente.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.botonListarCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.botonListarCliente.IconSize = 32;
            this.botonListarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonListarCliente.Location = new System.Drawing.Point(0, 90);
            this.botonListarCliente.Name = "botonListarCliente";
            this.botonListarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonListarCliente.Rotation = 0D;
            this.botonListarCliente.Size = new System.Drawing.Size(220, 45);
            this.botonListarCliente.TabIndex = 18;
            this.botonListarCliente.Text = "Listar Cliente";
            this.botonListarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonListarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonListarCliente.UseVisualStyleBackColor = true;
            this.botonListarCliente.Click += new System.EventHandler(this.botonListarCliente_Click);
            // 
            // botonModificarCliente
            // 
            this.botonModificarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonModificarCliente.FlatAppearance.BorderSize = 0;
            this.botonModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.botonModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModificarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonModificarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificarCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonModificarCliente.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.botonModificarCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.botonModificarCliente.IconSize = 32;
            this.botonModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModificarCliente.Location = new System.Drawing.Point(0, 45);
            this.botonModificarCliente.Name = "botonModificarCliente";
            this.botonModificarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonModificarCliente.Rotation = 0D;
            this.botonModificarCliente.Size = new System.Drawing.Size(220, 45);
            this.botonModificarCliente.TabIndex = 17;
            this.botonModificarCliente.Text = "Modificar Cliente";
            this.botonModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonModificarCliente.UseVisualStyleBackColor = true;
            this.botonModificarCliente.Click += new System.EventHandler(this.botonModificarCliente_Click);
            // 
            // botonRegistrarCliente
            // 
            this.botonRegistrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.botonRegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.botonRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonRegistrarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonRegistrarCliente.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.botonRegistrarCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.botonRegistrarCliente.IconSize = 32;
            this.botonRegistrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistrarCliente.Location = new System.Drawing.Point(0, 0);
            this.botonRegistrarCliente.Name = "botonRegistrarCliente";
            this.botonRegistrarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonRegistrarCliente.Rotation = 0D;
            this.botonRegistrarCliente.Size = new System.Drawing.Size(220, 45);
            this.botonRegistrarCliente.TabIndex = 16;
            this.botonRegistrarCliente.Text = "Registrar Nuevo Cliente";
            this.botonRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonRegistrarCliente.UseVisualStyleBackColor = true;
            this.botonRegistrarCliente.Click += new System.EventHandler(this.botonRegistrarCliente_Click);
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonCerrarSesion.FlatAppearance.BorderSize = 0;
            this.botonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.botonCerrarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.botonCerrarSesion.IconSize = 32;
            this.botonCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCerrarSesion.Location = new System.Drawing.Point(0, 520);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.botonCerrarSesion.Rotation = 0D;
            this.botonCerrarSesion.Size = new System.Drawing.Size(220, 60);
            this.botonCerrarSesion.TabIndex = 16;
            this.botonCerrarSesion.Text = "Cerrar Sesión";
            this.botonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // botonRegistarNuevoCliente
            // 
            this.botonRegistarNuevoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRegistarNuevoCliente.FlatAppearance.BorderSize = 0;
            this.botonRegistarNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistarNuevoCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonRegistarNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistarNuevoCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonRegistarNuevoCliente.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsBy;
            this.botonRegistarNuevoCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.botonRegistarNuevoCliente.IconSize = 32;
            this.botonRegistarNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistarNuevoCliente.Location = new System.Drawing.Point(0, 216);
            this.botonRegistarNuevoCliente.Name = "botonRegistarNuevoCliente";
            this.botonRegistarNuevoCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.botonRegistarNuevoCliente.Rotation = 0D;
            this.botonRegistarNuevoCliente.Size = new System.Drawing.Size(220, 60);
            this.botonRegistarNuevoCliente.TabIndex = 15;
            this.botonRegistarNuevoCliente.Text = "Registrar Nuevo Cliente";
            this.botonRegistarNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistarNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonRegistarNuevoCliente.UseVisualStyleBackColor = true;
            this.botonRegistarNuevoCliente.Click += new System.EventHandler(this.botonRegistarNuevoCliente_Click);
            // 
            // botonPedido
            // 
            this.botonPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonPedido.FlatAppearance.BorderSize = 0;
            this.botonPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPedido.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPedido.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonPedido.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.botonPedido.IconColor = System.Drawing.Color.Gainsboro;
            this.botonPedido.IconSize = 32;
            this.botonPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonPedido.Location = new System.Drawing.Point(0, 156);
            this.botonPedido.Name = "botonPedido";
            this.botonPedido.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.botonPedido.Rotation = 0D;
            this.botonPedido.Size = new System.Drawing.Size(220, 60);
            this.botonPedido.TabIndex = 14;
            this.botonPedido.Text = "Registrar Pedido";
            this.botonPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonPedido.UseVisualStyleBackColor = true;
            this.botonPedido.Click += new System.EventHandler(this.botonCatalogo_Click);
            // 
            // lEmpresa
            // 
            this.lEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lEmpresa.AutoSize = true;
            this.lEmpresa.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmpresa.ForeColor = System.Drawing.Color.Gainsboro;
            this.lEmpresa.Location = new System.Drawing.Point(12, 597);
            this.lEmpresa.Name = "lEmpresa";
            this.lEmpresa.Size = new System.Drawing.Size(82, 9);
            this.lEmpresa.TabIndex = 13;
            this.lEmpresa.Text = "Provisto por Nogal S.A.";
            // 
            // botonInicio
            // 
            this.botonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.botonInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonInicio.Image = ((System.Drawing.Image)(resources.GetObject("botonInicio.Image")));
            this.botonInicio.Location = new System.Drawing.Point(0, 0);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(220, 156);
            this.botonInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonInicio.TabIndex = 0;
            this.botonInicio.TabStop = false;
            this.botonInicio.Click += new System.EventHandler(this.botonInicio_Click);
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.panelEscritorio.Controls.Add(this.labelFecha);
            this.panelEscritorio.Controls.Add(this.labelSaludo);
            this.panelEscritorio.Controls.Add(this.labelHora);
            this.panelEscritorio.Controls.Add(this.pictureUsuario);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 35);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1080, 615);
            this.panelEscritorio.TabIndex = 7;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.labelFecha.Location = new System.Drawing.Point(119, 371);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(173, 63);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "label1";
            // 
            // labelSaludo
            // 
            this.labelSaludo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.labelSaludo.Location = new System.Drawing.Point(301, 24);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(397, 41);
            this.labelSaludo.TabIndex = 2;
            this.labelSaludo.Text = "Bienvenido, Empleado";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.labelHora.Location = new System.Drawing.Point(368, 494);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(249, 91);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "label1";
            // 
            // pictureUsuario
            // 
            this.pictureUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureUsuario.Image")));
            this.pictureUsuario.Location = new System.Drawing.Point(360, 77);
            this.pictureUsuario.Name = "pictureUsuario";
            this.pictureUsuario.Size = new System.Drawing.Size(275, 252);
            this.pictureUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUsuario.TabIndex = 0;
            this.pictureUsuario.TabStop = false;
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelMenuVertical);
            this.Controls.Add(this.panelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.panelTitulo.ResumeLayout(false);
            this.panelMenuVertical.ResumeLayout(false);
            this.panelMenuVertical.PerformLayout();
            this.panelSubMenuCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonInicio)).EndInit();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button buttonRestaurar;
        private System.Windows.Forms.Button buttonMinimizar;
        private System.Windows.Forms.Button buttonMaximizar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Panel panelMenuVertical;
        private FontAwesome.Sharp.IconButton botonCerrarSesion;
        private FontAwesome.Sharp.IconButton botonRegistarNuevoCliente;
        private FontAwesome.Sharp.IconButton botonPedido;
        private System.Windows.Forms.Label lEmpresa;
        private System.Windows.Forms.PictureBox botonInicio;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.PictureBox pictureUsuario;
        private System.Windows.Forms.Timer horaFecha;
        private FontAwesome.Sharp.IconButton bHome;
        private System.Windows.Forms.Panel panelSubMenuCliente;
        private FontAwesome.Sharp.IconButton botonListarCliente;
        private FontAwesome.Sharp.IconButton botonModificarCliente;
        private FontAwesome.Sharp.IconButton botonRegistrarCliente;
    }
}