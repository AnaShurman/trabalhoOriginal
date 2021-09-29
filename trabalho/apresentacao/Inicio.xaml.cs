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
    /// Lógica interna para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        int i = 1;
        int j = 7;
        int k = 13;

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
            classicos.Source = new BitmapImage(new Uri(@"../imagens/" + i + ".jpg", UriKind.Relative));



        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            i++;
            if (i > 6)
            {
                i = 1;
            }
            classicos.Source = new BitmapImage(new Uri(@"../imagens/" + i + ".jpg", UriKind.Relative));

        }
      
        private void btn_login_ini_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();

        }

        private void btn_cad_ini_Click(object sender, RoutedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            Close();
        }

        private void btn_back_Click2(object sender, RoutedEventArgs e)
        {
            j--;
            if (j < 7)
            {
                j = 12;
            }
            juvenis.Source = new BitmapImage(new Uri(@"../imagens/" + j + ".jpg", UriKind.Relative));

        }

        private void btn_next_Click2(object sender, RoutedEventArgs e)
        {
            j++;
            if (j > 12)
            {
                j = 7;
            }
            juvenis.Source = new BitmapImage(new Uri(@"../imagens/" + j + ".jpg", UriKind.Relative));
        }

        private void btn_back_Click3(object sender, RoutedEventArgs e)
        {
            k--;
            if (k < 13)
            {
                k = 18;
            }
            mangas.Source = new BitmapImage(new Uri(@"../imagens/" + k + ".jpg", UriKind.Relative));

        }

        private void btn_next_Click3(object sender, RoutedEventArgs e)
        {
            k++;
            if (k > 18)
            {
                k = 13;
            }
            mangas.Source = new BitmapImage(new Uri(@"../imagens/" + k + ".jpg", UriKind.Relative));
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfill = new Perfil();
            perfill.Show();
            Close();
        }
    }
}