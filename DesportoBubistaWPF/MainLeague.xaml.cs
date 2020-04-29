
using SandRockDevAPILibrary;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace DesportoBubistaWPF
{
    /// <summary>
    /// Interaction logic for MainLeague.xaml
    /// </summary>
    public partial class MainLeague : Window
    {
        public MainLeague()
        {
            InitializeComponent();
        }
        private Task<List<LeagueModel>> GetResult(string method)
        {
            return WebApiProcessor<LeagueModel>.Get(method);
        }

        private async void LoadAllLeague_Button_Click(object sender, RoutedEventArgs e)
        {
            string method = "leagues/GetAllLeagues";
            List<LeagueModel> leagueModels = await GetResult(method);
            listViewLeague.ItemsSource = leagueModels;
        }

        private async void LoadActiveLeague_Button_Click(object sender, RoutedEventArgs e)
        {
            string method = "leagues/GetAllLeaguesActive";
            List<LeagueModel> leagueModels = await GetResult(method);
            listViewLeague.ItemsSource = leagueModels;
        }
    }
}
