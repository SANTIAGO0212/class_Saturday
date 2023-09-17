namespace EmployeOOP.Clases
{
    public class SalaryEmployee : Employee
    {
        #region Properties

        public decimal Salary { get; set; }

        #endregion Properties

        #region Methods
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Salario Devengado: {Salary:C2}\n\t";

        }
        #endregion Methods
    }
}
