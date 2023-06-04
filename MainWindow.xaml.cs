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

namespace CSV_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Person> persons = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
            Preload();

        }

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Preload()
        {
            persons.Add(new Person("Will", "Cram", "Professor"));
            persons.Add(new Person("Josh", "Emery", "Professor"));
        }

    }
}
