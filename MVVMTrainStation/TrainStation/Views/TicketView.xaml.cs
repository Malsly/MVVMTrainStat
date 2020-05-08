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
    /// Interaction logic for TicketController.xaml
    /// </summary>
    public partial class TicketController : UserControl
    {
        public TicketController()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TrainStation.ViewModel.TicketViewModel TicketViewModelObject = new TrainStation.ViewModel.TicketViewModel();
            TicketViewModelObject.Station = PassangerViewModel.GlobalStation;
            this.DataContext = TicketViewModelObject;

            TicketViewModel o = this.DataContext as TicketViewModel;

            this.DataContext = o;
             
            Deb.Print(o, "selected Seat from vans");
        }
    }
}
