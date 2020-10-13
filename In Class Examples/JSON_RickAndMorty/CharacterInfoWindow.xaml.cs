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
using System.Windows.Shapes;

namespace JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for CharacterInfoWindow.xaml
    /// </summary>
    public partial class CharacterInfoWindow : Window
    {
        public Character character { get; set; }
        public CharacterInfoWindow()
        {
            InitializeComponent();

        }

        public void Setup()//(Character c)
        {
            //character = c;

            Uri uri = new Uri(character.image);
            BitmapImage picture = new BitmapImage(uri);

            imgPicture.Source = picture;
            lblCharacterInfo.Content = $"{character.name}";

            this.Title = $"{character.name.ToUpper()} Information!";
        }
    }
}
