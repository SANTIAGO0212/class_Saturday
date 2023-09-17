namespace EmployeOOP.Clases
{
    public class HourlyEmployee : Employee
    {
        #region Properties
        public int Hours { get; set; }
        public int HoursValue { get; set; }
        #endregion Properties

        #region Methods

        public override decimal GetValueToPay()
        {
            HoursValue =( Hours * 5000);
            return HoursValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"El total de horas es de: {Hours}\n\t"+
                   $"El total acumulado es: {HoursValue} \n\t";
        }

        #endregion Methods
    }
}
