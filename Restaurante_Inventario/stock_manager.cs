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
    public partial class stock_manager : Form
    {
        public stock_manager()
        {
            InitializeComponent();
        }

        private void stock_manager_Load(object sender, EventArgs e)
        {

        }

       /* private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
