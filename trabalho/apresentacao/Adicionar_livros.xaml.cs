using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
using trabalho.modelo;

namespace trabalho.apresentacao
{
    /// <summary>
    /// Lógica interna para Adicionar_livros.xaml
    /// </summary>
    public partial class Adicionar_livros : Window
    {
        public bool tem = false;
        public String mensagem = "";//Se estiver vazio esta certo
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        string imageName;
        int idRecebido = 0;
        Controle controle = new Controle();

        public Adicionar_livros(int idEnviado)
        {
            idRecebido = idEnviado;
            InitializeComponent();
        }

        public Adicionar_livros()
        {
            InitializeComponent();
        }

        private void insertData()
        {
            if (imageName == "")
            {
                return;
            }
            try
            {
                FileStream fs = new FileStream(@imageName, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));
                fs.Close();

                //Insert books in database
                cmd.CommandText = "INSERT INTO livros (nome_livro, cat_livro, edicao_livro, foto, id_user) VALUES(@nome_livro, @cat_livro, @ano_livro, @foto, @id_user)";
                cmd.Parameters.AddWithValue("@nome_livro", txt_nome_livro.Text);
                cmd.Parameters.AddWithValue("@cat_livro", txt_cat_livro.Text);
                cmd.Parameters.AddWithValue("@ano_livro", txt_data_livro.Text);
                cmd.Parameters.AddWithValue("@foto", data);
                cmd.Parameters.AddWithValue("@id_user", idRecebido);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Livro cadastrado com sucesso!";
                    tem = true;
                }
                catch (MySqlException)
                {
                    this.mensagem = "Erro com o Database!";
                }

                if (tem)
                {
                    MessageBox.Show(mensagem, "Cadastro de livros", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show(mensagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void btn_add_img_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileDialog capa = new OpenFileDialog();
                capa.Title = "Selecionar foto";
                capa.InitialDirectory = "Images";
                capa.Filter = "Image File (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.bmp;*.jpg;*.gif;*.png;*.tiff |" + "All files (*.*)|*.*";
                capa.ShowDialog();
                {

                    imageName = capa.FileName;
                    ImageSourceConverter isc = new ImageSourceConverter();
                    imagebox.SetValue(Image.SourceProperty, isc.ConvertFromString(imageName));
                }
                capa = null;
            }
            catch (Exception)
            {
                mensagem = "Erro com o gerenciador de imagens, acione o administrador!";
            }

        }


        public void btn_salvar_livro_Click(object sender, RoutedEventArgs e)
        {
            insertData();
        }

        private void logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Inicio inicio = new Inicio(idRecebido);
            inicio.Show();
            Close();
        }

        private void Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance romance = new Romance(idRecebido);
            romance.Show();
            Close();
        }

        private void Mangas_Click(object sender, RoutedEventArgs e)
        {
            Mangas mg = new Mangas(idRecebido);
            mg.Show();
            Close();
        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio ms = new Misterio(idRecebido);
            ms.Show();
            Close();
        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror terror = new Terror(idRecebido);
            terror.Show();
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Perfil perfil = new Perfil(idRecebido);
            perfil.Show();
            Close();
        }
    }
}
