using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaElClavo.Forms
{
    public partial class Admin : Form
    {
        private PanelesAdmin panel;
       
        public Admin()
        {
            InitializeComponent();
            
            panel = new PanelesAdmin();
            
            this.Controls.Add(panel.panelUsuario);
            this.Controls.Add(panel.panelProveedor);
            this.Controls.Add(panel.panelInventario);
            this.Controls.Add(panel.panelVistaProductos);


        }
      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel.panelUsuario.Visible = true;
            panel.panelProveedor.Visible = false;
            panel.panelInventario.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel.panelUsuario.Visible = false;
            panel.panelProveedor.Visible = false;
            panel.panelInventario.Visible = true;
            
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel.panelUsuario.Visible = false;
            panel.panelProveedor.Visible = true;
            panel.panelInventario.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel.panelUsuario.Visible = false;
            panel.panelProveedor.Visible = false;
            panel.panelInventario.Visible = false;
            panel.panelVistaProductos.Visible = true;
        }
    }
}
