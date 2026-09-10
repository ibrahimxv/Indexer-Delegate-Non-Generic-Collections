namespace HRManagementApp;

internal class Employee
{
    public string? FullName { get; set; }
    public string Position
    {
        get { return field; }

        set
        {
            if (value.Length < 2)
            {
                Console.WriteLine("Position must be 2 letters!");
                return;
            }
            field = value;
        }
    }
    public double Salary 
    { 
        get { return field; }

        set
        {
            if (value < 250)
            {
                Console.WriteLine("Salary can't be lower than 250.");
                return;
            }    
            field = value;
        }
    }
    public string DepartmentName { get; set; }
    public string No { get; set; }
    private static int Num = 1000;
    public Employee(string departmentName)
    {
        Num++;
        DepartmentName = departmentName;
        No = departmentName.Substring(0, 2).ToUpper() + Num;
    }

    public Employee(string? fullName, string position, double salary, string no, string departmentName)
    {
        FullName = fullName;
        Position = position;
        Salary = salary;
        No = no;
        DepartmentName = departmentName;
    }
}
