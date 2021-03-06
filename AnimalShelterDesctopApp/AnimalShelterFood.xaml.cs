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
    /// Logic for class AnimalShelterFood.xaml
    /// </summary>
    public partial class AnimalShelterFood : Page
    {
        private readonly AnimalShelterDatabaseEntities _databaseEntities = new AnimalShelterDatabaseEntities();
        /// <summary>
        /// Constructor for class AnimalShelterFood.xaml
        /// </summary>
        public AnimalShelterFood()
        {
            InitializeComponent();
            this.UpdateFood();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalShelterAddFoodPage animalShelterAddFoodPage = new AnimalShelterAddFoodPage();
            NavigationService?.Navigate(animalShelterAddFoodPage);
        }

        private void UpdateFood()
        {
            var databaseData = from row in _databaseEntities.Food select row;
            this.foodDataGrid.ItemsSource = databaseData.ToList();
        }
    }
}
