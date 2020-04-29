using SandRockDevAPILibrary;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace DesportoBubistaWPF
{
    /// <summary>
    /// Lógica interna para MainSchedules.xaml
    /// </summary>
    public partial class MainSchedules : Window
    {
        public MainSchedules()
        {
            InitializeComponent();
        }
        private Task<List<ScheduleModule>> GetResult(string method)
        {
            return WebApiProcessor<ScheduleModule>.Get(method);
        }

        private async void Button_LoadSchedule_Click(object sender, RoutedEventArgs e)
        {
            string method = "Schedules";
            List<ScheduleModule> scheduleModules = await GetResult(method);
            MainSchedulesListView.ItemsSource = scheduleModules;
        }
    }
}
