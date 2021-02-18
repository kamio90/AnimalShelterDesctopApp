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
    /// Logika interakcji dla klasy AnimalShelterVolunteer.xaml
    /// </summary>
    public partial class AnimalShelterVolunteer : Page
    {
        public AnimalShelterVolunteer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnimalShelterAddVolunteerPage animalShelterAddVolunteerPage = new AnimalShelterAddVolunteerPage();
            NavigationService.Navigate(animalShelterAddVolunteerPage);
        }
    }
}
