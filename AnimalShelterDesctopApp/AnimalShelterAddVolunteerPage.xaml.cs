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
    /// Logika interakcji dla klasy AnimalShelterAddVolunteerPage.xaml
    /// </summary>
    public partial class AnimalShelterAddVolunteerPage : Page
    {
        private AnimalShelterDatabaseEntities _databaseEntities = new AnimalShelterDatabaseEntities();
        public AnimalShelterAddVolunteerPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text == "" || TextBoxSurname.Text =="")
            {
                MessageBox.Show("Pola nie mogą być puste");
                return;
            }

            var newVolunteer = new Volunteer()
            {
                Name = TextBoxName.Text,
                Surname = TextBoxSurname.Text
            };
            _databaseEntities.Volunteer.Add(newVolunteer);
            _databaseEntities.SaveChanges();
        }
    }
}
