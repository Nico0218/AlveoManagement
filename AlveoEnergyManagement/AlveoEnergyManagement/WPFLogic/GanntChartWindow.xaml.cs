using AlveoEnergyManagement.NetworkLayer;
using System.Windows;

namespace AlveoEnergyManagement.WPFLogic
{
    /// <summary>
    /// Interaction logic for GanntChartWindow.xaml
    /// </summary>
    public partial class GanntChartWindow : Window
    {
        DummyData dummyData;
        public GanntChartWindow()
        {
            InitializeComponent();
            dummyData = new DummyData();
            this.WindowStartup();
        }

        private void WindowStartup() {
            txtGanntID.Text = dummyData.GetSampleData().ID;
        }
    }
}
