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

namespace DbSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdventureWorksEntities _context;
        public MainWindow()
        {
            InitializeComponent();

            _context = new AdventureWorksEntities();
            var departments = _context.Department.Where(x => x.DepartmentID > 0).ToList();

            this.DataContext = departments;

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
        }
    }
}
