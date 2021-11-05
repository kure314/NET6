using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Dataset.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Net.Http.Json;



namespace DesktopApp
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

        private async void btn_Nacti_Click(object sender, RoutedEventArgs e)
        {
            //textBox_Hlaska.
            List<Client> clients = new List<Client>();
            using (HttpClient c = new HttpClient())
            {
                string uri = @"http://localhost:59064/api/APIClients";
                //string uri = @"https://localhost:5000/api/APIClients";
                //var result = await c.GetAsync(uri);
                // var result = c.GetFromJsonAsync<IEnumerable<Client>>(uri);

                
                var result =
                    await c.GetFromJsonAsync<IEnumerable<Client>>(uri);

                foreach (var client in result)
                {
                    textBox_Hlaska.Text += client.ToString() + Environment.NewLine;
                }

            }
        }
    }
}
