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
    /// Interaction logic for PassangerView.xaml
    /// </summary>
    public partial class PassangerView : UserControl
    {
        public PassangerView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PassangerViewModel o = this.DataContext as PassangerViewModel;
            o.Station.Passanger = new Model.PassangerModel(o.Name, o.Telephone, o.Email);
            Deb.Print(o.Name);
            Deb.Print(o.Telephone);
            Deb.Print(o.Email);
        }
    }
}
