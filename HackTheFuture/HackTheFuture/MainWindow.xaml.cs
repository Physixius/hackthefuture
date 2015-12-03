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

namespace HackTheFuture
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
        HackTheFuture.PeopleDedicatedDataSet peopleDedicatedDataSet;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            peopleDedicatedDataSet = ((HackTheFuture.PeopleDedicatedDataSet)(this.FindResource("peopleDedicatedDataSet")));
            // Load data into the table People. You can modify this code as needed.
            HackTheFuture.PeopleDedicatedDataSetTableAdapters.PeopleTableAdapter peopleDedicatedDataSetPeopleTableAdapter = new HackTheFuture.PeopleDedicatedDataSetTableAdapters.PeopleTableAdapter();
            peopleDedicatedDataSetPeopleTableAdapter.Fill(peopleDedicatedDataSet.People);
            System.Windows.Data.CollectionViewSource peopleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("peopleViewSource")));
            peopleViewSource.View.MoveCurrentToFirst();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JobButton_Click(object sender, RoutedEventArgs e)
        {
            FindJobs();
        }

        private void FindJobs()
        {
            for(int i = 0; i<100; i++)
            {
                //peopleDataSet.Tables[0].Rows[i][0] = "";

            }
            
        }
    }
}
