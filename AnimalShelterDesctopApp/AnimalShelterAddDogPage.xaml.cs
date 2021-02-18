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
    /// Logic interaction for class AnimalShelterAddDogPage.xaml
    /// </summary>
    public partial class AnimalShelterAddDogPage : Page
    {
        private AnimalShelterDatabaseEntities _databaseEntities = new AnimalShelterDatabaseEntities();
        /// <summary>
        /// Constructor for class AnimalShelterAddDogPage.xaml
        /// </summary>
        public AnimalShelterAddDogPage()
        {
            InitializeComponent();
        }

        private void AddDogButtonClick(object sender, RoutedEventArgs e)
        {
            if (TextBoxAge.Text == "" || TextBoxName.Text == "")
            {
                MessageBox.Show("Pola nie mogą być puste");
                return;
            };
            var newDog = new Dogs()
            {
                Age = (int.Parse(TextBoxAge.Text)),
                Name = TextBoxName.Text
            };
            _databaseEntities.Dogs.Add(newDog);
            _databaseEntities.SaveChanges();
        }
    }
}
