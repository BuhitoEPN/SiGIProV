using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SiGIProV.Interfaces
{
    public partial class ModificacionMateriaPrima : Form
    {
        public ModificacionMateriaPrima()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Modificar Materia Prima";
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //DRAG FORM:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
