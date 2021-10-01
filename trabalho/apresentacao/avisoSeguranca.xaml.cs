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
    /// Lógica interna para AvisoSeguranca.xaml
    /// </summary>
    /// 
    public partial class AvisoSeguranca : Window
    {
        public AvisoSeguranca()
        {
            InitializeComponent();
        }

        private void logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            Close();
        }

        private void checkSeguranca_Checked(object sender, RoutedEventArgs e)
        {
            if (checkSeguranca.IsChecked == false)
            {
                btn_finalizar.IsEnabled = false;
            }
            else
            {
                btn_finalizar.IsEnabled = true;
            }
        } 

        private void btn_finalizar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
