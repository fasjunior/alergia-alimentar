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
            if (conn.State != ConnectionState.Closed)
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

        #region Cadastrar_Usuario
        public bool cadastrar_usuario(string usuario)
        {
            if (this.conectar())
            {
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO usuario.usuario (nome) VALUES('" + usuario + "')", conn);
                    cmd.ExecuteNonQuery();

                    desconectar();
                    return true;
                }
                catch
                {
                    desconectar();
                    return false;
                }
                
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region Cadastrar_Categoria
        public bool cadastrar_categoria(string categoria)
        { 
            if (this.conectar())
            {
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO produto.categoria (nome) VALUES('" + categoria + "')", conn);
                    cmd.ExecuteNonQuery();
                    desconectar();
                    return true;
                }
                catch
                {
                    desconectar();
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region Cadastrar_Endereco
        public void cadastrar_endereco(int cep, string endereco, int numero, string estado, string cidade, string bairro)
        {
            if (this.conectar())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO estabelecimento.endereco (cep, endereco, numero, estado, cidade, bairro) VALUES('" + cep + "','" + endereco + "','" + numero + "','" + estado + "','" + cidade + "','" + bairro + "');", conn);
                cmd.ExecuteNonQuery();
                desconectar();
            }

        }
        #endregion

        #region Cadastrar_Estabelecimento
        public bool cadastrar_estabelecimento(string endereco, int cep, int numero, string nome)
        {
            if (this.conectar())
            {
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO estabelecimento.estabelecimento(id_endereco, nome) VALUES((select id_endereco from estabelecimento.endereco where cep = '" + cep + "' and endereco = '" + endereco + "' and numero = '" + numero + "' order by id_endereco desc limit 1),'" + nome + "');", conn);
                    cmd.ExecuteNonQuery();
                    desconectar();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region Cadastrar_Fabricante
        public void cadastrar_fabricante(string fabricante)
        {
            if (this.conectar())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO produto.fabricante (nome) VALUES('" + fabricante + "')", conn);
                cmd.ExecuteNonQuery();
                desconectar();
            }

        }
        #endregion

        #region Cadastrar_Produto
        public void cadastrar_produto(decimal codBarras, string fabricante, string categoria, string nome)
        { 
            if (this.conectar())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO produto.produto (cod_barras, id_fabricante, id_categoria, nome) VALUES('" + codBarras + "', (select id_fabricante from produto.fabricante where nome like '" + fabricante + "'), (select id_categoria from produto.categoria where nome like '" + categoria + "'), '" + nome + "')", conn);
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
                try
                {
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
        public bool cadastrar_usuario_substancia(string usuario, string substancia)
        {
            if (this.conectar())
            {
                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO usuario.usuario_substancia (id_usuario, id_substancia) VALUES((select id_usuario from usuario.usuario where nome like '" + usuario + "'), (select id_substancia from produto.substancia where nome like '" + substancia + "'));", conn);
                    cmd.ExecuteNonQuery();
                    desconectar();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Cadastrar_Produto_Substancia
        public void cadastrar_produto_substancia(decimal codBarras, string substancia)
        {
            if (this.conectar())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO produto.produto_substancia (cod_barras, id_substancia) VALUES('" + codBarras + "', (select id_substancia from produto.substancia where nome like '" + substancia + "'));", conn);
                cmd.ExecuteNonQuery();

                desconectar();
            }
        }
        #endregion

        #region Cadastrar_Produto_Estabelecimento
        public void cadastrar_produto_estabelecimento(int idEstabelecimento, decimal codBarras)
        {
            if (this.conectar())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO estabelecimento.estabelecimento_produto (id_estabelecimento, cod_barras) VALUES('" + idEstabelecimento + "', '" + codBarras + "');", conn);
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

        #region ObterUsuario
        public string ObterUsuario(int idUsuario)
        {
            string sql = "select nome from usuario.usuario where id_usuario = :idUsuario;";
            NpgsqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("idUsuario", NpgsqlDbType.Integer));
                    objcmd.Parameters[0].Value = idUsuario;
                    string usuario = (string)objcmd.ExecuteScalar();
                    desconectar();
                    return usuario;
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

        #region ObterProdutosDaCategoria
        public DataTable ObterProdutosDaCategoria(int idCategoria)
        {
            string sql = "SELECT cod_barras, nome FROM produto.produto WHERE id_categoria = :idCategoria;";
            NpgsqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("idCategoria", NpgsqlDbType.Integer));
                    objcmd.Parameters[0].Value = idCategoria;
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

        #region ObterProdutosDaCategoriaUsuario
        public DataTable ObterProdutosDaCategoriaUsuario(int idCategoria, int idUsuario)
        {
            string sql = "select cod_barras, nome from produto.produto " + 
                         "where id_categoria = :idCategoria and cod_barras not in (select p.cod_barras from produto.produto_substancia as ps " + 	
                                                                                  "join produto.produto as p on ps.cod_barras = p.cod_barras " +
                                                                                  "join usuario.usuario_substancia as us on us.id_substancia = ps.id_substancia " +
                                                                                  "where us.id_usuario = :idUsuario and p.id_categoria = :idCategoria);";
            NpgsqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new NpgsqlCommand(sql, conn);
                    objcmd.Parameters.Add(new NpgsqlParameter("idCategoria", NpgsqlDbType.Integer));
                    objcmd.Parameters.Add(new NpgsqlParameter("idUsuario", NpgsqlDbType.Integer));
                    objcmd.Parameters[0].Value = idCategoria;
                    objcmd.Parameters[1].Value = idUsuario;
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

        #region ObterTodasCategorias
        public DataTable ObterTodasCategorias()
        {
            string sql = "SELECT id_categoria, nome FROM produto.categoria";
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

        #region ObterTodosFabricantes
        public DataTable ObterTodosFabricantes()
        {
            string sql = "SELECT id_fabricante, nome FROM produto.fabricante";
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

        #region ObterTodosProdutos
        public DataTable ObterTodosProdutos()
        {
            string sql = "SELECT cod_barras, nome, id_fabricante FROM produto.produto";
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

        #region ObterTodosEstabelecimentos
        public DataTable ObterTodosEstabelecimentos()
        {
            string sql = "SELECT id_estabelecimento, nome FROM estabelecimento.estabelecimento";
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

        


    }
}
