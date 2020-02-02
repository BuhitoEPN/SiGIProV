using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiGIProV.Interfaces;

namespace SiGIProV.Interfaces
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Formulario Agregar Producto";
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            AniadirProducto prodAniaFormula = new AniadirProducto();
            prodAniaFormula.ShowDialog();
        }
    }
}
