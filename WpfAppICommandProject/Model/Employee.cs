using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMwithWPFProject.Model {
    public class Employee {

        private int iD;
        /// <summary>
        /// Identification number of the employee
        /// </summary>
        public int ID {
            get { return iD; }
            set { iD = value; }
        }


        private string firstName;
        /// <summary>
        /// First name of the employee
        /// </summary>
        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        /// <summary>
        /// Last name of the employee
        /// </summary>
        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }

        private double baseSalary;
        /// <summary>
        /// Base monthly salary of the employee. Minimal to be received
        /// </summary>
        public double BaseSalary {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        private int daysWorked;
        /// <summary>
        /// Days worked in current month
        /// </summary>
        public int DaysWorked {
            get { return daysWorked; }
            set { daysWorked = value; }
        }

        private bool receiveBonusPerDayWorked;
        /// <summary>
        /// Receive bonus per day worked?
        /// </summary>
        public bool ReceiveBonusPerDayWorked {
            get { return receiveBonusPerDayWorked; }
            set { receiveBonusPerDayWorked = value; }
        }


        private double bonusPerDayWorked;
        /// <summary>
        /// Bonus per day worked so (Total Salary) = (Days Worked) * (Bonus per Day Worked) + (Base Salary)
        /// </summary>
        public double BonusPerDayWorked {
            get { return bonusPerDayWorked; }
            set { bonusPerDayWorked = value; }
        }

        public Employee() {
        }

        public Employee(int iD, string firstName, string lastName, double baseSalary, int daysWorked, bool receiveBonusPerDayWorked, double bonusPerDayWorked) {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            BaseSalary = baseSalary;
            DaysWorked = daysWorked;
            ReceiveBonusPerDayWorked = receiveBonusPerDayWorked;
            BonusPerDayWorked = bonusPerDayWorked;
        }
    }
}
