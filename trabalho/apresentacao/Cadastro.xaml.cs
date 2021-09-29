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
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
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

     

        private void btn_Cadastrar_Cad_Click(object sender, RoutedEventArgs e)
        {
            Controle controle = new Controle();
            controle.acessarC(txt_Email_Cad.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Usuario existe no banco! Tente fazer login", "ERRO!", MessageBoxButton.OK, MessageBoxImage.Error);
                    limpar();
                }
                else
                {
                    String mensagem = controle.cadastrar(txt_User_Cad.Text, txt_Pass_Cad.Password, txt_Nome_Cad.Text, cb_Gender_Cad.Text, txt_Cidade_Cad.Text, cb_Estado_Cad.Text, txt_DDD_Cad.Text, txt_Cel_Cad.Text, txt_Email_Cad.Text, txt_Pass_Cad_Confirm.Password);
                    if (controle.tem)
                    {
                        MessageBox.Show(mensagem, "Cadastro", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show(controle.mensagem);
                    }
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void limpar()
        {
            txt_Nome_Cad.Clear();
            txt_User_Cad.Clear();
            txt_Pass_Cad.Clear();
            txt_Email_Cad.Clear();
            txt_DDD_Cad.Clear();
            txt_Cidade_Cad.Clear();
            txt_Cel_Cad.Clear();
            txt_Nome_Cad.Focus();
            txt_Pass_Cad_Confirm.Clear();
        }

        private void btn_Limpar_Cad_Click(object sender, RoutedEventArgs e)
        {
            limpar();
        }

        private void btn_Voltar_Cad_Click(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            Close();
        }

    }
}
