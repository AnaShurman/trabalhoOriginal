using Microsoft.Win32;
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
using trabalho.modelo;

namespace trabalho.apresentacao
{
    /// <summary>
    /// Lógica interna para Perfil.xaml
    /// </summary>
    public partial class Perfil : Window
    {
        public String mensagem = "";//Se estiver vazio esta certo
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter sqa = new MySqlDataAdapter();
        MySqlDataReader dr;
        Conexao con = new Conexao();
        int idRecebido = 0;
        Controle controle = new Controle();
        string imageName;
        public bool tem = false;

        public Perfil(int idEnviado)
        {
            idRecebido = idEnviado;
            InitializeComponent();
        }
        public Perfil()
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
                cmd.CommandText = "UPDATE users SET foto = @foto WHERE id_u = " + idRecebido;
                cmd.Parameters.AddWithValue("@foto", data);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    mensagem = "Foto alterada com sucesso!";
                    tem = true;
                }
                catch (MySqlException)
                {
                    mensagem = "Erro com o Database!";
                }

                if (tem)
                {
                    MessageBox.Show(mensagem, "Mudança de foto", MessageBoxButton.OK, MessageBoxImage.Information);
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

        private void logo_Click(object sender, MouseButtonEventArgs e)
        {
            Inicio Inicio = new Inicio(idRecebido);
            Inicio.Show();
            Close();
        }

        private void Romance_Click(object sender, RoutedEventArgs e)
        {
            Romance Romance = new Romance(idRecebido);
            Romance.Show();
            Close();
        }

        private void Mangas_Click(object sender, RoutedEventArgs e)
        {
            Mangas Mangas = new Mangas(idRecebido);
            Mangas.Show();
            Close();
        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio Misterio = new Misterio(idRecebido);
            Misterio.Show();
            Close();
        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror Terror = new Terror(idRecebido);
            Terror.Show();
            Close();
        }

        private void btn_Cadastrar_Livro_Click(object sender, RoutedEventArgs e)
        {
            Adicionar_livros add = new Adicionar_livros(idRecebido);
            add.Show();
            Close();
        }

        private void btn_add_livro_lido_Click(object sender, RoutedEventArgs e)
        {
            LivrosLidos livro = new LivrosLidos(idRecebido);
            livro.Show();
            Close();
        }

        private void btn_Meus_Livros_Click(object sender, RoutedEventArgs e)
        {
            MeusLivros meusLivros = new MeusLivros(idRecebido);
            meusLivros.Show();
            Close();
        }

        private void lbLivros_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                cmd.Connection = con.conectar();
                DataSet ds = new DataSet();
                sqa = new MySqlDataAdapter("SELECT nome_livro_lido FROM livros_lidos WHERE ID_usuario = " + idRecebido, con.conectar());
                sqa.Fill(ds);
                con.desconectar();


                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    ListBoxItem lbItem = new ListBoxItem();
                    lbItem.Content = dataRow[0].ToString();
                    lbLivros.Items.Add(lbItem);
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com o Database!";
            }

        }

        private void txtPageTotal_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //Search pages in database
                cmd.CommandText = "SELECT num_total FROM livros_lidos WHERE ID_usuario = " + idRecebido;
                try
                {
                    cmd.Connection = con.conectar();

                    dr = cmd.ExecuteReader();
                    dr.Read();

                    txtPageTotal.Text = dr.GetString(0);

                    con.desconectar();
                    tem = true;
                }
                catch (MySqlException)
                {
                    mensagem = "Erro com o Database!";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            insertData();
        }

    }
}
