namespace SiGIProV.Interfaces
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.bHome = new FontAwesome.Sharp.IconButton();
            this.buttonRestaurar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.subMenuProveedores = new System.Windows.Forms.Panel();
            this.botonListarProveedor = new FontAwesome.Sharp.IconButton();
            this.botonModificarProveedor = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuEmpleados = new System.Windows.Forms.Panel();
            this.botonListarEmpleado = new FontAwesome.Sharp.IconButton();
            this.botonModificarEmpleado = new FontAwesome.Sharp.IconButton();
            this.botonRegistrarEmpleado = new FontAwesome.Sharp.IconButton();
            this.botonEmpleados = new FontAwesome.Sharp.IconButton();
            this.botonCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuVentas = new System.Windows.Forms.Panel();
            this.botonListarCliente = new FontAwesome.Sharp.IconButton();
            this.botonModificarCliente = new FontAwesome.Sharp.IconButton();
            this.botonRegistarCliente = new FontAwesome.Sharp.IconButton();
            this.botonCatalogo = new FontAwesome.Sharp.IconButton();
            this.botonVentas = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuProduccion = new System.Windows.Forms.Panel();
            this.botonAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.botonElaborarProducto = new FontAwesome.Sharp.IconButton();
            this.botonProduccion = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuBodega = new System.Windows.Forms.Panel();
            this.botonProductosFinales = new FontAwesome.Sharp.IconButton();
            this.botonMateriaPrima = new FontAwesome.Sharp.IconButton();
            this.botonBodega = new FontAwesome.Sharp.IconButton();
            this.botonInicio = new System.Windows.Forms.PictureBox();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureUsuario = new System.Windows.Forms.PictureBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.panelTitulo.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.subMenuProveedores.SuspendLayout();
            this.panelSubMenuEmpleados.SuspendLayout();
            this.panelSubMenuVentas.SuspendLayout();
            this.panelSubMenuProduccion.SuspendLayout();
            this.panelSubMenuBodega.SuspendLayout();
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
            this.panelTitulo.TabIndex = 2;
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
            this.bHome.TabIndex = 13;
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
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuLateral.Controls.Add(this.subMenuProveedores);
            this.panelMenuLateral.Controls.Add(this.iconButton6);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuEmpleados);
            this.panelMenuLateral.Controls.Add(this.botonEmpleados);
            this.panelMenuLateral.Controls.Add(this.botonCerrarSesion);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuVentas);
            this.panelMenuLateral.Controls.Add(this.botonVentas);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuProduccion);
            this.panelMenuLateral.Controls.Add(this.botonProduccion);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuBodega);
            this.panelMenuLateral.Controls.Add(this.botonBodega);
            this.panelMenuLateral.Controls.Add(this.botonInicio);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 35);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(220, 615);
            this.panelMenuLateral.TabIndex = 3;
            // 
            // subMenuProveedores
            // 
            this.subMenuProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.subMenuProveedores.Controls.Add(this.botonListarProveedor);
            this.subMenuProveedores.Controls.Add(this.botonModificarProveedor);
            this.subMenuProveedores.Controls.Add(this.iconButton5);
            this.subMenuProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProveedores.Location = new System.Drawing.Point(0, 930);
            this.subMenuProveedores.Name = "subMenuProveedores";
            this.subMenuProveedores.Size = new System.Drawing.Size(203, 139);
            this.subMenuProveedores.TabIndex = 25;
            // 
            // botonListarProveedor
            // 
            this.botonListarProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonListarProveedor.FlatAppearance.BorderSize = 0;
            this.botonListarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(233)))));
            this.botonListarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonListarProveedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonListarProveedor.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.botonListarProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonListarProveedor.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.botonListarProveedor.IconColor = System.Drawing.Color.Gainsboro;
            this.botonListarProveedor.IconSize = 32;
            this.botonListarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonListarProveedor.Location = new System.Drawing.Point(0, 90);
            this.botonListarProveedor.Name = "botonListarProveedor";
            this.botonListarProveedor.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonListarProveedor.Rotation = 0D;
            this.botonListarProveedor.Size = new System.Drawing.Size(203, 45);
            this.botonListarProveedor.TabIndex = 18;
            this.botonListarProveedor.Text = "Listar Proveedor";
            this.botonListarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonListarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonListarProveedor.UseVisualStyleBackColor = true;
            this.botonListarProveedor.Click += new System.EventHandler(this.botonListarProveedor_Click);
            // 
            // botonModificarProveedor
            // 
            this.botonModificarProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonModificarProveedor.FlatAppearance.BorderSize = 0;
            this.botonModificarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(233)))));
            this.botonModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModificarProveedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonModificarProveedor.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.botonModificarProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonModificarProveedor.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.botonModificarProveedor.IconColor = System.Drawing.Color.Gainsboro;
            this.botonModificarProveedor.IconSize = 32;
            this.botonModificarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModificarProveedor.Location = new System.Drawing.Point(0, 45);
            this.botonModificarProveedor.Name = "botonModificarProveedor";
            this.botonModificarProveedor.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonModificarProveedor.Rotation = 0D;
            this.botonModificarProveedor.Size = new System.Drawing.Size(203, 45);
            this.botonModificarProveedor.TabIndex = 17;
            this.botonModificarProveedor.Text = "Modificar Proveedor";
            this.botonModificarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModificarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonModificarProveedor.UseVisualStyleBackColor = true;
            this.botonModificarProveedor.Click += new System.EventHandler(this.botonModificarProveedor_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(233)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(203, 45);
            this.iconButton5.TabIndex = 16;
            this.iconButton5.Text = "Registrar Nuevo Proveedor";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconButton6.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconSize = 32;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 880);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(203, 50);
            this.iconButton6.TabIndex = 24;
            this.iconButton6.Text = "Proveedores";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // panelSubMenuEmpleados
            // 
            this.panelSubMenuEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuEmpleados.Controls.Add(this.botonListarEmpleado);
            this.panelSubMenuEmpleados.Controls.Add(this.botonModificarEmpleado);
            this.panelSubMenuEmpleados.Controls.Add(this.botonRegistrarEmpleado);
            this.panelSubMenuEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEmpleados.Location = new System.Drawing.Point(0, 740);
            this.panelSubMenuEmpleados.Name = "panelSubMenuEmpleados";
            this.panelSubMenuEmpleados.Size = new System.Drawing.Size(203, 140);
            this.panelSubMenuEmpleados.TabIndex = 23;
            // 
            // botonListarEmpleado
            // 
            this.botonListarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonListarEmpleado.FlatAppearance.BorderSize = 0;
            this.botonListarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(16)))), ((int)(((byte)(92)))));
            this.botonListarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonListarEmpleado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonListarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.botonListarEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonListarEmpleado.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.botonListarEmpleado.IconColor = System.Drawing.Color.Gainsboro;
            this.botonListarEmpleado.IconSize = 32;
            this.botonListarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonListarEmpleado.Location = new System.Drawing.Point(0, 90);
            this.botonListarEmpleado.Name = "botonListarEmpleado";
            this.botonListarEmpleado.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonListarEmpleado.Rotation = 0D;
            this.botonListarEmpleado.Size = new System.Drawing.Size(203, 45);
            this.botonListarEmpleado.TabIndex = 18;
            this.botonListarEmpleado.Text = "Listar Empleado";
            this.botonListarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonListarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonListarEmpleado.UseVisualStyleBackColor = true;
            this.botonListarEmpleado.Click += new System.EventHandler(this.botonListarEmpleado_Click);
            // 
            // botonModificarEmpleado
            // 
            this.botonModificarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonModificarEmpleado.FlatAppearance.BorderSize = 0;
            this.botonModificarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(16)))), ((int)(((byte)(92)))));
            this.botonModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonModificarEmpleado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonModificarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.botonModificarEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonModificarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.botonModificarEmpleado.IconColor = System.Drawing.Color.Gainsboro;
            this.botonModificarEmpleado.IconSize = 32;
            this.botonModificarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModificarEmpleado.Location = new System.Drawing.Point(0, 45);
            this.botonModificarEmpleado.Name = "botonModificarEmpleado";
            this.botonModificarEmpleado.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonModificarEmpleado.Rotation = 0D;
            this.botonModificarEmpleado.Size = new System.Drawing.Size(203, 45);
            this.botonModificarEmpleado.TabIndex = 17;
            this.botonModificarEmpleado.Text = "Modificar Empleado";
            this.botonModificarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModificarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonModificarEmpleado.UseVisualStyleBackColor = true;
            this.botonModificarEmpleado.Click += new System.EventHandler(this.botonModificarEmpleado_Click);
            // 
            // botonRegistrarEmpleado
            // 
            this.botonRegistrarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRegistrarEmpleado.FlatAppearance.BorderSize = 0;
            this.botonRegistrarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(16)))), ((int)(((byte)(92)))));
            this.botonRegistrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrarEmpleado.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonRegistrarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.botonRegistrarEmpleado.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonRegistrarEmpleado.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            this.botonRegistrarEmpleado.IconColor = System.Drawing.Color.Gainsboro;
            this.botonRegistrarEmpleado.IconSize = 32;
            this.botonRegistrarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistrarEmpleado.Location = new System.Drawing.Point(0, 0);
            this.botonRegistrarEmpleado.Name = "botonRegistrarEmpleado";
            this.botonRegistrarEmpleado.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonRegistrarEmpleado.Rotation = 0D;
            this.botonRegistrarEmpleado.Size = new System.Drawing.Size(203, 45);
            this.botonRegistrarEmpleado.TabIndex = 16;
            this.botonRegistrarEmpleado.Text = "Registrar Nuevo Empleado";
            this.botonRegistrarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistrarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.botonRegistrarEmpleado.Click += new System.EventHandler(this.botonRegistrarEmpleado_Click);
            // 
            // botonEmpleados
            // 
            this.botonEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonEmpleados.FlatAppearance.BorderSize = 0;
            this.botonEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEmpleados.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEmpleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.botonEmpleados.IconColor = System.Drawing.Color.Gainsboro;
            this.botonEmpleados.IconSize = 32;
            this.botonEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonEmpleados.Location = new System.Drawing.Point(0, 690);
            this.botonEmpleados.Name = "botonEmpleados";
            this.botonEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.botonEmpleados.Rotation = 0D;
            this.botonEmpleados.Size = new System.Drawing.Size(203, 50);
            this.botonEmpleados.TabIndex = 22;
            this.botonEmpleados.Text = "Empleados";
            this.botonEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonEmpleados.UseVisualStyleBackColor = true;
            this.botonEmpleados.Click += new System.EventHandler(this.botonEmpleados_Click);
            // 
            // botonCerrarSesion
            // 
            this.botonCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botonCerrarSesion.FlatAppearance.BorderSize = 0;
            this.botonCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(92)))));
            this.botonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrarSesion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.botonCerrarSesion.IconColor = System.Drawing.Color.Gainsboro;
            this.botonCerrarSesion.IconSize = 32;
            this.botonCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCerrarSesion.Location = new System.Drawing.Point(0, 1069);
            this.botonCerrarSesion.Name = "botonCerrarSesion";
            this.botonCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.botonCerrarSesion.Rotation = 0D;
            this.botonCerrarSesion.Size = new System.Drawing.Size(203, 60);
            this.botonCerrarSesion.TabIndex = 21;
            this.botonCerrarSesion.Text = "Cerrar Sesión";
            this.botonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonCerrarSesion.UseVisualStyleBackColor = true;
            this.botonCerrarSesion.Click += new System.EventHandler(this.botonCerrarSesion_Click);
            // 
            // panelSubMenuVentas
            // 
            this.panelSubMenuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuVentas.Controls.Add(this.botonListarCliente);
            this.panelSubMenuVentas.Controls.Add(this.botonModificarCliente);
            this.panelSubMenuVentas.Controls.Add(this.botonRegistarCliente);
            this.panelSubMenuVentas.Controls.Add(this.botonCatalogo);
            this.panelSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVentas.Location = new System.Drawing.Point(0, 506);
            this.panelSubMenuVentas.Name = "panelSubMenuVentas";
            this.panelSubMenuVentas.Size = new System.Drawing.Size(203, 184);
            this.panelSubMenuVentas.TabIndex = 20;
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
            this.botonListarCliente.Location = new System.Drawing.Point(0, 135);
            this.botonListarCliente.Name = "botonListarCliente";
            this.botonListarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonListarCliente.Rotation = 0D;
            this.botonListarCliente.Size = new System.Drawing.Size(203, 45);
            this.botonListarCliente.TabIndex = 20;
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
            this.botonModificarCliente.Location = new System.Drawing.Point(0, 90);
            this.botonModificarCliente.Name = "botonModificarCliente";
            this.botonModificarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonModificarCliente.Rotation = 0D;
            this.botonModificarCliente.Size = new System.Drawing.Size(203, 45);
            this.botonModificarCliente.TabIndex = 19;
            this.botonModificarCliente.Text = "Modificar Cliente";
            this.botonModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonModificarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonModificarCliente.UseVisualStyleBackColor = true;
            this.botonModificarCliente.Click += new System.EventHandler(this.botonModificarCliente_Click);
            // 
            // botonRegistarCliente
            // 
            this.botonRegistarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRegistarCliente.FlatAppearance.BorderSize = 0;
            this.botonRegistarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.botonRegistarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistarCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonRegistarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistarCliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonRegistarCliente.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.botonRegistarCliente.IconColor = System.Drawing.Color.Gainsboro;
            this.botonRegistarCliente.IconSize = 32;
            this.botonRegistarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistarCliente.Location = new System.Drawing.Point(0, 45);
            this.botonRegistarCliente.Name = "botonRegistarCliente";
            this.botonRegistarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonRegistarCliente.Rotation = 0D;
            this.botonRegistarCliente.Size = new System.Drawing.Size(203, 45);
            this.botonRegistarCliente.TabIndex = 17;
            this.botonRegistarCliente.Text = "Registrar Nuevo Cliente";
            this.botonRegistarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonRegistarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonRegistarCliente.UseVisualStyleBackColor = true;
            this.botonRegistarCliente.Click += new System.EventHandler(this.botonRegistarCliente_Click);
            // 
            // botonCatalogo
            // 
            this.botonCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonCatalogo.FlatAppearance.BorderSize = 0;
            this.botonCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(153)))), ((int)(((byte)(43)))));
            this.botonCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCatalogo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonCatalogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCatalogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonCatalogo.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.botonCatalogo.IconColor = System.Drawing.Color.Gainsboro;
            this.botonCatalogo.IconSize = 32;
            this.botonCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCatalogo.Location = new System.Drawing.Point(0, 0);
            this.botonCatalogo.Name = "botonCatalogo";
            this.botonCatalogo.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonCatalogo.Rotation = 0D;
            this.botonCatalogo.Size = new System.Drawing.Size(203, 45);
            this.botonCatalogo.TabIndex = 16;
            this.botonCatalogo.Text = "Registrar Pedido";
            this.botonCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonCatalogo.UseVisualStyleBackColor = true;
            this.botonCatalogo.Click += new System.EventHandler(this.botonCatalogo_Click);
            // 
            // botonVentas
            // 
            this.botonVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonVentas.FlatAppearance.BorderSize = 0;
            this.botonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonVentas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.botonVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.botonVentas.IconSize = 32;
            this.botonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonVentas.Location = new System.Drawing.Point(0, 456);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.botonVentas.Rotation = 0D;
            this.botonVentas.Size = new System.Drawing.Size(203, 50);
            this.botonVentas.TabIndex = 19;
            this.botonVentas.Text = "Ventas";
            this.botonVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonVentas.UseVisualStyleBackColor = true;
            this.botonVentas.Click += new System.EventHandler(this.botonVentas_Click);
            // 
            // panelSubMenuProduccion
            // 
            this.panelSubMenuProduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuProduccion.Controls.Add(this.botonAgregarProducto);
            this.panelSubMenuProduccion.Controls.Add(this.botonElaborarProducto);
            this.panelSubMenuProduccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuProduccion.Location = new System.Drawing.Point(0, 356);
            this.panelSubMenuProduccion.Name = "panelSubMenuProduccion";
            this.panelSubMenuProduccion.Size = new System.Drawing.Size(203, 100);
            this.panelSubMenuProduccion.TabIndex = 18;
            // 
            // botonAgregarProducto
            // 
            this.botonAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAgregarProducto.FlatAppearance.BorderSize = 0;
            this.botonAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(168)))), ((int)(((byte)(45)))));
            this.botonAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.botonAgregarProducto.IconColor = System.Drawing.Color.Gainsboro;
            this.botonAgregarProducto.IconSize = 32;
            this.botonAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAgregarProducto.Location = new System.Drawing.Point(0, 45);
            this.botonAgregarProducto.Name = "botonAgregarProducto";
            this.botonAgregarProducto.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonAgregarProducto.Rotation = 0D;
            this.botonAgregarProducto.Size = new System.Drawing.Size(203, 45);
            this.botonAgregarProducto.TabIndex = 17;
            this.botonAgregarProducto.Text = "Agregar Producto";
            this.botonAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonAgregarProducto.UseVisualStyleBackColor = true;
            this.botonAgregarProducto.Click += new System.EventHandler(this.botonAgregarProducto_Click);
            // 
            // botonElaborarProducto
            // 
            this.botonElaborarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonElaborarProducto.FlatAppearance.BorderSize = 0;
            this.botonElaborarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(168)))), ((int)(((byte)(45)))));
            this.botonElaborarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonElaborarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonElaborarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonElaborarProducto.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonElaborarProducto.IconChar = FontAwesome.Sharp.IconChar.Flask;
            this.botonElaborarProducto.IconColor = System.Drawing.Color.Gainsboro;
            this.botonElaborarProducto.IconSize = 32;
            this.botonElaborarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonElaborarProducto.Location = new System.Drawing.Point(0, 0);
            this.botonElaborarProducto.Name = "botonElaborarProducto";
            this.botonElaborarProducto.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonElaborarProducto.Rotation = 0D;
            this.botonElaborarProducto.Size = new System.Drawing.Size(203, 45);
            this.botonElaborarProducto.TabIndex = 16;
            this.botonElaborarProducto.Text = "Elaborar Producto";
            this.botonElaborarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonElaborarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonElaborarProducto.UseVisualStyleBackColor = true;
            this.botonElaborarProducto.Click += new System.EventHandler(this.botonElaborarProducto_Click);
            // 
            // botonProduccion
            // 
            this.botonProduccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonProduccion.FlatAppearance.BorderSize = 0;
            this.botonProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProduccion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonProduccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProduccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonProduccion.IconChar = FontAwesome.Sharp.IconChar.Seedling;
            this.botonProduccion.IconColor = System.Drawing.Color.Gainsboro;
            this.botonProduccion.IconSize = 32;
            this.botonProduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonProduccion.Location = new System.Drawing.Point(0, 306);
            this.botonProduccion.Name = "botonProduccion";
            this.botonProduccion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.botonProduccion.Rotation = 0D;
            this.botonProduccion.Size = new System.Drawing.Size(203, 50);
            this.botonProduccion.TabIndex = 17;
            this.botonProduccion.Text = "Producción";
            this.botonProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonProduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonProduccion.UseVisualStyleBackColor = true;
            this.botonProduccion.Click += new System.EventHandler(this.botonProduccion_Click);
            // 
            // panelSubMenuBodega
            // 
            this.panelSubMenuBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuBodega.Controls.Add(this.botonProductosFinales);
            this.panelSubMenuBodega.Controls.Add(this.botonMateriaPrima);
            this.panelSubMenuBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuBodega.Location = new System.Drawing.Point(0, 206);
            this.panelSubMenuBodega.Name = "panelSubMenuBodega";
            this.panelSubMenuBodega.Size = new System.Drawing.Size(203, 100);
            this.panelSubMenuBodega.TabIndex = 16;
            // 
            // botonProductosFinales
            // 
            this.botonProductosFinales.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonProductosFinales.FlatAppearance.BorderSize = 0;
            this.botonProductosFinales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.botonProductosFinales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonProductosFinales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonProductosFinales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProductosFinales.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonProductosFinales.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.botonProductosFinales.IconColor = System.Drawing.Color.Gainsboro;
            this.botonProductosFinales.IconSize = 32;
            this.botonProductosFinales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonProductosFinales.Location = new System.Drawing.Point(0, 45);
            this.botonProductosFinales.Name = "botonProductosFinales";
            this.botonProductosFinales.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonProductosFinales.Rotation = 0D;
            this.botonProductosFinales.Size = new System.Drawing.Size(203, 45);
            this.botonProductosFinales.TabIndex = 17;
            this.botonProductosFinales.Text = "Inventario de Productos Finales";
            this.botonProductosFinales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonProductosFinales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonProductosFinales.UseVisualStyleBackColor = true;
            this.botonProductosFinales.Click += new System.EventHandler(this.botonProductosFinales_Click);
            // 
            // botonMateriaPrima
            // 
            this.botonMateriaPrima.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonMateriaPrima.FlatAppearance.BorderSize = 0;
            this.botonMateriaPrima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.botonMateriaPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMateriaPrima.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonMateriaPrima.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMateriaPrima.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonMateriaPrima.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.botonMateriaPrima.IconColor = System.Drawing.Color.Gainsboro;
            this.botonMateriaPrima.IconSize = 32;
            this.botonMateriaPrima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMateriaPrima.Location = new System.Drawing.Point(0, 0);
            this.botonMateriaPrima.Name = "botonMateriaPrima";
            this.botonMateriaPrima.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonMateriaPrima.Rotation = 0D;
            this.botonMateriaPrima.Size = new System.Drawing.Size(203, 45);
            this.botonMateriaPrima.TabIndex = 16;
            this.botonMateriaPrima.Text = "Inventario de Materia Prima";
            this.botonMateriaPrima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMateriaPrima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonMateriaPrima.UseVisualStyleBackColor = true;
            this.botonMateriaPrima.Click += new System.EventHandler(this.botonMateriaPrima_Click);
            // 
            // botonBodega
            // 
            this.botonBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonBodega.FlatAppearance.BorderSize = 0;
            this.botonBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBodega.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonBodega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBodega.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonBodega.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.botonBodega.IconColor = System.Drawing.Color.Gainsboro;
            this.botonBodega.IconSize = 32;
            this.botonBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBodega.Location = new System.Drawing.Point(0, 156);
            this.botonBodega.Name = "botonBodega";
            this.botonBodega.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.botonBodega.Rotation = 0D;
            this.botonBodega.Size = new System.Drawing.Size(203, 50);
            this.botonBodega.TabIndex = 15;
            this.botonBodega.Text = "Bodega";
            this.botonBodega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonBodega.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonBodega.UseVisualStyleBackColor = true;
            this.botonBodega.Click += new System.EventHandler(this.botonBodega_Click);
            // 
            // botonInicio
            // 
            this.botonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.botonInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonInicio.Image = ((System.Drawing.Image)(resources.GetObject("botonInicio.Image")));
            this.botonInicio.Location = new System.Drawing.Point(0, 0);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(203, 156);
            this.botonInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.botonInicio.TabIndex = 1;
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
            this.panelEscritorio.TabIndex = 4;
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
            this.labelSaludo.Location = new System.Drawing.Point(275, 24);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(459, 41);
            this.labelSaludo.TabIndex = 2;
            this.labelSaludo.Text = "Bienvenido, Administrador";
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
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panelTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrador";
            this.Opacity = 0.98D;
            this.Text = "Administrador";
            this.panelTitulo.ResumeLayout(false);
            this.panelMenuLateral.ResumeLayout(false);
            this.subMenuProveedores.ResumeLayout(false);
            this.panelSubMenuEmpleados.ResumeLayout(false);
            this.panelSubMenuVentas.ResumeLayout(false);
            this.panelSubMenuProduccion.ResumeLayout(false);
            this.panelSubMenuBodega.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelSubMenuBodega;
        private FontAwesome.Sharp.IconButton botonBodega;
        private System.Windows.Forms.PictureBox botonInicio;
        private FontAwesome.Sharp.IconButton botonProductosFinales;
        private FontAwesome.Sharp.IconButton botonMateriaPrima;
        private System.Windows.Forms.Panel panelSubMenuVentas;
        private FontAwesome.Sharp.IconButton botonRegistarCliente;
        private FontAwesome.Sharp.IconButton botonCatalogo;
        private FontAwesome.Sharp.IconButton botonVentas;
        private System.Windows.Forms.Panel panelSubMenuProduccion;
        private FontAwesome.Sharp.IconButton botonAgregarProducto;
        private FontAwesome.Sharp.IconButton botonElaborarProducto;
        private FontAwesome.Sharp.IconButton botonProduccion;
        private FontAwesome.Sharp.IconButton botonCerrarSesion;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.PictureBox pictureUsuario;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer horaFecha;
        private FontAwesome.Sharp.IconButton bHome;
        private System.Windows.Forms.Panel subMenuProveedores;
        private FontAwesome.Sharp.IconButton botonListarProveedor;
        private FontAwesome.Sharp.IconButton botonModificarProveedor;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Panel panelSubMenuEmpleados;
        private FontAwesome.Sharp.IconButton botonListarEmpleado;
        private FontAwesome.Sharp.IconButton botonModificarEmpleado;
        private FontAwesome.Sharp.IconButton botonRegistrarEmpleado;
        private FontAwesome.Sharp.IconButton botonEmpleados;
        private FontAwesome.Sharp.IconButton botonListarCliente;
        private FontAwesome.Sharp.IconButton botonModificarCliente;
    }
}