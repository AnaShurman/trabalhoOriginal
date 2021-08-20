using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho.apresentacao;


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
    }
}
