using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho.dal;
using Microsoft.Win32;
using System.IO;

namespace trabalho.modelo
{
    class Controle
    {
        public bool tem;
        public int idRetorno;
        public int idLivroLidoV;
        public int page_total;
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

        public int acessarID(String maill, String loginn)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            idRetorno = loginDal.verificaID(maill, loginn);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return idRetorno;
        }

        public int procuraIDLivro(String id_livro_lido)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            idLivroLidoV = loginDal.idLivro(id_livro_lido);
            if (loginDal.tem)
            {
                this.tem = true;
            }
            return idLivroLidoV;

        }

        public int acessarPageTot(String num_pages, int num_tots, String id_usuar)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            page_total = loginDal.verificaPage(num_pages, num_tots, id_usuar);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return page_total;
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

        public String cadastrarLivroL(String nome_livro, String num_page, int num_tot, String id_usuario)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            this.mensagem = loginDal.cadastrarLivroLido(nome_livro, num_page, Convert.ToString(num_tot), id_usuario);
            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }


    }
}
