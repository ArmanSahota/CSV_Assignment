using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
        const string filepath = "professors.csv";
        public MainWindow()
        {
            InitializeComponent();
            //Preload();
            persons = LoadCSV<Person>(filepath);
            lvDisplay.ItemsSource = persons;

        } // MainWindow()

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string job = txtJob.Text;

            persons.Add(new Person(fName, lName, job));

            lvDisplay.Items.Refresh();

        } // benAddPerson_Click

        public void SaveData<T>(string filepath, List<T> list)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            

            using (var stream = File.Open(filepath, FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(stream))
            using (var csvWriter = new CsvWriter(writer, ci))
            {
                // .WriteRecords(list);
                csvWriter.WriteRecords(list);
                writer.Flush();
            }
        }

        public List<T> LoadCSV<T>(string filepath) {

            List<T> temp = new List<T>();

            using (StreamReader sr = new StreamReader(filepath))
            using (CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture))
            {

                temp = csv.GetRecords<T>().ToList();
            }
            return temp;
        }

        public void Preload()
        {
            persons.Add(new Person("Will", "Cram", "Professor"));
            persons.Add(new Person("Josh", "Emery", "Professor"));
            persons.Add(new Person("Sarah", "Hoaglin", "Behavioral Health Specialist"));

            SaveData(filepath, persons);
        } // Preload()

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveData(filepath, persons);

        }
    } // class
} // namespace
