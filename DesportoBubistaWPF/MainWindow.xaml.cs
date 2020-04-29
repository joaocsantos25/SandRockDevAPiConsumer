using SandRockDevAPILibrary;
using System.Windows;

namespace DesportoBubistaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainLeague ms = new MainLeague();
            ms.Show();
        }

        private void Clubs_Button_Click(object sender, RoutedEventArgs e)
        {
            MainClub ms = new MainClub();
            ms.Show();
        }

        private void Button_Schedule_Click(object sender, RoutedEventArgs e)
        {
            MainSchedules ms = new MainSchedules();
            ms.Show();
        }
    }
}
