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
    /// Logic for class Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        /// <summary>
        /// Constructor for class Page1.xaml
        /// </summary>
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalShelterStorage animalShelterStoragePage = new AnimalShelterStorage();
            this.NavigationService?.Navigate(animalShelterStoragePage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AnimalShelterClients animalShelterClientsPage = new AnimalShelterClients();
            this.NavigationService?.Navigate(animalShelterClientsPage);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AnimalShelterDogs animalShelterDogsPage = new AnimalShelterDogs();
            this.NavigationService?.Navigate(animalShelterDogsPage);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AnimalShelterFood animalShelterFoodPage = new AnimalShelterFood();
            this.NavigationService?.Navigate(animalShelterFoodPage);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AnimalShelterOrders animalShelterOrdersPage = new AnimalShelterOrders();
            var navigationService = this.NavigationService;
            navigationService?.Navigate(animalShelterOrdersPage);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AnimalShelterVolunteer animalShelterVolunteerPage = new AnimalShelterVolunteer();
            this.NavigationService?.Navigate(animalShelterVolunteerPage);
        }
    }
}
