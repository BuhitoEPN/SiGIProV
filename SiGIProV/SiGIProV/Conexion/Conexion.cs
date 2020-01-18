using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SiGIProV.Conexion
{
    public abstract class Conexion
    {
        private readonly string connectionString;
        public Conexion() => connectionString = "Server=.\\SQLEXPRESS;DataBase=RuescoCentral; integrated security = true";
        protected SqlConnection GetConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}
