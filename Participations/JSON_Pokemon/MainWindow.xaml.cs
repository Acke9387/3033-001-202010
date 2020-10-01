using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Windows;
using Newtonsoft.Json;

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AllPokemonAPI pokemonAPI;
            using (var client = new HttpClient())
            {
                string allPokeUrl = @"https://pokeapi.co/api/v2/pokemon/?offset=0&limit=1100";

                string json = client.GetStringAsync(allPokeUrl).Result;

                pokemonAPI = JsonConvert.DeserializeObject<AllPokemonAPI>(json);
            }

            foreach (var pokie in pokemonAPI.results.OrderBy(pokemon => pokemon.name))
            {
                cboPokies.Items.Add(pokie);
            }
        }

        private void cboPokies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
