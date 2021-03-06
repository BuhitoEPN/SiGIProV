﻿using SiGIProV.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiGIProV.Controlador;

namespace SiGIProV
{
    public partial class Login : Form
    {
        ControlLogin control;
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

            if (tUsuario.Text != "USUARIO") { 
                if (tPassword.Text != "CONTRASEÑA")
                {
                    //Se declaran los atributos para extraer de los TextBox de los usuarios
                    string user = this.tUsuario.Text;
                    string pass = this.tPassword.Text;

                    //Se instancia el controlador para poder conectar con la base
                    control = new ControlLogin();
                    String cargo = control.controlLoginDAO(user, pass);

                    //Se utiliza un string para encontrar el cargo y abrir la interfaz correcta
                    if ((string.Compare(cargo, "Bodega")) == 0)
                    {
                        this.Hide();
                        Bodega bodega = new Bodega();
                        bodega.ShowDialog();

                    }
                    else if ((string.Compare(cargo, "Producción")) == 0)
                    {
                        this.Hide();
                        Produccion produccion = new Produccion();
                        produccion.ShowDialog();

                    }
                    else if ((string.Compare(cargo, "Ventas")) == 0)
                    {
                        this.Hide();
                        Ventas ventas = new Ventas();
                        ventas.ShowDialog();
                    }
                    else if ((string.Compare(cargo, "Administrador")) == 0)
                    {
                        this.Hide();
                        Administrador admi = new Administrador();
                        admi.ShowDialog();
                    }
                    else { /*MessageBox.Show("No ha seleccionado ningún rol");*/
                            msgError("Usuario inválido, inténtelo de nuevo.");}
                }
                else msgError("Por favor, ingrese su contraseña.");
            }
            else msgError("Por favor, ingrese su usuario.");
            
        }


        private void msgError(string msg)
        {
            lMensajeError.Text = "    "+ msg;
            lMensajeError.Visible = true;
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

        private void lMensajeError_Click(object sender, EventArgs e)
        {

        }
    }
}
