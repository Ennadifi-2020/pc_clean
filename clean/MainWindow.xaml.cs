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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;
using System.Net;

namespace clean
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WebClient web = new WebClient();
        public MainWindow()
        {
            InitializeComponent();
        }
        public long Sizef()
        {
            DirectoryInfo winTemp = new DirectoryInfo(System.IO.Path.GetTempPath());
            long size = 0;
            var myDir = $@"C:\Users\Administrateur\Desktop\nadifi";

            var dirInfo = new DirectoryInfo(myDir);

            foreach (FileInfo fi in winTemp.EnumerateFiles("*", SearchOption.AllDirectories))
            {
                size += fi.Length;
            }

            //lbl-clean.Content = $"{size} bytes";
            return (size/1024)/1024;
        }
        public DateTime dateanal()
        {
            DateTime date = DateTime.Now;

            return date;
        }
        DirectoryInfo winTemp = new DirectoryInfo(System.IO.Path.GetTempPath());
        public void Delete()
        {

            foreach (FileInfo file in winTemp.EnumerateFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in winTemp.EnumerateDirectories())
            {
                dir.Delete(true);
            }
        }

        private void btn_vue_Click(object sender, RoutedEventArgs e)
        {

        }

        public void delete()
        {
            using (StreamWriter sw = File.AppendText("file.txt"))
            {
                sw.WriteLine($"Size of analyse is {Sizef()} Mo");
                sw.WriteLine("Date of analyse: " + DateTime.Now.ToString());
                sw.WriteLine("==================");
            }
            try
            {
                foreach (FileInfo file in winTemp.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in winTemp.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"erreur :{ex}");
            }

            
        }
        private void btn_analyz1_Click(object sender, RoutedEventArgs e)
        {
            //messageBox.Show("Hello first analyse");
            lbl_pc_1.Content = "Analyse en cours";
            btn_analyz1.IsEnabled = false;
            btn_analyz2.IsEnabled = false;
            prog_bar.Visibility = Visibility.Visible;
            lbl_date_der.Content = DateTime.Now.ToString();
            lbl_date_maj.Content = DateTime.Now.ToString();
            

            Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(50);
                    this.Dispatcher.Invoke(() =>
                    {
                        prog_bar.Value = i;
                        lbl_pourc.Content = i.ToString() + "%";

                        if (prog_bar.Value == 100)
                        {
                            MessageBox.Show("Analyse terminé");
                            lbl_pc_1.Content = "Pc-cleaner est un logiciel made in Maroc\n qui respecte votre vie privée";
                            
                            btn_analyz1.IsEnabled = true;
                            btn_analyz2.IsEnabled = true;
                            prog_bar.Visibility = Visibility.Hidden;
                            lbl_pourc.Visibility = Visibility.Hidden;
                            lbl_espace1.Content= Sizef() + " Mo";
                        }
                    });
                }
            });
        }

        private void btn_nett_Click(object sender, RoutedEventArgs e)
        {
            delete();
        }

        private void btn_historique2_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("File.txt");
        }

        private void prog_bar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
       
        private void btn_maj_Click(object sender, RoutedEventArgs e)
        {

       
                InitializeComponent();


                
                if (!web.DownloadString("https://pastebin.com/raw/ARNHiwwY").Contains("1.1.1"))
                {
                    var answer = MessageBox.Show("there is an availabale update, would you like to downoald it", "compuetr scan", MessageBoxButton.YesNo, MessageBoxImage.Information);

                    if (answer == MessageBoxResult.Yes)
                    {
                    Process.Start(@"C:\Users\Youcode\Desktop\Update\bin\Release\Update.exe");
                    this.Close();
                    }

                }
            }

        }
   
}
