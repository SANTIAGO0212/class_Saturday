using EmployeOOP.Clases;
try
{
    int day, month, year, id;
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

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}