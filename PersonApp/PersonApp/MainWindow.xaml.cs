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

namespace PersonApp
{
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "John", LastName = "Doe" });
            people.Add(new Person { FirstName = "Mary", LastName = "Poppins" });
            people.Add(new Person { FirstName = "Zack", LastName = "Snyder" });

            peopleComboBox.ItemsSource = people;

        }

        public void SubmitButtonClick(object sender , RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {fnametext.Text} {lnametext.Text}");

        }

    }
}
