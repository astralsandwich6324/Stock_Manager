using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class CN_Proveedores
    {
        private CD_Proveedores objetoCD = new CD_Proveedores();

        public DataTable MostrarSupli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarSupli(string nombre, string email, string telefono, string direccion, string detallesbanco, string taxid)
        {
            objetoCD.Insertar(nombre, email, telefono, direccion, detallesbanco, Convert.ToInt32(taxid));
        }

        public void EditarSupli(string nombre, string email, string telefono, string direccion, string detallesbanco, string taxid, string id)
        {
            objetoCD.Editar(nombre, email, telefono, direccion, detallesbanco, Convert.ToInt32(taxid), Convert.ToInt32(id));
        }

        public void EliminarSupli(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
