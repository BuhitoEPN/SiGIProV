namespace SiGIProV.Interfaces
{
    partial class InventarioMateriaPrima
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.lBuscar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bEditarProducto = new System.Windows.Forms.Button();
            this.bAgregarProducto = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bBuscar);
            this.panel1.Controls.Add(this.tbBusqueda);
            this.panel1.Controls.Add(this.lBuscar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 576);
            this.panel1.TabIndex = 2;
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(940, 23);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(89, 36);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tbBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusqueda.ForeColor = System.Drawing.Color.LightGray;
            this.tbBusqueda.Location = new System.Drawing.Point(134, 32);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(750, 20);
            this.tbBusqueda.TabIndex = 2;
            this.tbBusqueda.Text = "Escriba la materia prima que desea buscar...";
            // 
            // lBuscar
            // 
            this.lBuscar.AutoSize = true;
            this.lBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.lBuscar.Location = new System.Drawing.Point(10, 31);
            this.lBuscar.Name = "lBuscar";
            this.lBuscar.Size = new System.Drawing.Size(92, 21);
            this.lBuscar.TabIndex = 1;
            this.lBuscar.Text = "Búsqueda:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(982, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1060, 572);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 134;
            this.lineShape1.X2 = 894;
            this.lineShape1.Y1 = 55;
            this.lineShape1.Y2 = 55;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.bEditarProducto);
            this.panel2.Controls.Add(this.bAgregarProducto);
            this.panel2.Controls.Add(this.bRegresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 52);
            this.panel2.TabIndex = 22;
            // 
            // bEditarProducto
            // 
            this.bEditarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bEditarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEditarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bEditarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditarProducto.Location = new System.Drawing.Point(22, 9);
            this.bEditarProducto.Name = "bEditarProducto";
            this.bEditarProducto.Size = new System.Drawing.Size(170, 40);
            this.bEditarProducto.TabIndex = 11;
            this.bEditarProducto.Text = "Editar Producto";
            this.bEditarProducto.UseVisualStyleBackColor = false;
            // 
            // bAgregarProducto
            // 
            this.bAgregarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bAgregarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAgregarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregarProducto.Location = new System.Drawing.Point(415, 9);
            this.bAgregarProducto.Name = "bAgregarProducto";
            this.bAgregarProducto.Size = new System.Drawing.Size(170, 40);
            this.bAgregarProducto.TabIndex = 10;
            this.bAgregarProducto.Text = "Agregar Producto";
            this.bAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // bRegresar
            // 
            this.bRegresar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bRegresar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.Location = new System.Drawing.Point(824, 6);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(190, 40);
            this.bRegresar.TabIndex = 9;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = false;
            // 
            // InventarioMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InventarioMateriaPrima";
            this.Text = "InventarioMateriaPrima";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label lBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bEditarProducto;
        private System.Windows.Forms.Button bAgregarProducto;
        private System.Windows.Forms.Button bRegresar;
    }
}