using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using trabalho.dal;

namespace trabalho.apresentacao
{
    /// <summary>
    /// Lógica interna para Perfil.xaml
    /// </summary>
    public partial class Perfil : Window
    {
        public String mensagem = "";//Se estiver vazio esta certo
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter sqa = new MySqlDataAdapter();
        Conexao con = new Conexao();
        int idRecebido = 0;
        public Perfil(int idEnviado)
        {
            idRecebido = idEnviado;     
            InitializeComponent();
        }
        public Perfil()
        {
            InitializeComponent();
        }


        private void logo_click(object sender, MouseButtonEventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();
            Close();
        }

        private void Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance romance = new Romance();
            romance.Show();
            Close();
        }

        private void Mangas_Click(object sender, RoutedEventArgs e)
        {
            Mangas mangas = new Mangas();
            mangas.Show();
            Close();
        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio misterio = new Misterio();
            misterio.Show();
            Close();

        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror terror = new Terror();
            terror.Show();
            Close();
        }

        private void btn_Cadastrar_Livro_Click(object sender, RoutedEventArgs e)
        {
            Adicionar_livros add = new Adicionar_livros();
            add.Show();
            Close();
        }

        private void btn_add_livro_lido_Click(object sender, RoutedEventArgs e)
        {
            LivrosLidos livro = new LivrosLidos(idRecebido, idRecebido);
            livro.Show();
            Close();
        }

        private void btn_Meus_Livros_Click(object sender, RoutedEventArgs e)
        {
            MeusLivros meusLivros = new MeusLivros(idRecebido);
            meusLivros.Show();
            Close();
        }

        private void lbLivros_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                cmd.Connection = con.conectar();
                DataSet ds = new DataSet();
                sqa = new MySqlDataAdapter("SELECT nome_livro_lido FROM livros_lidos WHERE ID_usuario = "+ idRecebido, con.conectar());
                sqa.Fill(ds);
                con.desconectar();


                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    ListBoxItem lbItem = new ListBoxItem();
                    lbItem.Content = dataRow[0].ToString();
                    lbLivros.Items.Add(lbItem);
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

        }

        private void txtPageTotal_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                cmd.Connection = con.conectar();
                DataSet ds = new DataSet();
                sqa = new MySqlDataAdapter("SELECT num_total FROM livros_lidos WHERE ID_usuario = " + idRecebido, con.conectar());
                sqa.Fill(ds);
                con.desconectar();


                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = dataRow[0].ToString();
                    txtPageTotal = textBox;
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }
        }
    }
}
