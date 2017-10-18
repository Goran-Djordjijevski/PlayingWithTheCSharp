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

namespace WPFSimpleApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Employee e1 = new Employee(name: "Goran");

            Employee e2 = new Employee(name: "Djordjijevski");

            Output.Text = $"{e1.Name} {e2.Name}";
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
