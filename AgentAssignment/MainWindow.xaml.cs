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

namespace AgentAssignment
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

        private void AddNew_Click(object sender, RoutedEventArgs e)
        {
            Agents agents = (Agents)this.FindResource("agents");
            agents.Add(new Agent());

            ListBoxAgents.SelectedIndex = ListBoxAgents.Items.Count - 1;
            ListBoxAgents.Focus();
        }

        private void ListBoxAgents_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void ListBoxAgents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
