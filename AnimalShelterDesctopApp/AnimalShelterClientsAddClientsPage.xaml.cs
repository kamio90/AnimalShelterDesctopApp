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
    /// Logika interakcji dla klasy AnimalShelterClientsAddClientsPage.xaml
    /// </summary>
    public partial class AnimalShelterClientsAddClientsPage : Page
    {
        private AnimalShelterDatabaseEntities _databaseEntities = new AnimalShelterDatabaseEntities();
        public AnimalShelterClientsAddClientsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxAddress.Text == "" || TextBoxName.Text == "" || TextBoxName.Text == "")
            {
                MessageBox.Show("Pola nie mogą być puste");
                return;
            }

            var newClient = new Clients()
            {
                Adress = TextBoxAddress.Text,
                Name = TextBoxName.Text,
                Surname = TextBoxSurname.Text
            };
            _databaseEntities.Clients.Add(newClient);
            _databaseEntities.SaveChanges();
        }
    }
}
