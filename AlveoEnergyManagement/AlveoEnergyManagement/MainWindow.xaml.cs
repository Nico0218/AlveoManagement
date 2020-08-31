using AlveoEnergyManagement.NetworkLayer;
using AlveoEnergyManagement.WPFLogic;
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

namespace AlveoEnergyManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserService userService;
        public MainWindow()
        {
            InitializeComponent();
            userService = new UserService();
            userService.UserLogin();
        }

        private void btnOpenGannt_Click(object sender, RoutedEventArgs e)
        {
            GanntChartWindow ganntChartWindow = new GanntChartWindow();
            ganntChartWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            ganntChartWindow.Show();
        }
    }
}
