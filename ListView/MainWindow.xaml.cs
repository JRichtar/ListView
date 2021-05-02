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

namespace List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person.PeopleList();
            Person p = new Person();
            DataContext = p;
        }

        private void People_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person pi = (Person)((sender as ListView).SelectedItem);
            DataContext = pi;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            People.SelectedItem = 0;
        }

        private void People_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Person pi = (Person)((sender as ListView).SelectedItem);
            ListEdit le = new ListEdit(pi);
            le.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ListEdit le = new ListEdit();
            le.ShowDialog();
        }
    }
}
