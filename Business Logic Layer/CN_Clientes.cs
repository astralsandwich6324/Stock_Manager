using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business_Logic_Layer
{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        public DataTable MostrarClien()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarClien(string nombre, string email, string telefono, string direccion, string bankdetail, string taxid)
        {
            objetoCD.Insertar(nombre, email, telefono, direccion, bankdetail, taxid);
        }

        public void EditarClien (string nombre, string email, string telefono, string direccion, string bankdetail, string taxid, string id)
        {
            objetoCD.Editar(nombre, email, telefono, direccion, bankdetail, Convert.ToInt32(taxid), Convert.ToInt32(id));
        }

        public void EliminarClien(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
