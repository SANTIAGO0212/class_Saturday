using EmployeOOP.Clases;
try
{


    Console.WriteLine("OOP APLICATION");
    Console.WriteLine("--------------");

    Console.Write("Ingresar el día");
    int day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes");
    int month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año");
    int year = Convert.ToInt32(Console.ReadLine());

    //Inicialización
    Date dateObject = new Date(day, month, year);
    Console.WriteLine(dateObject.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}