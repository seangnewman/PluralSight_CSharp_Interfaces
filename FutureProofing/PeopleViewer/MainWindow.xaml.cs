using PersonLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PeopleRepository peopleRepo = new PeopleRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            List<Person> people =  peopleRepo.GetPeople();

            //foreach (var person in people)
            //{
            //    PersonListBox.Items.Add(person);
            //}
            PersonListBox.ItemsSource = people;
        }

        private void InterfaceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
            IEnumerable<Person> people = peopleRepo.GetPeople();

            //foreach (var person in people)
            //{
            //    PersonListBox.Items.Add(person);
            //}
            PersonListBox.ItemsSource = people;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            //PersonListBox.Items.Clear();
            PersonListBox.ItemsSource = null;

        }
    }
}
