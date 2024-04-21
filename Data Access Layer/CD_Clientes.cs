using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public void Insertar(string nombre, string email, string telefono, string direccion, string bankdetail, string taxid)
        {
            //Procedimiento

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Address", direccion);
            comando.Parameters.AddWithValue("@BankDetails", bankdetail);
            comando.Parameters.AddWithValue("@TaxID", taxid);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string email, string telefono, string direccion, string bankdetail, int taxid, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Address", direccion);
            comando.Parameters.AddWithValue("@BankDetails", bankdetail);
            comando.Parameters.AddWithValue("@TaxID", taxid);
            comando.Parameters.AddWithValue("@IdCliente", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@IdCliente", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
