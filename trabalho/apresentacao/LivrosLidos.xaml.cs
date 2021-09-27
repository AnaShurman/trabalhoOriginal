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
using trabalho.modelo;

namespace trabalho.apresentacao
{
    /// <summary>
    /// Lógica interna para LivrosLidos.xaml
    /// </summary>
    public partial class LivrosLidos : Window
    {
        int pages_tot = 0;
        int idRecebido = 0;

        public LivrosLidos(int page, int idEnviado)
        {
            pages_tot = page;
            idRecebido = idEnviado;
            InitializeComponent();
        }

        public LivrosLidos()
        {
            InitializeComponent();
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
            Inicio inicio = new Inicio();
            inicio.Show();
            Close();
        }

        private void Romance_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Mangas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            Close();
        }
    }
}
