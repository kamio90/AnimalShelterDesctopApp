﻿using System;
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

namespace AnimalShelterDesctopApp
{
    /// <summary>
    /// Logic for class AnimalShelterVolunteer.xaml
    /// </summary>
    public partial class AnimalShelterVolunteer : Page
    {
        private readonly AnimalShelterDatabaseEntities _databaseEntities = new AnimalShelterDatabaseEntities();
        /// <summary>
        /// Constructor for class AnimalShelterVolunteer.xaml
        /// </summary>
        public AnimalShelterVolunteer()
        {
            InitializeComponent();
            this.UpdateVolunteer();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalShelterAddVolunteerPage animalShelterAddVolunteerPage = new AnimalShelterAddVolunteerPage();
            NavigationService?.Navigate(animalShelterAddVolunteerPage);
        }

        private void UpdateVolunteer()
        {
            var databaseData = from row in _databaseEntities.Volunteer select row;
            this.volunteerDataGrid.ItemsSource = databaseData.ToList();
        }
    }
}
