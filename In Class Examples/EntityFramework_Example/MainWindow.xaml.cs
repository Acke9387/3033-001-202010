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

namespace EntityFramework_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static DB_128040_practiceEntities db = new DB_128040_practiceEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            //var game5 = db.FootballSchedules.Find(5);

            var homegames = db.FootballSchedules.Where(game => game.IsHomeGame == true && game.Season == 2019).OrderBy(x => x.Date);
            var awaygames = db.FootballSchedules.Where(game => game.IsHomeGame == false && game.Season == 2019).OrderBy(x => x.Date);
            var texasGames = db.FootballSchedules.Where(game => game.Opponent.Trim().ToLower() == "texas");

            foreach (var game in homegames)
            {
                lst1.Items.Add($"OU vs {game.Opponent} - {game.Date}");
            }

            foreach (var game in awaygames)
            {
                lst2.Items.Add($"OU @ {game.Opponent.Trim()} - {game.Date}");
            }


            //foreach (var game in db.FootballSchedules)
            //{
            //    if (game.IsHomeGame)
            //    {
            //        lst1.Items.Add($"OU vs {game.Opponent} - {game.Date}");

            //    }
            //    else
            //    {
            //        lst2.Items.Add($"OU @ {game.Opponent} - {game.Date}");
            //    }
            //}

        }
    }
}
