using SiGIProV.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiGIProV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "SiGIProV-RUESCO S.A.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Bodega")
                {
                    this.Hide();
                    Bodega bodega = new Bodega();
                    bodega.ShowDialog();
                }
                else if(comboBox1.SelectedItem.ToString() == "Producción")
                {
                    this.Hide();
                    Produccion produccion = new Produccion();
                    produccion.ShowDialog();
                }
                else if (comboBox1.SelectedItem.ToString() == "Ventas")
                {
                    this.Hide();
                    Ventas ventas = new Ventas();
                    ventas.ShowDialog();
                }
                else if (comboBox1.SelectedItem.ToString() == "Administrador")
                {
                    this.Hide();
                    Administrador admi = new Administrador();
                    admi.ShowDialog();
                }
            }
            else { MessageBox.Show("No ha seleccionado ningún rol"); }
        }

        private void tUsuario_Enter(object sender, EventArgs e)
        {
            if (tUsuario.Text == "USUARIO")
            {
                tUsuario.Text = "";
                tUsuario.ForeColor = Color.LightGray;
            }
        }

        private void tUsuario_Leave(object sender, EventArgs e)
        {
            if (tUsuario.Text == "")
            {
                tUsuario.Text = "USUARIO";
                tUsuario.ForeColor = Color.DimGray;
            }
        }

        private void tPassword_Enter(object sender, EventArgs e)
        {
            if (tPassword.Text == "CONTRASEÑA")
            {
                tPassword.Text = "";
                tPassword.ForeColor = Color.LightGray;
                tPassword.UseSystemPasswordChar = true;
            }
        }

        private void tPassword_Leave(object sender, EventArgs e)
        {
            if (tPassword.Text == "")
            {
                tPassword.Text = "CONTRASEÑA";
                tPassword.ForeColor = Color.DimGray;
                tPassword.UseSystemPasswordChar = false;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Seleccione su rol...")
            {
                comboBox1.Text = "";
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Seleccione su rol...";
            }
        }
    }
}
