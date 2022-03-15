using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_final_Andres_Garcia.Classes
{
    internal class Database
    {
        private NpgsqlConnection obj_connection;
        private String connection_string = "Server=127.0.0.1;User Id = postgres; Password=1622;Database=inventory;";

        public Database()
        {
            this.obj_connection = new NpgsqlConnection(this.connection_string);

            this.open();
        }

        public void open()
        {
            this.obj_connection.Open();
        }

        public void close()
        {
            this.obj_connection.Close();
        }

        /*
        public void ejecutarInstruccion(String sql)
        {
            NpgsqlCommand objComando = new NpgsqlCommand(sql, this.objConexion);
            objComando.ExecuteNonQuery();
        }

        public DataTable obtieneDatos(String sql)
        {
            DataTable regresa = new DataTable();

            NpgsqlCommand objComando = new NpgsqlCommand(sql, this.objConexion);

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(objComando);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            regresa = ds.Tables[0];

            return regresa;
        }
        */
    }
}
