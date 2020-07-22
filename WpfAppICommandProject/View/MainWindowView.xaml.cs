using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MVVMwithWPFProject.Model;
using MVVMwithWPFProject.ViewModel;

namespace MVVMwithWPFProject {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private EmployeeViewModel employeeViewModel;
        public MainWindow() {
            InitializeComponent();
            employeeViewModel = new EmployeeViewModel();
            // Adding itens just to test
            employeeViewModel.DefaultEmployees();
            grdEmployees.DataContext = employeeViewModel;
        }

        private void BtnTotalSalary_Click(object sender, RoutedEventArgs e) {
            // TODO: Implement ICommand here
        }
    }
}
