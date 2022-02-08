using System;


namespace EmployeeDetails
{
    class Employee
    {

        public string firstName;
        public string lastName;
        public double monthlySalary;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public double MonthlySalary
        {
            get => monthlySalary;
            set
            {
                if ((int)value < 0)
                    value = 0.0;

                monthlySalary = value;
            }
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.monthlySalary = monthlySalary;
        }

        public override string ToString()
        {
            return "NAME: " + firstName + " " + lastName + " , SALARY: " + monthlySalary;
        }

        public virtual void getRaise(double raise)
        {
            monthlySalary += monthlySalary * (raise / 100);
        }
    }

    class PermanentEmployee : Employee
    {

        private double _hra;
        private double _da;
        private double _pf;

        string _joiningDate;
        string _retirementDate;

        public PermanentEmployee(string first, string last, double salary, string joiningDate, string retirementDate) : base(first, last, salary)
        {
            _da = base.monthlySalary * 0.12;
            _hra = (_da + base.monthlySalary) * 0.5;
            _pf = base.monthlySalary * 0.12;
            _joiningDate = joiningDate;
            _retirementDate = retirementDate;
        }

        public double HRA
        {
            get => _hra;
        }

        public double DA
        {
            get => _da;
        }

        public double PF
        {
            get => _pf;
        }

        public override void getRaise(double raise)
        {
            base.getRaise(raise);
            monthlySalary += _hra + _da;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nJoining date: {_joiningDate}\nRetirement date:{_retirementDate}";
        }

    }

}