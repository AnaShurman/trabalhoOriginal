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
    /// Lógica interna para formLivro.xaml
    /// </summary>
    public partial class formLivro : Window
    {
        public formLivro()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, RoutedEventArgs e)
        {
            avisoSeguranca seguranca = new avisoSeguranca();
            seguranca.Show();
            this.Close();
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}
