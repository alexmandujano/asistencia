using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaAsistencia
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void txtpas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {

                if (txtpas.Text == "" || txtusu.Text == "")
                {
                    MessageBox.Show("Faltan Datos");

                }
                else
                {
                    try
                    {
                        if (txtusu.Text == "DocEncinas" && txtpas.Text == "123456")
                        {
                            frmPrincipal principal = new frmPrincipal();
                            MessageBox.Show("Bienvenido Sistema de Asistencia");
                            principal.Show();
                            this.Hide();
                        }
                        else {

                            MessageBox.Show("Usuario incorrecto, Intente nuevamente","Error");
                            txtusu.Clear();
                            txtpas.Clear();
                            txtusu.Focus();
                        }
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                    
                }

            }
        }

        private void txtpas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
