using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
using System.IO.Compression;


namespace Update
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbl_logo1.Visibility = Visibility.Hidden;
            lbl_logo2.Visibility = Visibility.Hidden;
            img_logo.Visibility = Visibility.Hidden;
            prog_bar2.Visibility = Visibility.Visible;
           


            Thread.Sleep(1000);
            prog_bar2.Value = 0;

            Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(50);
                    this.Dispatcher.Invoke(() => //Use Dispather to Update UI Immediately  
                    {
                        prog_bar2.Value = i;
                        if (i == 100)
                        {
                            WebClient webClient = new WebClient();
                            var client = new WebClient();

                            string[] files = Directory.GetFiles(@"C:\Users\Youcode\Desktop\clean\bin\Release");

                            foreach (string file in files)
                            {
                                File.Delete(file);
                            }
                            client.DownloadFile("https://docs.google.com/uc?export=download&id=1XFIOscMR1koTXv1aR9-WSZpXN1mDM13Y", @"C:\Users\Youcode\Desktop\clean\bin\Release\Release.zip");
                            string zipPath = @"C:\Users\Youcode\Desktop\clean\bin\Release\Release.zip";
                            //. pour racourcir 
                            string extractPath = @"C:\Users\Youcode\Desktop\clean\bin\Release";
                            ZipFile.ExtractToDirectory(zipPath, extractPath);
                            File.Delete(@"C:\Users\Youcode\Desktop\clean\bin\Release\Release.zip");
                            Process.Start(@"C:\Users\Youcode\Desktop\clean\bin\Release\C_N_V.exe");
                            this.Close();



                        }
                        //lbl_CountDownTimer.Text = i.ToString();
                    });
                }
            });

        }
    }

}
