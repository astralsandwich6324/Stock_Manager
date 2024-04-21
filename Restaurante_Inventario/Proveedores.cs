using Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_Inventario
{
    public partial class Proveedores : Form
    {
        CN_Proveedores objetoCN = new CN_Proveedores();
        private string idSuplidora = null;
        private bool Editar = false;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            MostrarSuplidora();
        }

        private void MostrarSuplidora()
        {
            CN_Proveedores objeto = new CN_Proveedores();
            gridproveedores.DataSource = objeto.MostrarSupli();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guardarventas_Click(object sender, EventArgs e)
        {
            //Insertar
            if (Editar == false)
            {

                try
                {
                    objetoCN.InsertarSupli(txtNombre.Text, txtemail.Text, txttelefono.Text, txtdireccion.Text, txtdetallebanco.Text, txttaxid.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarSuplidora();
                    limpiarform();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR    
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarSupli(txtNombre.Text, txtemail.Text, txttelefono.Text, txtdireccion.Text, txtdetallebanco.Text, txttaxid.Text, idSuplidora);
                    MessageBox.Show("se edito correctamente");
                    MostrarSuplidora();
                    limpiarform();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo Editar los datos por: " + ex);
                }
            }
        }

        private void editarproveedores_Click(object sender, EventArgs e)
        {
            if (gridproveedores.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = gridproveedores.CurrentRow.Cells["Nombre"].Value.ToString();
                txtemail.Text = gridproveedores.CurrentRow.Cells["Email"].Value.ToString();
                txttelefono.Text = gridproveedores.CurrentRow.Cells["Telefono"].Value.ToString();
                txtdireccion.Text = gridproveedores.CurrentRow.Cells["Address"].Value.ToString();
                txtdetallebanco.Text = gridproveedores.CurrentRow.Cells["BankDetails"].Value.ToString();
                txttaxid.Text = gridproveedores.CurrentRow.Cells["TaxID"].Value.ToString();
                idSuplidora = gridproveedores.CurrentRow.Cells["IdSuplidor"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void limpiarform()
        {
            txtNombre.Text = "";
            txtemail.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";
            txtdetallebanco.Text = "";
            txttaxid.Text = "";

        }

        private void eliminarproveedores_Click(object sender, EventArgs e)
        {
            if (gridproveedores.SelectedRows.Count > 0)
            {
                idSuplidora = gridproveedores.CurrentRow.Cells["IdSuplidor"].Value.ToString();
                objetoCN.EliminarSupli(idSuplidora);
                MessageBox.Show("Eliminado Correctamente");
                MostrarSuplidora();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void gridproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
