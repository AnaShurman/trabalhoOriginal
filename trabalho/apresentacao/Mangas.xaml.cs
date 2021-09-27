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
    /// Lógica interna para Mangas.xaml
    /// </summary>
    public partial class Mangas : Window
    {
        int idRecebido = 0;

        public Mangas(int idEnviado)
        {
            idRecebido = idEnviado;
            InitializeComponent();
        }
        public Mangas()
        {
            InitializeComponent();
        }
        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            this.Close();
        }

        private void Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance romance = new Romance();
            romance.Show();
            this.Close();
        }

        private void Mangas_Click(object sender, RoutedEventArgs e)
        {

            Mangas mangas = new Mangas();
            mangas.Show();
            this.Close();
        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio misterio = new Misterio();
            misterio.Show();
            this.Close();
        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror terror = new Terror();
            terror.Show();
            this.Close();
        }

        private void logo_click(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();

        }

        private void hortolandia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void americana_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sumare_Click(object sender, RoutedEventArgs e)
        {

        }

        private void campinas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Romance_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}
