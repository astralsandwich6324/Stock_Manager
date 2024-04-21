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
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProd(string nombre, string codigoDeBarras, string descripcion, string cantidad, string idSuplidor, string stock)
        {
            objetoCD.Insertar(nombre, codigoDeBarras, descripcion, Convert.ToInt32(cantidad), Convert.ToInt32(idSuplidor), Convert.ToInt32(stock));
        }

        public void EditarProd(string nombre, string codigoDeBarras, string descripcion, string cantidad, string idSuplidor, string stock, string id)
        {
            objetoCD.Editar(nombre, codigoDeBarras, descripcion, Convert.ToInt32(cantidad), Convert.ToInt32(idSuplidor), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void Eliminarprod(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
