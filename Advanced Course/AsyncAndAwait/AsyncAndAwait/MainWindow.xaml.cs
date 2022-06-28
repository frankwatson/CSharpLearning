using System;
using System.Collections.Generic;
using System.IO;
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

namespace AsyncAndAwait
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // DownloadHtmlAsync("https://msdn.microsoft.com");
            var getHtmlTask = GetHtmlAsync("https://msdn.microsoft.com");
            MessageBox.Show("Waiting for the task to complete");

            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }

        // Async version
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();

            return await webClient.DownloadStringTaskAsync(url);
        }


        // Non-Async version
        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        // Async version
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\Frank\Documents\Git\C#\Advanced Course\AsyncAndAwait\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

        // Non-Async verison
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\Frank\Documents\Git\C#\Advanced Course\AsyncAndAwait\result.html"))
            {
                streamWriter.Write(html);
            }
        }
    }
}
