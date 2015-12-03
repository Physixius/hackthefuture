using System;
using System.Collections.Generic;
using System.Data;
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
        HackTheFuture.PeopleDedicatedDataSetTableAdapters.PeopleTableAdapter peopleDedicatedDataSetPeopleTableAdapter;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            peopleDedicatedDataSet = ((HackTheFuture.PeopleDedicatedDataSet)(this.FindResource("peopleDedicatedDataSet")));
            // Load data into the table People. You can modify this code as needed.
            peopleDedicatedDataSetPeopleTableAdapter = new HackTheFuture.PeopleDedicatedDataSetTableAdapters.PeopleTableAdapter();
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
            DataRow person;
            for (int i = 0; i < 1000; i++)
            {
                person = peopleDedicatedDataSet.People.Rows[i];
                if ((int)(byte)person["Job"] == 0)
                {
                    person.SetField<int>("Job",FindJob(person));
                    //Console.WriteLine(FindJob(person));
                }
            }

            peopleDedicatedDataSetPeopleTableAdapter.Update(peopleDedicatedDataSet.People);
            peopleDedicatedDataSetPeopleTableAdapter.Fill(peopleDedicatedDataSet.People);

            System.Windows.Data.CollectionViewSource peopleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("peopleViewSource")));
            peopleViewSource.View.MoveCurrentToFirst();
        }

        private int FindJob(DataRow dataRow)
        {
            int strength = (int)(byte)dataRow["Strength"];
            int perception = (int)(byte)dataRow["Perception"];
            int endurance = (int)(byte)dataRow["Endurance"];
            int charisma = (int)(byte)dataRow["Charisma"];
            int intelligence = (int)(byte)dataRow["Intelligence"];
            int agility = (int)(byte)dataRow["Agility"];
            int luck = (int)(byte)dataRow["Luck"];

            //OrderHandHaver
            if (strength >=3 && strength <= 4 &&
                perception >= 3 && perception <= 4 &&
                endurance >= 2 && endurance <= 3 &&
                charisma >= 0  && charisma <= 4 &&
                intelligence >= 1 && intelligence <= 2 &&
                agility >= 2 && agility <= 4 &&
                luck >= 1 && luck <= 3)
            {
                return 1;
            }
            //Structureel ingenieur
            else if (strength >= 2 && strength <= 3 &&
                perception >= 2 && perception <= 3 &&
                endurance >= 2 && endurance <= 2 &&
                charisma >= 0 && charisma <= 1 &&
                intelligence >= 3 && intelligence <= 4 &&
                agility >= 2 && agility <= 3 &&
                luck >= 3 && luck <= 4)
            {
                return 2;
            }
            //Electrisch ingenieur
            else if (strength >= 1 && strength <= 2 &&
                perception >= 2 && perception <= 3 &&
                endurance >= 1 && endurance <= 2 &&
                charisma >= 0 && charisma <= 1 &&
                intelligence >= 2 && intelligence <= 3 &&
                agility >= 2 && agility <= 3 &&
                luck >= 1 && luck <= 3)
            {
                return 3;
            }
            //Verzorger
            else if (strength >= 1 && strength <= 2 &&
                perception >= 2 && perception <= 3 &&
                endurance >= 3 && endurance <= 4 &&
                charisma >= 2 && charisma <= 3 &&
                intelligence >= 1 && intelligence <= 3 &&
                agility >= 3 && agility <= 4 &&
                luck >= 1 && luck <= 2)
            {
                return 4;
            }
            //Opvoeder
            else if (strength >= 1 && strength <= 3 &&
                perception >= 3 && perception <= 4 &&
                endurance >= 2 && endurance <= 4 &&
                charisma >= 2 && charisma <= 3 &&
                intelligence >= 1 && intelligence <= 3 &&
                agility >= 2 && agility <= 4 &&
                luck >= 1 && luck <= 4)
            {
                return 5;
            }
            //Dokter
            else if (strength >= 1 && strength <= 3 &&
                perception >= 3 && perception <= 3 &&
                endurance >= 1 && endurance <= 2 &&
                charisma >= 1 && charisma <= 3 &&
                intelligence >= 3 && intelligence <= 4 &&
                agility >= 1 && agility <= 3 &&
                luck >= 1 && luck <= 3)
            {
                return 6;
            }
            //Politieker
            else if (strength >= 0 && strength <= 2 &&
                perception >= 3 && perception <= 4 &&
                endurance >= 1 && endurance <= 3 &&
                charisma >= 4 && charisma <= 4 &&
                intelligence >= 0 && intelligence <= 4 &&
                agility >= 2 && agility <= 4 &&
                luck >= 3 && luck <= 4)
            {
                return 7;
            }
            //Energiedeskundige
            else if (strength >= 0 && strength <= 2 &&
                perception >= 2 && perception <= 4 &&
                endurance >= 0 && endurance <= 2 &&
                charisma >= 0 && charisma <= 2 &&
                intelligence >= 2 && intelligence <= 3 &&
                agility >= 1 && agility <= 3 &&
                luck >= 1 && luck <= 3)
            {
                return 8;
            }
            //Geoloog
            else if (strength >= 2 && strength <= 4 &&
                perception >= 2 && perception <= 4 &&
                endurance >= 1 && endurance <= 2 &&
                charisma >= 0 && charisma <= 2 &&
                intelligence >= 1 && intelligence <= 4 &&
                agility >= 0 && agility <= 2 &&
                luck >= 0 && luck <= 3)
            {
                return 9;
            }
            //Kaartenmaker
            else if (strength >= 0 && strength <= 1 &&
                perception >= 2 && perception <= 4 &&
                endurance >= 0 && endurance <= 3 &&
                charisma >= 0 && charisma <= 1 &&
                intelligence >= 1 && intelligence <= 1 &&
                agility >= 0 && agility <= 2 &&
                luck >= 1 && luck <= 4)
            {
                return 10;
            }
            //Geschiedkundige
            else if (strength >= 0 && strength <= 2 &&
                perception >= 3 && perception <= 4 &&
                endurance >= 0 && endurance <= 3 &&
                charisma >= 0 && charisma <= 2 &&
                intelligence >= 2 && intelligence <= 3 &&
                agility >= 1 && agility <= 2 &&
                luck >= 3 && luck <= 4)
            {
                return 11;
            }
            //Geheim Agent
            else if (strength >= 1 && strength <= 4 &&
                perception >= 3 && perception <= 4 &&
                endurance >= 2 && endurance <= 4 &&
                charisma >= 3 && charisma <= 4 &&
                intelligence >= 3 && intelligence <= 4 &&
                agility >= 3 && agility <= 4 &&
                luck >= 3 && luck <= 4)
            {
                return 12;
            }
            //Voedingsdeskundige
            else if (strength >= 0 && strength <= 2 &&
                perception >= 0 && perception <= 3 &&
                endurance >= 1 && endurance <= 4 &&
                charisma >= 0 && charisma <= 1 &&
                intelligence >= 1 && intelligence <= 3 &&
                agility >= 2 && agility <= 3 &&
                luck >= 1 && luck <= 4)
            {
                return 13;
            }
            //Afval verwerker
            else if (strength >= 3 && strength <= 4 &&
                perception >= 1 && perception <= 3 &&
                endurance >= 3 && endurance <= 4 &&
                charisma >= 0 && charisma <= 0 &&
                intelligence >= 1 && intelligence <= 2 &&
                agility >= 2 && agility <= 4 &&
                luck >= 0 && luck <= 2)
            {
                return 14;
            }
            //Afval verwerker
            else if (strength >= 3 && strength <= 4 &&
                perception >= 1 && perception <= 3 &&
                endurance >= 3 && endurance <= 4 &&
                charisma >= 0 && charisma <= 0 &&
                intelligence >= 1 && intelligence <= 2 &&
                agility >= 2 && agility <= 4 &&
                luck >= 0 && luck <= 2)
            {
                return 14;
            }
            else
            {
                return 0;
            }
        }
    }
}
