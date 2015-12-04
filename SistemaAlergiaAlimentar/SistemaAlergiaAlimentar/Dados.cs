using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;

namespace SistemaAlergiaAlimentar
{
    public class Dados
    {
        #region Conexão
        NpgsqlConnection conn = null;
        #endregion

        #region Conectar
        public bool conectar()
        {
            string serverdb = ConfigurationManager.AppSettings["Servidor_Banco"].ToString();
            string database = ConfigurationManager.AppSettings["Nome_Banco"].ToString();
            string userdb = ConfigurationManager.AppSettings["Usuario_Banco"].ToString();
            string passdb = ConfigurationManager.AppSettings["Senha_Banco"].ToString();
            string connectionString = "Server=" + serverdb + ";Port=5432;UserID=" + userdb + ";password=" + passdb + ";Database=" + database + ";";

            conn = new NpgsqlConnection(connectionString);
            try
            {
                conn.Open();
                return true;
            }
            catch
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
                    desconectar();
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

                desconectar();
            }

        }
        #endregion

        #region Cadastrar_Substancia
        public void cadastrar_substancia(string substancia)
        {
            if (this.conectar())
            {
                try {
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO produto.substancia (nome) VALUES('" + substancia + "');", conn);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                }
                desconectar();
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

                desconectar();
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

                    desconectar();

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

        #region ObterSubstanciasDoProduto
        public List<string> ObterSubstanciasDoProduto(decimal codBarras)
        {
            string sql = "SELECT s.nome FROM produto.substancia AS s JOIN produto.produto_substancia AS ps ON s.id_substancia = ps.id_substancia WHERE ps.cod_barras = :codBarras;";
            NpgsqlCommand objcmd = null;
            List<string> substancias = new List<string>();
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("codBarras", NpgsqlDbType.Numeric));
                    objcmd.Parameters[0].Value = codBarras;
                    NpgsqlDataReader dr = objcmd.ExecuteReader();
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            substancias.Add(dr.GetString(i));
                        }
                    }

                    desconectar();

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
            string sql = "select id_fabricante, id_categoria, nome from produto.produto where cod_barras = :codBarras;";
            NpgsqlCommand objcmd = null;
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
                    desconectar();
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

        #region ObterFabricante
        public string ObterFabricante(int idFabricante)
        {
            string sql = "select nome from produto.fabricante where id_fabricante = :idFabricante;";
            NpgsqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("idFabricante", NpgsqlDbType.Integer));
                    objcmd.Parameters[0].Value = idFabricante;
                    string fabricante = (string)objcmd.ExecuteScalar();
                    desconectar();
                    return fabricante;
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

        #region ObterCategoria
        public string ObterCategoria(int idCategoria)
        {
            string sql = "select nome from produto.categoria where id_categoria = :idCategoria;";
            NpgsqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("idCategoria", NpgsqlDbType.Integer));
                    objcmd.Parameters[0].Value = idCategoria;
                    string categoria = (string)objcmd.ExecuteScalar();
                    desconectar();
                    return categoria;
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

        #region ObterEstabelecimentoProduto
        public DataTable ObterEstabelecimentoProduto(decimal codBarras)
        {
            string sql = "select e.id_estabelecimento, e.id_endereco, e.nome from estabelecimento.estabelecimento as e join estabelecimento.estabelecimento_produto ep on e.id_estabelecimento = ep.id_estabelecimento where ep.cod_barras = :codBarras;";
            NpgsqlCommand objcmd = null;
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
                    desconectar();

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

        #region ObterEndereco
        public DataTable ObterEndereco(int idEndereco)
        {
            string sql = "select cep, endereco, numero, estado, cidade, bairro from estabelecimento.endereco where id_endereco = :idEndereco limit 1;";
            NpgsqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("idEndereco", NpgsqlDbType.Integer));
                    objcmd.Parameters[0].Value = idEndereco;
                    NpgsqlDataAdapter adp = new NpgsqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    desconectar();

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

        #region ObterIdEnderecoDoEstabelecimento
        public int ObterIdEnderecoDoEstabelecimento(int idEstabelecimento)
        {
            string sql = "select id_endereco from estabelecimento.estabelecimento where id_estabelecimento = :idEstabelecimento limit 1;";
            NpgsqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("idEstabelecimento", NpgsqlDbType.Integer));
                    objcmd.Parameters[0].Value = idEstabelecimento;
                    int idEndereco = (int)objcmd.ExecuteScalar();
                    desconectar();
                    return idEndereco;
                }
                catch (NpgsqlException ex)
                {
                    throw ex;
                }

            }
            else
            {
                return 0;
            }
        }
        #endregion


    }
}
