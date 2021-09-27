using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho.apresentacao;
using System.IO;
using Microsoft.Win32;
using System.Data;

namespace trabalho.dal
{
    class LoginDalComandos
    {
        public bool tem = false;
        public String mensagem = "";//Se estiver vazio esta certo
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;
        public bool verificarLogin(String mail, String login, String senha)
        {
            //Buscar no db esse usuario
            cmd.CommandText = "SELECT * FROM users WHERE (user = @login OR email = @em) AND password = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@em", mail);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//Se existir no db
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

            return tem;
        }

        public bool verificarCadastro(String email)
        {
            //Buscar no db esse usuario
            cmd.CommandText = "SELECT * FROM users WHERE email = @e";
            cmd.Parameters.AddWithValue("@e", email);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//Se existir no db
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

            return tem;
        }


        public String cadastrar(String username, String senha, String nome, String genero, String cidade, String estado, String ddd, String celular, String email, String confSenha)
        {
            tem = false;
            //Comandos para inserir usuarios
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO users (`user`, password, name_user, sexo, cidade, estado, DDD, celular, email) VALUES(@us, @pass, @name, @sex, @cidade, @estado, @ddd, @cel, @e);";
                cmd.Parameters.AddWithValue("@us", username);
                cmd.Parameters.AddWithValue("@pass", senha);
                cmd.Parameters.AddWithValue("@name", nome);
                cmd.Parameters.AddWithValue("@sex", genero);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@ddd", ddd);
                cmd.Parameters.AddWithValue("@cel", celular);
                cmd.Parameters.AddWithValue("@e", email);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (MySqlException)
                {
                    this.mensagem = "Erro com o Database!";
                }

            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }


            return mensagem;
        }

        public String cadastrarLivroLido(String nome_livro, String num_page, String num_tot, String id_usuario)
        {
            tem = false;
            //Comandos para inserir usuarios
            cmd.CommandText = "INSERT INTO livros_lidos (nome_livro_lido, num_page, num_total, ID_usuario) VALUES(@n_livro, @num_livro, @num_tot, @id_usuario);";
            cmd.Parameters.AddWithValue("@n_livro", nome_livro);
            cmd.Parameters.AddWithValue("@num_livro", num_page);
            cmd.Parameters.AddWithValue("@num_tot", num_tot);
            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Livro cadastrado com sucesso!";
                tem = true;
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

            return mensagem;

        }

        public int verificaPage(String num_pages, int num_tots, String id_usuar)
        {
            int page_total = 0;
            //Buscar no db esse usuario
            cmd.CommandText = "SELECT num_total FROM livros_lidos WHERE ID_usuario = @id_usu;";
            cmd.Parameters.AddWithValue("@num_page", num_pages);
            cmd.Parameters.AddWithValue("@num_tota", num_tots);
            cmd.Parameters.AddWithValue("@id_usu", id_usuar);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    page_total = Convert.ToInt32(dr["num_total"]);
                }

                con.desconectar();
                dr.Close();
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

            return page_total;
        }

        public int verificaID(String maill, String loginn)
        {
            int idRetorno = 0;
            //Buscar no db esse usuario
            cmd.CommandText = "SELECT id_u FROM users WHERE (user = @login OR email = @em);";
            cmd.Parameters.AddWithValue("@login", loginn);
            cmd.Parameters.AddWithValue("@em", maill);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idRetorno = Convert.ToInt32(dr["id_u"]);
                }

                con.desconectar();
                dr.Close();
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

            return idRetorno;
        }



    }
}
