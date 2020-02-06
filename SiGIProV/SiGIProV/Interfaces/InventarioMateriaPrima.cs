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
    public partial class InventarioMateriaPrima : Form
    {
        public InventarioMateriaPrima()
        {
            InitializeComponent();
        }

        private void bRegistrarMateriaPrima_Click(object sender, EventArgs e)
        {
            RegistrarMateriaPrima registrarmateriaprima = new RegistrarMateriaPrima();
            registrarmateriaprima.ShowDialog();
        }

        private void bAumentarStock_Click(object sender, EventArgs e)
        {
            IngresoDeMateriaPrima ingresomateriaprima = new IngresoDeMateriaPrima();
            ingresomateriaprima.ShowDialog();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            ModificacionMateriaPrima modificarmateriaprima = new ModificacionMateriaPrima();
            modificarmateriaprima.ShowDialog();
        }
    }
}
