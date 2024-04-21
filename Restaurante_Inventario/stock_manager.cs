using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace Restaurante_Inventario
{
    public partial class stock_manager : Form
    {

        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;

        public stock_manager()
        {
            InitializeComponent();
        }

        private void stock_manager_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }


        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarprod_Click(object sender, EventArgs e)
        {
            //Insertar
            if (Editar == false)
            {

                try
                {
                    objetoCN.InsertarProd(txtNombre.Text, txtCodigoBarras.Text, txtdescripcion.Text, txtcantidad.Text, txtidsuplidor.Text, txtstock.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarProductos();
                    limpiarform();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR    
            if(Editar == true)
            {
                try
                {
                    objetoCN.EditarProd(txtNombre.Text, txtCodigoBarras.Text, txtdescripcion.Text, txtcantidad.Text, txtidsuplidor.Text, txtstock.Text,idProducto);
                    MessageBox.Show("se edito correctamente");
                    MostrarProductos();
                    limpiarform();
                    Editar = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("no se pudo Editar los datos por: " + ex);
                }
            }
        }

        private void editarprod_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCodigoBarras.Text = dataGridView1.CurrentRow.Cells["CodigoDeBarras"].Value.ToString();
                txtdescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtcantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                txtidsuplidor.Text = dataGridView1.CurrentRow.Cells["IdSuplidor"].Value.ToString();
                txtstock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["IdProducto"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }


        private void limpiarform()
        {
            txtNombre.Text = "";
            txtCodigoBarras.Text = "";
            txtdescripcion.Text = "";
            txtcantidad.Text = "";
            txtidsuplidor.Text = "";
            txtstock.Text = "";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarprod_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["IdProducto"].Value.ToString();
                objetoCN.Eliminarprod(idProducto);
                MessageBox.Show("Eliminado Correctamente");
                MostrarProductos();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
