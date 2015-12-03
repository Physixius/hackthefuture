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
        HackTheFuture.PeopleDataSet peopleDataSet;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            peopleDataSet = ((HackTheFuture.PeopleDataSet)(this.FindResource("peopleDataSet")));
            // Load data into the table People. You can modify this code as needed.
            HackTheFuture.PeopleDataSetTableAdapters.PeopleTableAdapter peopleDataSetPeopleTableAdapter = new HackTheFuture.PeopleDataSetTableAdapters.PeopleTableAdapter();
            peopleDataSetPeopleTableAdapter.Fill(peopleDataSet.People);
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
            
        }
    }
}
