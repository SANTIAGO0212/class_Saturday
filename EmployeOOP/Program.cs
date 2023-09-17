using EmployeOOP.Clases;
try
{
    int day, month, year, id, sales, bas, hours, hoursvalue;
    string firstName, lastName;
    decimal salary;
    Console.WriteLine("OOP APLICATION");
    Console.WriteLine("--------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización
    Date dateObject = new Date(day, month, year);
    Console.WriteLine(dateObject.ToString());

    Console.Write("Ingresar el id: ");
    id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar los nombres: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar los apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar el salario: ");
    salary = Decimal.Parse(Console.ReadLine());

    
    Console.Write("Cuanto fueron las ventas del empleado: ");
    sales = Convert.ToInt32(Console.ReadLine());

    Console.Write("Comision total: ");
    bas = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el total de horas devengadas: ");
    hours = Convert.ToInt32(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = id,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };
    Console.WriteLine(salaryEmployee);

    ComissionEmployee comissionEmployee = new ComissionEmployee()
    {
        Id = id,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
    };
    Console.WriteLine(comissionEmployee);

    BaseComissionEmployee basecomissionemployee = new BaseComissionEmployee()
    {
        Id = id,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
        Base = bas,
    };

    Console.WriteLine(basecomissionemployee);

    HourlyEmployee hoursEmployee = new HourlyEmployee()
    {
        Id = id,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Hours = hours,
        HoursValue = hours * 5000,
    };
    Console.WriteLine(hoursEmployee);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}