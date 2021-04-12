using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstname, string lastname, double workHours, int payPerHour, Manager responsible)
            : base(firstname, lastname, Role.Contractor, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            double salary = WorkHours * PayPerHour;
            Salary = salary;
            return salary;
        }

        public string CurrentManager()
        {
            return Responsible.FullName;
        }
    }
}
