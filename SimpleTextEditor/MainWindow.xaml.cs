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
using Microsoft.Win32;
using System.IO;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void menuFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void creteFile_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text != "")
            {
                SaveFile();
            }
            tb.Text = "";
        }

        private void opFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
          
            bool? res = ofd.ShowDialog();
            if (res !=false)
            {
                Stream mstrem;
                if ((mstrem = ofd.OpenFile()) != null)
                {
                    string file_name = ofd.FileName;
                    string file_txt = File.ReadAllText(file_name);
                    tb.Text = file_txt;
                }
            }
        }

        private void saveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    

        private void chooseFont_Click(object sender, RoutedEventArgs e)
        {

        }

        private void font1_Click(object sender, RoutedEventArgs e)
        {
           
            tb.FontFamily = new FontFamily("Times New Roman");
            font2.IsCheckable = false;

        }

        private void font2_Click(object sender, RoutedEventArgs e)
        {
            tb.FontFamily = new FontFamily("Verdana");
            
           font1.IsCheckable = false;
           
        }

        private void selectFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = selectFontSize.SelectedItem.ToString();
            fontSize = fontSize.Substring(fontSize.Length - 2);
            switch (fontSize)
            {
                case "10":
                    tb.FontSize = 10;
                    break;
                case "14":
                    tb.FontSize = 14;
                    break;
                case "16":
                    tb.FontSize = 16;
                    break;
                case "20":
                    tb.FontSize = 20;
                    break;
                case "32":
                    tb.FontSize = 32;
                    break;
                case "40":
                    tb.FontSize = 40;
                    break;
            }
        }

       public void SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            bool? res1 = sfd.ShowDialog();
            if (res1 != false) {
                using (Stream s = File.Open(sfd.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(tb.Text);
                    }
                }
            }
        }
    }
}
