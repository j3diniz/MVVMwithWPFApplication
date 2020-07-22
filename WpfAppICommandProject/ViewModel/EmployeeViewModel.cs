using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMwithWPFProject.Model;

namespace MVVMwithWPFProject.ViewModel {
    public class EmployeeViewModel : INotifyPropertyChanged {

        private ObservableCollection<Employee> employees;
        /// <summary>
        /// Collection of employees
        /// </summary>
        public ObservableCollection<Employee> Employees {
            get { return employees; }
            set {
                employees = value;
                OnPropertyChanged("Employees");
            }
        }

        private Employee selectedEmployee;
        /// <summary>
        /// Selected employee from the collection of employees
        /// </summary>
        public Employee SelectedEmployee {
            get { return selectedEmployee; }
            set { 
                selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public EmployeeViewModel() {
            //SelectedEmployee = new Employee(1, "Joel", "Diniz", 5000, 20, true, 100f);
        }

        /// <summary>
        /// Default controctor to include employees to test
        /// </summary>
        public void DefaultEmployees() {
            employees = new ObservableCollection<Employee>(){
                new Employee(1, "Joel", "Diniz", 5000, 20, true, 100f),
                new Employee(2, "Edson", "Andrade", 10000, 10, true, 100f),
                new Employee(3, "Jade", "Diniz", 1000, 0, false, 100f)
            };
            this.Employees = employees;
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
