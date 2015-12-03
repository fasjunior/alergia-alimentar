using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using NpgsqlTypes;

namespace SistemaAlergiaAlimentar
{
    public class Dados
    {
        #region Conexão
        static string serverdb = "localhost";
        static string userdb = "postgres";
        static string passdb = "postgres";
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

            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    NpgsqlDataAdapter adp = new NpgsqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    return dt;
                }
                catch (NpgsqlException ex)
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

        #region Cadastrar_Usuario
        public void cadastrar_usuario(string usuario)
        {
            if (this.conectar())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO usuario.usuario (nome) VALUES('" + usuario + "')", conn);
                cmd.ExecuteNonQuery();
            }

        }
        #endregion

        #region Cadastrar_Substancia
        public void cadastrar_substancia(string substancia)
        {
            if (this.conectar())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO produto.substancia (nome) VALUES('" + substancia + "');", conn);
                cmd.ExecuteNonQuery();
            }

        }
        #endregion

        #region Cadastrar_Usuario_Substancia
        public void cadastrar_usuario_substancia(string usuario, string substancia)
        {
            if (this.conectar())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO usuario.usuario_substancia (id_usuario, id_substancia) VALUES((select id_usuario from usuario.usuario where nome like '" + usuario + "'), (select id_substancia from produto.substancia where nome like '" + substancia + "'));", conn);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region ObterSubstanciasDoUsuario
        public List<string> ObterSubstanciasDoUsuario(int idUsuario)
        {
            string sql = "SELECT s.nome FROM produto.substancia AS s JOIN usuario.usuario_substancia AS us ON s.id_substancia = us.id_substancia WHERE us.id_usuario = :idUsuario;";
            NpgsqlCommand objcmd = null;
            List<string> substancias = new List<string>();
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("idUsuario", NpgsqlDbType.Integer));
                    objcmd.Parameters[0].Value = idUsuario;
                    NpgsqlDataReader dr = objcmd.ExecuteReader();
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            substancias.Add(dr.GetString(i));
                        }
                    }

                    return substancias;
                }
                catch (NpgsqlException ex)
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

        #region ObterProduto
        public DataTable ObterProduto(decimal codBarras)
        {
            string sql = "select id_fabricante, nome from produto.produto where cod_barras = :codBarras;";
            NpgsqlCommand objcmd = null;
            List<string> substancias = new List<string>();
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("codBarras", NpgsqlDbType.Numeric));
                    objcmd.Parameters[0].Value = codBarras;
                    NpgsqlDataAdapter adp = new NpgsqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    return dt;
                }
                catch (NpgsqlException ex)
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
