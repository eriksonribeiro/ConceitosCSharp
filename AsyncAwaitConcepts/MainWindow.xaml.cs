using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.IO;

namespace AsyncAwaitConcepts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            // 1 - First Step Application will be blocked until process has been finished
            // DownloadHtml("https://www.itg.com.br/");

            // 2 - Application wont be blocked until process has been finished
            DownloadHtmlAsync("https://www.itg.com.br/");

            // 3- 
            //var html = GetHtml("https://www.itg.com.br/");
            //MessageBox.Show(html.Substring(0, 10));

            //4 - 
            var getHtmlTask = GetHtmlAsync("https://www.itg.com.br/");
            MessageBox.Show("Awaiting");

            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));

        }


        // 1 - Without Async Await
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Projetos\ConceitosCSharp\AsyncAwaitConcepts\file\temp.html"))
            {
                streamWriter.Write(html);
            }
        }

        // 2 - With Async Await
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Projetos\ConceitosCSharp\AsyncAwaitConcepts\file\temp.html"))
            {
               await streamWriter.WriteAsync(html);
            }
        }

        // 3 - 
        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        //4 - 
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);
        }

    }
}
