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
using System.Windows.Shapes;

namespace List
{
    /// <summary>
    /// Interakční logika pro ListEdit.xaml
    /// </summary>
    public partial class ListEdit : Window
    {
        bool IsUpdating { get; set; }

        public ListEdit()
        {
            InitializeComponent();
            DataContext = new Person();
            IsUpdating = false;
        }

        public ListEdit(Person p)
        {
            InitializeComponent();
            DataContext = p;
            IsUpdating = true;
        } 

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsUpdating == false)
            {
                Person.People.Add((Person)DataContext);
            }
            this.Close();
        }
    }
}
