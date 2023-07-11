using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ConexionBBDD
    {
        private SqlConnection conexion;
        public ConexionBBDD()
        {
            conexion =  new SqlConnection("server=.; database=CONTACTOS_DB; Integrated Security=true");

        }

        public SqlConnection getConexion()
        {
            return conexion;
        }

    }
}
