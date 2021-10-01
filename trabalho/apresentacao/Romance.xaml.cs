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
using trabalho.modelo;

namespace trabalho.apresentacao
{
    /// <summary>
    /// Lógica interna para Romance.xaml
    /// </summary>
    public partial class Romance : Window
    {
        public bool tem = false;
        public String mensagem = "";//Se estiver vazio esta certo
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;
        int idRecebido = 0;
        Controle controle = new Controle();

        public Romance(int idEnviado)
        {
            idRecebido = idEnviado;
            InitializeComponent();
        }
        public Romance()
        {
            InitializeComponent();
        }


        private void selectFiltro()
        {
            //Comandos para inserir livros
            cmd.CommandText = "";
            cmd.Parameters.AddWithValue("@city", MySqlDbType.Int32).Value = txtPesquisa.Text;
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                teste1.Content = dr.GetValue(0);
                teste.Text = dr.GetString(2);
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

        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil(idRecebido);
            perfil.Show();
            Close(); 
        }

        private void Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance romance = new Romance(idRecebido);
            romance.Show();
            this.Close();
        }

        private void Mangas_Click(object sender, RoutedEventArgs e)
        {

            Mangas mangas = new Mangas(idRecebido);
            mangas.Show();
            this.Close();
        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio misterio = new Misterio(idRecebido);
            misterio.Show();
            this.Close();
        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror terror = new Terror(idRecebido);
            terror.Show();
            this.Close();
        }

        private void logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio(idRecebido);
            inicio.Show();
            this.Close();
        }

        private void btn_antesDeVc_Click(object sender, RoutedEventArgs e)
        {
            formLivro form = new formLivro();
            form.Show();
        }

        private void btn_pesquisa_Click(object sender, RoutedEventArgs e)
        {
            selectFiltro();
        }

        private void logo_Click(object sender, MouseButtonEventArgs e)
        {
            Inicio Inicio = new Inicio(idRecebido);
            Inicio.Show();
            Close();
        }
    }
}

