using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinForms = System.Windows.Forms;

namespace FileSort
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.ShowDialog();
                SortPath.Text = dialog.SelectedPath;
            }
            catch (Exception x)
            {
                MessageBox.Show("Что-то пошло не так " + x.Message);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.ShowDialog();
                VideoPath.Text = dialog.SelectedPath;
            }
            catch (Exception x)
            {
                MessageBox.Show("Что-то пошло не так " + x.Message);
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.ShowDialog();
                FotoPath.Text = dialog.SelectedPath;
            }
            catch (Exception x)
            {
                MessageBox.Show("Что-то пошло не так " + x.Message);
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                dialog.ShowDialog();
                DocPath.Text = dialog.SelectedPath;
            }
            catch (Exception x)
            {
                MessageBox.Show("Что-то пошло не так " + x.Message);
            }
        }

        private void ButtonSort_Click(object sender, RoutedEventArgs e)
        {
            if (SortPath.Text != "")
            {
                if (DocPath.Text != "") SortDoc();
                if (VideoPath.Text != "") SortVideo();
                if (FotoPath.Text != "") SortFoto();
            }
            
        }

        private void SortDoc()
        {
            try
            {
                if (SortPath.Text != "" && DocPath.Text != "")
                {
                    string ext = ".txt .doc .docx .pdf .xls";
                    Sorter sorter = new Sorter(ext, SortPath.Text, DocPath.Text);
                    sorter.Sort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Sorting of documents is finished");
        }
        private void SortVideo()
        {
            try
            {
                if (SortPath.Text != "" && DocPath.Text != "")
                {
                    string ext = ".mp4 .mov .mkv";
                    Sorter sorter = new Sorter(ext, SortPath.Text, VideoPath.Text);
                    sorter.Sort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Sorting of video is finished");
        }
        private void SortFoto()
        {
            try
            {
                if (SortPath.Text != "" && DocPath.Text != "")
                {
                    string ext = ".png .jpeg .jpg";
                    Sorter sorter = new Sorter(ext, SortPath.Text, FotoPath.Text);
                    sorter.Sort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Sorting of foto is finished");
        }
        
    }
}
