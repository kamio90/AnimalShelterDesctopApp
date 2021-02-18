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

namespace AnimalShelterDesctopApp
{
    /// <summary>
    /// Logic for class AnimalShelterAddFoodPage.xaml
    /// </summary>
    public partial class AnimalShelterAddFoodPage : Page
    {
        private readonly AnimalShelterDatabaseEntities _databaseEntities = new AnimalShelterDatabaseEntities();
        /// <summary>
        /// Constructor for class AnimalShelterAddFoodPage.xaml
        /// </summary>
        public AnimalShelterAddFoodPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text == "" || TextBoxCount.Text == "")
            {
                MessageBox.Show("Pola nie mogą być puste");
                return;
            }

            var newFood = new Food()
            {
                Count = Int32.Parse(TextBoxCount.Text),
                Name = TextBoxName.Text
            };
            _databaseEntities.Food.Add(newFood);
            _databaseEntities.SaveChanges();
        }
    }
}
