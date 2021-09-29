using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using trabalho.dal;


namespace trabalho.apresentacao
{
    /// <summary>
    /// Lógica interna para MeusLivros.xaml
    /// </summary>
    public partial class MeusLivros : Window
    {
        public String mensagem = "";//Se estiver vazio esta certo
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter sqa = new MySqlDataAdapter();
        Conexao con = new Conexao();

        int idRecebido = 0;
        public MeusLivros(int idEnviado)
        {
            idRecebido = idEnviado;
            InitializeComponent();
        }
        public MeusLivros()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                cmd.Connection = con.conectar();
                DataSet ds = new DataSet();
                sqa = new MySqlDataAdapter("SELECT nome_livro FROM livros WHERE id_user = "+ idRecebido, con.conectar());
                sqa.Fill(ds);
                con.desconectar();
                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    ListBoxItem lbItem = new ListBoxItem();
                    lbItem.Content = dataRow[0].ToString();
                    lbMeusLivros.Items.Add(lbItem);
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

        }

        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            Close();
        }

        private void logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
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
            Misterio menuItem = new Misterio();
            menuItem.Show();
            Close();
        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror menuIte = new Terror();
            menuIte.Show();
            Close();
        }

        private void lbMeusLivros_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lb = lbMeusLivros.SelectedItem as ListBoxItem;
            con.conectar();
            DataSet ds = new DataSet();
            sqa = new MySqlDataAdapter("SELECT foto FROM livros WHERE nome_livro='" + lb.Content.ToString() + "'", con.conectar());
            sqa.Fill(ds);
            con.desconectar();

            byte[] data = (byte[])ds.Tables[0].Rows[0][0];

            MemoryStream strm = new MemoryStream();

            strm.Write(data, 0, data.Length);

            strm.Position = 0;

            System.Drawing.Image img = System.Drawing.Image.FromStream(strm);

            BitmapImage bi = new BitmapImage();

            bi.BeginInit();

            MemoryStream ms = new MemoryStream();

            img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

            ms.Seek(0, SeekOrigin.Begin);

            bi.StreamSource = ms;

            bi.EndInit();

            imagebox.Source = bi;
        }
    }
}
