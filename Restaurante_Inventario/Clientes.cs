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
    public partial class Clientes : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        private string idClientes = null;
        private bool Editar = false;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Mostrarcliente()
        {
            CN_Clientes objeto = new CN_Clientes();
            datagridclientes.DataSource = objeto.MostrarClien();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Mostrarcliente();
        }

        private void guardarclientes_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {

                try
                {
                    objetoCN.InsertarClien(texnombre.Text, texemail.Text, textelefono.Text, texaddress.Text, texbanc.Text, textaxid.Text);
                    MessageBox.Show("se inserto correctamente");
                    Mostrarcliente();
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
                    objetoCN.EditarClien(texnombre.Text, texemail.Text, textelefono.Text, texaddress.Text, texbanc.Text, textaxid.Text, idClientes);
                    MessageBox.Show("se edito correctamente");
                    Mostrarcliente();
                    limpiarform();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo Editar los datos por: " + ex);
                }
            }
        }

        private void editarclientes_Click(object sender, EventArgs e)
        {
            if (datagridclientes.SelectedRows.Count > 0)
            {
                Editar = true;
                texnombre.Text = datagridclientes.CurrentRow.Cells["Nombre"].Value.ToString();
                texemail.Text = datagridclientes.CurrentRow.Cells["Email"].Value.ToString();
                textelefono.Text = datagridclientes.CurrentRow.Cells["Telefono"].Value.ToString();
                texaddress.Text = datagridclientes.CurrentRow.Cells["Address"].Value.ToString();
                texbanc.Text = datagridclientes.CurrentRow.Cells["BankDetails"].Value.ToString();
                textaxid.Text = datagridclientes.CurrentRow.Cells["TaxID"].Value.ToString();
                idClientes = datagridclientes.CurrentRow.Cells["IdCliente"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void eliminarclientes_Click(object sender, EventArgs e)
        {
            if (datagridclientes.SelectedRows.Count > 0)
            {
                idClientes = datagridclientes.CurrentRow.Cells["IdCliente"].Value.ToString();
                objetoCN.EliminarClien(idClientes);
                MessageBox.Show("Eliminado Correctamente");
                Mostrarcliente();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void limpiarform()
        {
            texnombre.Text = "";
            texemail.Text = "";
            textelefono.Text = "";
            texaddress.Text = "";
            texbanc.Text = "";
            textaxid.Text = "";

        }

    }
}
