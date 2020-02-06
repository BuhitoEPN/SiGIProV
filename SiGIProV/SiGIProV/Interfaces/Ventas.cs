using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SiGIProV.Interfaces;
using System.Runtime.InteropServices;

namespace SiGIProV.Interfaces
{
    public partial class Ventas : Form
    {
        //Fields

        private IconButton currentButton;
        private Panel leftBorderButon;
        private Form currentChildForm;

        public Ventas()
        {
            InitializeComponent();

            this.CenterToScreen();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            leftBorderButon = new Panel();
            leftBorderButon.Size = new Size(6, 60);
            panelMenuVertical.Controls.Add(leftBorderButon);
        }
        
        //Métodos Propios:

        //Colores:

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(216, 16, 92);
            public static Color color2 = Color.FromArgb(0, 36, 207);
            public static Color color3 = Color.FromArgb(216, 16, 92);
            public static Color color4 = Color.FromArgb(0, 164, 239);
        }

        //Selección de botón:

        private void ActivateButton(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButton();
                //Button:
                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                //Left Border Buton:

                leftBorderButon.BackColor = color;
                leftBorderButon.Location = new Point(0, currentButton.Location.Y);
                leftBorderButon.Visible = true;
                leftBorderButon.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(26, 32, 40);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Volver al panel escritorio:

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Permite abrir solo un formulario:
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderButon.Visible = false;
        }


        //Funcionalidad de los botones:

        //Fecha y hora:

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        //Funcionalidad de los botones superiores:

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            buttonRestaurar.Visible = false;
            buttonMaximizar.Visible = true;
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            buttonMaximizar.Visible = false;
            buttonRestaurar.Visible = true;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Funcionalidad de los botones del menú lateral:

        private void botonCatalogo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //
        }

        private void botonRegistarNuevoCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            //
        }

        private void botonInicio_Click(object sender, EventArgs e)
        {
            try
            {
                currentChildForm.Close();
                Reset();
            }
            catch
            {

            }

        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        //Mover formulario con panel superior:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            try
            {
                currentChildForm.Close();
                Reset();
            }
            catch
            {

            }

            ActivateButton(sender, RGBColors.color4);

        }
            
    }
}
