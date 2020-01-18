using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SiGIProV.Conexion;

namespace SiGIProV.DAO
{
    public class DAOusuario : ConnectionToSql

    {
        public string Login(string user, string pass)
        {
            using (var connection = GetConexion())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@usario", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandText = "SELECT * FROM Usuario WHERE Ci = @usario AND Pass = @pass";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    string cargo = string.Empty;

                    if (reader.Read())
                    {
                        cargo = reader.GetString(reader.GetOrdinal("Cargo"));
                        return cargo;
                    }
                    else { return cargo; }
                }
            }

        }
    }
}
