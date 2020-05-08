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
    /// Interaction logic for SeatView.xaml
    /// </summary>
    public partial class SeatView : UserControl
    {
        public SeatView()
        {
            InitializeComponent();
        }

        private void ComboSeats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SeatViewModel o = this.DataContext as SeatViewModel;
            o.Station.SelectedSeat = o.Seats.Find((item) => item.Number == Int16.Parse(o.SelectedSeatNumber));
            this.DataContext = o;
        }

        private void GetSeats_Click(object sender, RoutedEventArgs e)
        {
            SeatViewModel o = this.DataContext as SeatViewModel;

            try
            {
                this.ComboSeats.ItemsSource = o.loadSeats(o.Station.SelectedVan);
            }
            catch
            {
                this.ComboSeats.ItemsSource = new List<SeatModel> { };
            }

            Deb.Print(o.Station.SelectedSeat, "selected Seat from vans");
        }
    }
}
