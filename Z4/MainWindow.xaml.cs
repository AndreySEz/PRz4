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

namespace Z4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Bus bus1 = new Bus("Петренко И.И.", 52, "Mazda", 2002, 5000);
            Bus bus2 = new Bus("Деревянов М.И.", 12, "Atlas", 2001, 5900);
            Bus bus3 = new Bus("Митин В.Е.", 52, "Mars", 2012, 3400);
            Bus bus4 = new Bus("Пастырев Р.В.", 5, "Lises", 1989, 52000);
            buses.Add(bus1);
            buses.Add(bus2);
            buses.Add(bus3);
            buses.Add(bus4);
            label1.Content = "Водитель \t Марш. \t Марка \t Год \t Пробег";
            foreach (Bus bus in buses)
            {
                label1.Content +="\n" + bus.GetInfo();
            }
        }

        List<Bus> buses = new List<Bus>();

        private void click(object sender, RoutedEventArgs e)
        {
            string listRoute = "";
            string listExp = "";
            string listProbeg = "";
            foreach (Bus bus in buses)
            {
                if (bus.busRouteNumber==Convert.ToInt32((txtBoxRoute.Text))) listRoute += "\n" + bus.GetInfo();
                if (Convert.ToInt32((DateTime.Now.Year.ToString()))-bus.busYear> Convert.ToInt32(txtBoxExp.Text)) listExp += "\n" + bus.GetInfo();
                if (bus.busProbeg>=Convert.ToInt32(txtBoxProbeg.Text)) listProbeg += "\n" + bus.GetInfo();
            }
            System.Windows.MessageBox.Show($"Автобусы, ездящие по {txtBoxRoute.Text} маршруту:\n {listRoute}\nАвтобусы в эксплуатации больше {Convert.ToInt32(txtBoxExp.Text)} лет:\n\n {listExp}\n\nАвтобусы, ездящие больше {Convert.ToInt32(txtBoxProbeg.Text)} км:\n {listProbeg}");
        }
    }
}
