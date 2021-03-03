using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Academia_com_banco_de_dados
{
    class Banco
    {
        private static SQLiteConnection conexao;
        
        //Funções genericas
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source ="+Globais.caminhoBanco+Globais.nomaBanco);
            conexao.Open();
            return conexao;
            
        }

        public static DataTable ObterTodosUsuario()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
               throw ex;
            }
            
        }

        public static DataTable dql(string sql)//Data Query Language (select)
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {                
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOK=null, string msgERRO=null) //Data Manipulaton Language (Insert, Delete, Update)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOK != null)
                {
                    MessageBox.Show(msgOK);

                }
            }
            catch (Exception ex)
            {
                if(msgERRO != null)
                {
                    MessageBox.Show(msgERRO+"\n"+ex.Message);
                }
                throw ex;
            }
        }


        ///FUNÇÕES do FORM F_GrestaoUsuarios

        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário',T_NOMEUSUARIO as 'Nome Usuário' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO ="+id;
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
               
                throw ex;
            }

        }
        /////// Fonções do FORM F_NovoUsuario

        public static void NovoUsuario(Usuario u)
        {

            if (existeUsername(u))
            {
                MessageBox.Show("Username ja exixste");
                return;
            }
                try
                {
                    var vcon = ConexaoBanco();
                    var cmd = ConexaoBanco().CreateCommand();
                    cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO,T_USERNAME,T_SENHAUSUARIO,T_STATUSUSUARIO,N_NIVELUSUARIO) VALUES(@nome,@username,@senha,@status,@nivel)";
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@senha", u.senha);
                    cmd.Parameters.AddWithValue("@status", u.status);
                    cmd.Parameters.AddWithValue("@nivel", u.nivel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Novo usuário inserido com sucesso");
                    vcon.Close();
                }
                catch(Exception e)
                {
                      MessageBox.Show("Erro ao gravar novos usuarios"+e);
                      
                }

        }
        
        ///FIM - Funções do FORM F_NovoUsuario
        
        ///Rotinas Gerais
        
        public static bool existeUsername(Usuario u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME='"+u.username+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();

            return res;
        }

        public static void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO ='"+u.nome+"',T_USERNAME = '"+u.username+"', T_SENHAUSUARIO = '"+u.senha+ "' ,T_STATUSUSUARIO = '" + u.status+"', N_NIVELUSUARIO = '"+u.nivel+"' WHERE N_IDUSUARIO = '"+u.id+"'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }                 
        }

        /*
            T_NOMEUSUARIO
           T_USERNAME
           T_SENHAUSUARIO
           T_STATUSUSUARIO
           N_NIVELUSUARIO
            */

        //função excluir usuario
        public static void DeletarUsuario(String id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO = '"+id+"'";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable atualizaProfessor()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = @"SELECT N_IDPROFESSOR as 'ID Professor',T_NOMEPROFESSOR as 'Nome professor',T_TELEFONE as Telefone from tb_professores ORDER BY T_NOMEPROFESSOR DESC";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /*
        public static void atualizaProfessor()
        {
            F_GestaoProfessores acesso = new F_GestaoProfessores();
            string vquery;
            vquery = @"SELECT ID_PROFESSOR as 'ID Professor',T_NOMEPROFESSOR as 'Nome professor',T_TELEFONE as Telefone from tb_professores";
            
            acesso.dgv_professores.DataSource = Banco.dql(vquery);
        }
        */

        public static DataTable atulizaGestaoAlunos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = @"SELECT N_IDALUNOS as 'ID',T_NOMEALUNO as 'Aluno' FROM tb_alunos ORDER BY T_NOMEALUNO";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
      
    }


}
