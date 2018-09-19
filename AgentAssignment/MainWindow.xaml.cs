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
        
        List<Agent> _AgentList = new List<Agent>();

        public MainWindow()
        {
            InitializeComponent();

           

            //ListBoxAgents.DataContext = _AgentList;
        }

        private void AddNew_Click(object sender, RoutedEventArgs e)
        {
            Agents agents = (Agents)this.FindResource("agents");

            /* ListBoxAgents.Items.Clear();
             foreach (var agent in _AgentList)
             {
                 ListBoxAgents.Items.Add(agent.CodeName);
             }*/

        }

        private void ListBoxAgents_Loaded(object sender, RoutedEventArgs e)
        {
            /* foreach (var agent in _AgentList)
             {
                 ListBoxAgents.Items.Add(agent.CodeName);
             }*/
           
        }

        private void ListBoxAgents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int index = _AgentList.FindIndex(x => x.CodeName == ListBoxAgents.SelectedItem.ToString());

            //foreach (var obj in _AgentList)
            //{
            //    if(obj.CodeName == ListBoxAgents.SelectedItem.ToString())
            //    {
            //        TextBoxID.Text = obj.ID;
            //        TextBoxCodeName.Text = obj.CodeName;
            //        TextBoxSpeciality.Text = obj.Speciality;
            //        TextBoxAssignment.Text = obj.Assignment;
            //    }
            //}

            //TextBoxID.Text = _AgentList[index].ID;
            //TextBoxCodeName.Text = _AgentList[index].CodeName;
            //TextBoxSpeciality.Text = _AgentList[index].Speciality;
            //TextBoxAssignment.Text = _AgentList[index].Assignment;

        }
    }
}
