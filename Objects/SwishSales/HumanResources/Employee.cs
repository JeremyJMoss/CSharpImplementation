namespace SwishSales.HumanResources
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _payRate;

        public Employee(string first, string last, double pay)
        {
            _firstName = first;
            _lastName = last;
            _payRate = pay;
        }

        public void SetFirstName(string newFirstName)
        {
            _firstName = newFirstName;
        }

        public void SetLastName(string newLastName)
        {
            _lastName = newLastName;
        }

        public void SetPayRate(double newPayRate)
        {
            _payRate = newPayRate;
        }
        public double GetPay()
        {
            return _payRate * 38;
        }

        public double GetPay(double bonus)
        {
            return _payRate * 38 + bonus;
        }
        public string GetFullName()
        {
            
            return $"{_firstName} {_lastName}";
        }

        public void SetFullName(string fullName)
        {
            string[] names = fullName.Split(" ");
            _firstName = names[0];
            _lastName = names[1];
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }
    }
}