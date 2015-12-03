using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace SistemaAlergiaAlimentar
{
    public class Dados
    {
        #region Conexão
        static string serverdb = "localhost";
        static string userdb = "postgres";
        static string passdb = "@junior172";
        static string database = "bd_AlergiaAlimentar";
        private string connectionString = "Server=" + serverdb + ";Port=5432;UserID=" + userdb + ";password=" + passdb + ";Database=" + database + ";";
        NpgsqlConnection conn = null;
        #endregion

        #region Conectar
        public bool conectar()
        {
            conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                return true;
            }
            catch(NpgsqlException ex)
            {
                return false;
            }
        }
        #endregion

        #region Desconectar
        private bool desconectar()
        {
            if(conn.State != ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
                return true;
            }
            else
            {
                conn.Dispose();
                return false;
            }
        }
        #endregion

        #region ObterTodosUsuarios
        public DataTable ObterTodosUsuarios()
        {
            string sql = "SELECT id_usuario, nome FROM usuario.usuario";
            NpgsqlCommand objcmd = null;

            if(this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    NpgsqlDataAdapter adp = new NpgsqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    return dt;
                }
                catch(NpgsqlException ex)
                {
                    throw ex;
                }

            }
            else
            {
                return null;
            }
        }
        #endregion



    }
}
