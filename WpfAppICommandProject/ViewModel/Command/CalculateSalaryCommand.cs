using MVVMwithWPFProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;

namespace WpfAppICommandProject.ViewModel.Command {
    public class CalculateSalaryCommand : ICommand {

        public EmployeeViewModel EmployeeViewModel { get; set; }

        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public CalculateSalaryCommand(EmployeeViewModel employeeViewModel) {
            EmployeeViewModel = employeeViewModel;
        }

        public bool CanExecute(object parameter) {
            string selectedEmployeeName = parameter as string;

            if (string.IsNullOrWhiteSpace(selectedEmployeeName))
                return false;
            return true;
        }

        public void Execute(object parameter) {
            this.EmployeeViewModel.CalculateSalary();
        }
    }
}
