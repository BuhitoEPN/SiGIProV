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
            this.buttonRestaurar = new System.Windows.Forms.Button();
            this.buttonMinimizar = new System.Windows.Forms.Button();
            this.buttonMaximizar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.botonCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuVentas = new System.Windows.Forms.Panel();
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
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(208)))), ((int)(((byte)(233)))));
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
            this.botonCerrarSesion.Location = new System.Drawing.Point(0, 606);
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
            this.panelSubMenuVentas.Controls.Add(this.botonRegistarCliente);
            this.panelSubMenuVentas.Controls.Add(this.botonCatalogo);
            this.panelSubMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVentas.Location = new System.Drawing.Point(0, 506);
            this.panelSubMenuVentas.Name = "panelSubMenuVentas";
            this.panelSubMenuVentas.Size = new System.Drawing.Size(203, 100);
            this.panelSubMenuVentas.TabIndex = 20;
            // 
            // botonRegistarCliente
            // 
            this.botonRegistarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRegistarCliente.FlatAppearance.BorderSize = 0;
            this.botonRegistarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(16)))), ((int)(((byte)(92)))));
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
            this.botonCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(16)))), ((int)(((byte)(92)))));
            this.botonCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCatalogo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.botonCatalogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCatalogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonCatalogo.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.botonCatalogo.IconColor = System.Drawing.Color.Gainsboro;
            this.botonCatalogo.IconSize = 32;
            this.botonCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonCatalogo.Location = new System.Drawing.Point(0, 0);
            this.botonCatalogo.Name = "botonCatalogo";
            this.botonCatalogo.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.botonCatalogo.Rotation = 0D;
            this.botonCatalogo.Size = new System.Drawing.Size(203, 45);
            this.botonCatalogo.TabIndex = 16;
            this.botonCatalogo.Text = "Catálogo";
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
    }
}