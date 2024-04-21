using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class CD_Proveedores
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarSuplidora";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public void Insertar(string nombre, string email, string telefono, string direccion, string detallesbanco, int taxid)
        {
            //Procedimiento

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarSuplidor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Address", direccion);
            comando.Parameters.AddWithValue("@BankDetails", detallesbanco);
            comando.Parameters.AddWithValue("@TaxID", taxid);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string email, string telefono, string direccion, string detallesbanco, int taxid, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarSuplidor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Address", direccion);
            comando.Parameters.AddWithValue("@BankDetails", detallesbanco);
            comando.Parameters.AddWithValue("@TaxID", taxid);
            comando.Parameters.AddWithValue("@IdSuplidor", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarSuplidor";
            comando.CommandType = CommandType.StoredProcedure;


            comando.Parameters.AddWithValue("@IdSuplidor", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
