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
    /// Interaction logic for TrainView.xaml
    /// </summary>
    public partial class TrainView : UserControl
    {
        public TrainView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TrainViewModel o = this.DataContext as TrainViewModel;

            if (o.SelectedPlaceArrival == "" && o.SelectedPlaceDeparture == "")
            {
                o.getTrainList();
            }
            else 
            {
                o.getAccessedTrainList(o.SelectedPlaceArrival, o.SelectedPlaceDeparture);
            }
            this.ComboTrains.ItemsSource = o.TrainList;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            TrainViewModel o = this.DataContext as TrainViewModel;
            o.Station.SelectedTrain = o.TrainList.Find((item) => item.Name == o.SelectedTrainName);
            this.DataContext = o;
            Deb.Print(o.Station.SelectedTrain, "<======>");
        }

    }
}
