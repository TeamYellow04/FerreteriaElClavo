using FerreteriaElClavo.Data;
using FerreteriaElClavo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FerreteriaElClavo.Entities;

namespace FerreteriaElClavo
{
    public partial class iniciosesion : Form
    {
        public iniciosesion()
        {
            InitializeComponent();
            Admin adminabrir = new Admin();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string contrasena = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.");
                return;
            }

            try
            {
                int rol;
                if (Usuario.Autenticar(usuario, contrasena, out rol))
                {
                  
                    if (rol == 1)
                    {
                        Admin admin = new Admin();
                        admin.StartPosition = FormStartPosition.CenterScreen;
                        admin.Show();
                    }
                    else if (rol == 2)
                    {
                        
                        Vendedor Vendedor = new Vendedor();
                        Vendedor.StartPosition = FormStartPosition.CenterScreen;
                        Vendedor.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, o rol no autorizado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el usuario: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
