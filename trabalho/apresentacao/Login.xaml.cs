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
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void btn_Login_Log_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txt_User_Log.Text, txt_User_Log.Text, txt_Pass_Log.Password);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Login não encontrado! Verifique username e senha", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btn_Cadastrar_Log_Click(object sender, RoutedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            Close();
        }

        private void btn_Voltar_Log_Click(object sender, RoutedEventArgs e)
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

        private void logo_click(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            Close();

        }

        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
