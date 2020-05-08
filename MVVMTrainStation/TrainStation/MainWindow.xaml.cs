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
using TrainStation.Test;
using TrainStation.ViewModel;

namespace TrainStation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        TrainStation.ViewModel.StationViewModel stationViewModelObject = new TrainStation.ViewModel.StationViewModel();

        private void PassangerViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            TrainStation.ViewModel.PassangerViewModel passangerViewModelObject = new TrainStation.ViewModel.PassangerViewModel();
            PassangerViewModel.GlobalStation = stationViewModelObject;
            passangerViewModelObject.Station = stationViewModelObject;
            PassangerViewControl.DataContext = passangerViewModelObject;
            Deb.Print("Passanger view loaded");
        }

        private void TrainViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            TrainStation.ViewModel.TrainViewModel trainViewModelObject = new TrainStation.ViewModel.TrainViewModel();
            stationViewModelObject.LoadTrainList();
            trainViewModelObject.Station = stationViewModelObject;
            trainViewModelObject.getTrainList();
            TrainViewControl.DataContext = trainViewModelObject;
            Deb.Print("Trains view loaded");
        }

        private void VanViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            TrainStation.ViewModel.VanViewModel VanViewModelObject = new TrainStation.ViewModel.VanViewModel();
            VanViewModelObject.loadVanClasses();
            VanViewModelObject.Station = stationViewModelObject;
            VanViewControl.DataContext = VanViewModelObject;
            Deb.Print("Vans view loaded");
        }
        private void SeatViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            TrainStation.ViewModel.SeatViewModel SeatViewModelObject = new TrainStation.ViewModel.SeatViewModel();
            SeatViewModelObject.LoadSeatClasses();
            SeatViewModelObject.Station = stationViewModelObject;
            SeatViewControl.DataContext = SeatViewModelObject;
            Deb.Print("Seats view loaded");
        }
        private void TicketViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            Deb.Print("Ticket view loaded");
        }
    }
}
