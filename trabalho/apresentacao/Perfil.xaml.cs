using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        public bool tem = false;
        public String mensagem = "";//Se estiver vazio esta certo
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;
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

        private void selectLivros()
        {
            //Comandos para inserir livros
            cmd.CommandText = "";
            cmd.Parameters.AddWithValue("@city", MySqlDbType.Int32).Value = lblNumLivros.Text;
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                
                lblNumLivros.Text = dr.GetString(2);
                con.desconectar();
                mensagem = "Chegou aqui!";
                tem = true;
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

            if (tem)
            {
                MessageBox.Show(mensagem, "Chegou aqui 2", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(mensagem);
            }
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
            
        }
    }
}
