using Newtonsoft.Json;
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

namespace JSON_GOT
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

        private void btnGetQuote_Click(object sender, RoutedEventArgs e)
        {
            string quoteURL = @"https://got-quotes.herokuapp.com/quotes";

            using (var client = new HttpClient())
            {
                string gotQuoteAsJson = client.GetStringAsync(quoteURL).Result;

                GameOfThronesQuoteAPI quote = JsonConvert.DeserializeObject<GameOfThronesQuoteAPI>(gotQuoteAsJson);

                lblQuote.Content = $"{quote.quote}\n\n\t-{quote.character}";
            }
        }
    }
}
