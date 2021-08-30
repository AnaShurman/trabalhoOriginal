﻿using Microsoft.Win32;
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



        public Adicionar_livros()
        {
            InitializeComponent();
        }

        private void insertData()
        {
            FileStream fs = new FileStream(@imageName, FileMode.Open, FileAccess.Read);

            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, System.Convert.ToInt32(fs.Length));

            fs.Close();

            //Comandos para inserir livros
            cmd.CommandText = "INSERT INTO livros (nome_livro, cat_livro, edicao_livro, foto) VALUES(@nome_livro, @cat_livro, @ano_livro, @foto)";
            cmd.Parameters.AddWithValue("@nome_livro", txt_nome_livro.Text);
            cmd.Parameters.AddWithValue("@cat_livro", txt_cat_livro.Text);
            cmd.Parameters.AddWithValue("@ano_livro", txt_data_livro.Text);
            cmd.Parameters.AddWithValue("@foto", data);

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

        public void btn_add_img_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                FileDialog capa = new OpenFileDialog();
                capa.Title = "Selecionar foto";
                capa.InitialDirectory = "Images";
                capa.Filter = "Image File (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
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
                this.mensagem = "Erro com o gerenciador de imagens, acione o administrador!";
            }

        }


        public void btn_salvar_livro_Click(object sender, RoutedEventArgs e)
        {
            insertData();
        }

        private void logo_MouseDown(object sender, MouseButtonEventArgs e)
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
            Mangas mg = new Mangas();
            mg.Show();
            Close();
        }

        private void Misterio_Click(object sender, RoutedEventArgs e)
        {
            Misterio ms = new Misterio();
            ms.Show();
            Close();
        }

        private void Terror_Click(object sender, RoutedEventArgs e)
        {
            Terror terror = new Terror();
            terror.Show();
            Close();
        }

        private void btn_perfil_Click(object sender, RoutedEventArgs e)
        {
            /*Perfil perfil = new Perfil();
            perfil.Show();
            Close();*/
        }


    }
}
