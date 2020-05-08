using TrainStation.Model;
using TrainStation.Test;
using TrainStation.ViewModel;
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

namespace TrainStation.Views
{
    /// <summary>
    /// Interaction logic for VanView.xaml
    /// </summary>
    public partial class VanView : UserControl
    {
        public VanView()
        {
            InitializeComponent();
        }
        private void ComboVans_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VanViewModel o = this.DataContext as VanViewModel;
            o.Station.SelectedVan = o.Vans.Find((item) => item.Number == Int16.Parse(o.SelectedVanNumber));
            this.DataContext = o;
        }


        private void GetVans_Click(object sender, RoutedEventArgs e)
        {
            VanViewModel o = this.DataContext as VanViewModel;

            try
            {
                this.ComboVans.ItemsSource = o.loadVans(o.Station.SelectedTrain);
            }
            catch 
            {
                this.ComboVans.ItemsSource = new List<VanModel>() { };
            }

            Deb.Print(o.Station.SelectedVan, "selected train from vans");
        }
    }
}
