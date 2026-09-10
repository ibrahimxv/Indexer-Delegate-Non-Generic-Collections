namespace HRManagementApp;

internal class Department
{
    public Department(string name, int workerLimit, int salaryLimit, Employee[] employees)
    {
        Name = name;
        WorkerLimit = workerLimit;
        SalaryLimit = salaryLimit;
        Employees = employees;
    }

    public string Name 
    { 
        get { return field; }

        set
        {
            if (value.Length < 2)
            {
                Console.WriteLine("Name must consist of at least 2 letters !");
                return;
            }
            field = value;
        }
    }
    public int WorkerLimit 
    { 
        get { return field; }

        set
        {
            if (value < 1)
            {
                Console.WriteLine("Worker limit can be at least 1 !");
                return;
            }

            field = value; 
        }
        
    }
    public int SalaryLimit 
    { 
        get { return field; }

        set
        {
            if (value < 250)
            {
                Console.WriteLine("Salary limit can be at least 250 !");
                return;
            }
            field = value;
        }
    }
    public Employee[] Employees { get; }

    public double CalcSalaryAverage()
    {
        double totalSalary = 0;

        for (int i = 0; i < Employees.Length; i++)
        {
            totalSalary += Employees[i].Salary;
        }

        return totalSalary / Employees.Length;
    }
   
}
