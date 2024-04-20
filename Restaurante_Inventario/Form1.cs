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

namespace Restaurante_Inventario
{
    public partial class menuvertical : Form
    {

        private bool anchoExpandido = false;

        public menuvertical()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (panelvertical.Width == 250)
            {
                panelvertical.Width = 61;
                AjustarTamañoImagen();
                MoverImagenItla();



            }
            else
            {
                panelvertical.Width = 250;
                AjustarTamañoImagen();
                MoverImagenItla();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           


        }

        private void AjustarTamañoImagen()
        {
            if (panelvertical.Width == 250)
            {
                pictureBox1.Location = new Point(3, 0);
                pictureBox1.Width = 225;
                pictureBox1.Height = 108;
            }
            else
            {
                pictureBox1.Location = new Point(3, 0);
                pictureBox1.Width = 55;
                pictureBox1.Height = 58;
            }
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconventana.Visible = true;
            iconomaximizar.Visible = false;
        }

        private void iconventana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconventana.Visible = false;
            iconomaximizar.Visible = true;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelcontenedor.Controls.Count > 0)
            {
                this.panelcontenedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new stock_manager());
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        public void MoverImagenItla()
        {
            if (panelvertical.Width == 250)
            {
                imgitla.Location = new Point(-9, 0);
                imgitla.Width = 60;
                imgitla.Height = 44;
            }
            else
            {
                imgitla.Location = new Point(-16, 612);
                imgitla.Width = 70;
                imgitla.Height = 40;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Submenureportes.Visible = false;
        }

        private void botonreporteventas_Click(object sender, EventArgs e)
        {
            Submenureportes.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Submenureportes.Visible = true;
        }

        private void botonreportecompras_Click(object sender, EventArgs e)
        {
            Submenureportes.Visible = false;
        }

        private void Submenureportes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ventas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Clientes());
        }
    }
}
