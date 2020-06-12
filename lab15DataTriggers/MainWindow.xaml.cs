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

namespace lab15DataTriggers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new List<Cd>
            {
                new Cd("Ballady", $@"{Environment.CurrentDirectory}\images\ballady.jpg"),
                new Cd("Chroń mnie", $@"{Environment.CurrentDirectory}\images\chron_mnie.jpg"),
                new Cd("Etna", ""),
                new Cd("The very best of", $@"{Environment.CurrentDirectory}\images\the_very_best_of.jpg"),
            };

            var x = Environment.UserName;
        }
    }
}
