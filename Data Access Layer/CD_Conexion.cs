using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=ANSTRALSANDWICH\\SQLEXPRESS;Initial Catalog=Stock_Manager;Integrated Security=True;Encrypt=False");

        public SqlConnection AbrirConexion()
        {
            if(Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
