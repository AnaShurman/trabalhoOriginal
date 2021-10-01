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
    /// Lógica interna para LivrosLidos.xaml
    /// </summary>
    public partial class LivrosLidos : Window
    {
        public String mensagem = "";
        int pages_tot = 0;
        int idRecebido = 0;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        Conexao con = new Conexao();




        public LivrosLidos(int idEnviado)
        {
            idRecebido = idEnviado;
            InitializeComponent();
        }

        public LivrosLidos()
        {
            InitializeComponent();
        }

        private void verificaPage()
        {
            cmd.CommandText = "SELECT num_total FROM livros_lidos WHERE ID_usuario = @id_usu;";
            cmd.Parameters.AddWithValue("@id_usu", idRecebido);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//Se existir no db
                {
                    pages_tot = Convert.ToInt32(dr);
                }
                con.desconectar();
                dr.Close();
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }
        }

        private void btn_add_livro_lido_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();     
            if (controle.mensagem.Equals(""))
            {
                pages_tot += Convert.ToInt32(txt_numero_paginas.Text);

                String mensagem = controle.cadastrarLivroL(txt_nome_livro_lido.Text, txt_numero_paginas.Text, pages_tot, Convert.ToString(idRecebido));
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Cadastro de livros lidos", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }

            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio(idRecebido);
            inicio.Show();
            Close();
        }

        private void Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance menu = new Romance(idRecebido);
            menu.Show();
            Close();
        }

        private void Mangas_Click(object sender, RoutedEventArgs e)
        {
            Mangas menu = new Mangas(idRecebido);
            menu.Show();
            Close();
        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio menu = new Misterio(idRecebido);
            menu.Show();
            Close();
        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror menu = new Terror(idRecebido);
            menu.Show();
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil(idRecebido);
            perfil.Show();
            Close();
        }
    }
}
