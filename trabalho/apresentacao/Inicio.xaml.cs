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

namespace trabalho.apresentacao
{
    /// <summary>
    /// Lógica interna para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        int i = 1;
        public Inicio()
        {
            InitializeComponent();
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
            Biografia Biografia = new Biografia();
            Biografia.Show();
            Close();
        }

        private void btn_Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio Misterio = new Misterio();
            Misterio.Show();
            Close();
        }

        private void btn_Mangas_Click(object sender, RoutedEventArgs e)
        {
            Mangas Mangas = new Mangas();
            Mangas.Show();
            Close();
        }

        private void btn_Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror Terror = new Terror();
            Terror.Show();
            Close();
        }

        private void btn_Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance Romance = new Romance();
            Romance.Show();
            Close();
        }

        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
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
            Adicionar_livros add = new Adicionar_livros();
            add.Show();
            Close();
        }
    }
}