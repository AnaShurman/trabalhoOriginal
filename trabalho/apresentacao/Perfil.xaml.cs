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
    /// Lógica interna para Perfil.xaml
    /// </summary>
    public partial class Perfil : Window
    {
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
    }
}
