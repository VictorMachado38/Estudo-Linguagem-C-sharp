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
        
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\Users\\Machado\\Documents\\MeusProjetos\\Estudo-Linguagem-C-sharp\\Academia-com-banco-de-dados\\banco\\BD_Academia.db");
            conexao.Open();
            return conexao;
            
        }

        public static DataTable ObterTodosUsuario()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand()) 
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
            
        }

        public static DataTable consulta(string sql)
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
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
                    var cmd = ConexaoBanco().CreateCommand();
                    cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUSARIO,T_USERNAME,T_SENHAUSUARIO,T_STATUSUSUARIO,N_NIVELUSUARIO) VALUES(@nome,@username,@senha,@status,@nivel)";
                    cmd.Parameters.AddWithValue("@nome", u.nome);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@senha", u.senha);
                    cmd.Parameters.AddWithValue("@status", u.status);
                    cmd.Parameters.AddWithValue("@nivel", u.nivel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Novo usuário inserido com sucesso");
                    ConexaoBanco().Close();
                }
                catch(Exception e)
                {
                      MessageBox.Show("Erro ao gravar novos usuarios");
                      ConexaoBanco().Close();

                }

        }
        
        ///FIM - Funções do FORM F_NovoUsuario
        
        ///Rotinas Gerais]
        
        public static bool existeUsername(Usuario u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
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

            return res;
        }

    }
}
