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
    public partial class Administrador : Form
    {
        //Fields:
        private IconButton currentButton;
        private Panel leftBorderButon;
        private Form currentChildForm;

        public Administrador()
        {
            InitializeComponent();
            CustomizeDesign();

            this.CenterToScreen();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            leftBorderButon = new Panel();
            leftBorderButon.Size = new Size(6, 60);
            panelMenuLateral.Controls.Add(leftBorderButon);
        }

        //Comportamiento botones ventana:

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

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        //
        //Drag Form:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //

        //Resaltar botones:

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(116, 168, 45);
            public static Color color3 = Color.FromArgb(216, 16, 92);
            public static Color color4 = Color.FromArgb(0, 164, 239);
        }

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
        //

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

        //Comportamiento SubMenús:

        private void CustomizeDesign()
        {
            panelSubMenuBodega.Visible = false;
            panelSubMenuProduccion.Visible = false;
            panelSubMenuVentas.Visible = false;
        }

        private void HideSubmenu()
        {
            if (panelSubMenuBodega.Visible == true)
                panelSubMenuBodega.Visible = false;
            if (panelSubMenuProduccion.Visible == true)
                panelSubMenuProduccion.Visible = false;
            if (panelSubMenuVentas.Visible == true)
                panelSubMenuVentas.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void botonBodega_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuBodega);
            ActivateButton(sender, RGBColors.color1);
        }

        private void botonMateriaPrima_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InventarioMateriaPrima());
            HideSubmenu();
        }

        private void botonProductosFinales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InventarioProductosTerminados());
            HideSubmenu();
        }

        private void botonProduccion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuProduccion);
            ActivateButton(sender, RGBColors.color2);
        }

        private void botonElaborarProducto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ElaborarProducto());
            HideSubmenu();
        }

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AgregarProducto());
            HideSubmenu();
        }

        private void botonVentas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuVentas);
            ActivateButton(sender, RGBColors.color3);
        }

        private void botonCatalogo_Click(object sender, EventArgs e)
        {
            /*
Aqui se invocan los métodos para mostrar los formularios de cada botón
*/
            HideSubmenu();
        }

        private void botonRegistarCliente_Click(object sender, EventArgs e)
        {
            /*
Aqui se invocan los métodos para mostrar los formularios de cada botón
*/
            HideSubmenu();
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
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
