using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV.Interfaces
{
    public partial class AniadirProducto : Form
    {
        public AniadirProducto()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Formulario Añadir Producto";
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
