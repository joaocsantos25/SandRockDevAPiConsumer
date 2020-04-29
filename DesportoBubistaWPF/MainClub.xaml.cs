
using SandRockDevAPILibrary;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace DesportoBubistaWPF
{
    /// <summary>
    /// Interaction logic for MainClub.xaml
    /// </summary>
    public partial class MainClub : Window
    {
        WebApiProcessor<ClubModel> webApiProcessor;
        public MainClub()
        {
            InitializeComponent();
            webApiProcessor = new WebApiProcessor<ClubModel>();

        }

        private async void LoadAllCLub_Button_Click(object sender, RoutedEventArgs e)
        { 
           
            string method = "clubs";
            List<ClubModel> clubModels = await GetResult(method);
            listViewClub.ItemsSource = clubModels;
        }

        private Task<List<ClubModel>> GetResult(string method)
        {
            return WebApiProcessor<ClubModel>.Get(method);
        }

        private Task<ClubModel> GetSingleResult(string method)
        {
            return WebApiProcessor<ClubModel>.GetSingle(method);
        }

        private void ListViewClub_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            
            if (e.AddedItems.Count > 0)
            {
                string PhotoName = ((ClubModel)(listViewClub.SelectedItem)).Photo;
                var uriSource = new Uri("http://joaowinhost.com/desportobubista/Uploads/Clubs/" + PhotoName);
                clubimage.Source = new BitmapImage(uriSource);                
            }  
        }
    }
}
