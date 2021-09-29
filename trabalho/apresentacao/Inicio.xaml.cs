﻿using System;
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
    /// Lógica interna para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        int i = 1;
        int idRecebido = 0;
        Controle controle = new Controle();
        public Inicio(int idEnviado)
        {
            idRecebido = idEnviado;
            InitializeComponent();
        }
        public Inicio()
        {
            InitializeComponent();
        }

        public void enviaID()
        {
            Adicionar_livros a = new Adicionar_livros(idRecebido);
            Biografia b = new Biografia(idRecebido);
            Mangas f = new Mangas(idRecebido);
            MeusLivros g = new MeusLivros(idRecebido);
            Misterio h = new Misterio(idRecebido);
            Perfil i = new Perfil(controle.procuraIDLivro(Convert.ToString(idRecebido)));
            Romance j = new Romance(idRecebido);
            Terror k = new Terror(idRecebido);
        }
        private void logo_Click(object sender, MouseButtonEventArgs e)
        {
            Inicio Inicio = new Inicio();
            Inicio.Show();
            Close();
        }

        private void Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance Romance = new Romance();
            Romance.Show();
            Close();
        }

        private void Mangas_Click(object sender, RoutedEventArgs e)
        {
            Mangas Mangas = new Mangas();
            Mangas.Show();
            Close();
        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio Misterio = new Misterio();
            Misterio.Show();
            Close();
        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror Terror = new Terror();
            Terror.Show();
            Close();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 6;
            }
            populares.Source = new BitmapImage(new Uri(@"../imagens/" + i + ".jpg", UriKind.Relative));



        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            i++;
            if (i > 6)
            {
                i = 1;
            }
            populares.Source = new BitmapImage(new Uri(@"../imagens/" + i + ".jpg", UriKind.Relative));

        }

        private void btn_Biografia_Click(object sender, RoutedEventArgs e)
        {
            Biografia Biografia = new Biografia(idRecebido);
            Biografia.Show();
            Close();
        }

        private void btn_Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio Misterio = new Misterio(idRecebido);
            Misterio.Show();
            Close();
        }

        private void btn_Mangas_Click(object sender, RoutedEventArgs e)
        {
            Mangas Mangas = new Mangas(idRecebido);
            Mangas.Show();
            Close();
        }

        private void btn_Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror Terror = new Terror(idRecebido);
            Terror.Show();
            Close();
        }

        private void btn_Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance Romance = new Romance(idRecebido);
            Romance.Show();
            Close();
        }

        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil(idRecebido);
            perfil.Show();
            Close();
        }

        private void btn_login_ini_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();

        }

        private void btn_cad_ini_Click_1(object sender, RoutedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Adicionar_livros add = new Adicionar_livros(idRecebido);
            add.Show();
            Close();
        }

    }
}