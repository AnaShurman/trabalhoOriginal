using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho.dal;

namespace trabalho.modelo
{
    class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String mail, String login, String senha)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            tem = loginDal.verificarLogin(mail, login, senha);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
        }

        public bool acessarC(String email)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            tem = loginDal.verificarCadastro(email);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String nome, String username, String genero, String cidade, String estado, String ddd, String celular, String senha, String confSenha)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            this.mensagem = loginDal.cadastrar(email, nome, username, genero, cidade, estado, ddd, celular, senha, confSenha);
            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
