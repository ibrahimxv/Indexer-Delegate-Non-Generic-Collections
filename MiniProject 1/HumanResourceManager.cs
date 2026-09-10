namespace HRManagementApp;

internal class HumanResourceManager
{
    public List<Department> Departments { get; } = new List<Department>();

    public void AddDepartment(string name, int workerLimit, int salaryLimit, Employee[] employees)
    {
        Department department = new Department(name, workerLimit, salaryLimit, employees);
        Departments.Add (department);
    }
    public List <Department> GetDepartments()
    {
        return Departments;
    }
    public void EditDepartment (string oldName, string newName)
    {
        for (int i = 0; i < Departments.Count; i++)
        {
            if (Departments[i].Name == oldName)
            {
                Departments[i].Name = newName;
                return;
            }
        }
    }
    public void AddEmployee (string? fullName, string position, double salary, string no, string departmentName)
    {
        Employee employee = new Employee(fullName, position, salary, no, departmentName);

        for (int i = 0;i < Departments.Count;i++)
        {
            if (Departments[i].Name == departmentName)
            {
                for (int j = 0; j < Departments.Count; j++)
                {
                    if (Departments[i].Employees[j] == null)
                    {
                        Departments[i].Employees[j] = employee;
                        return;
                    }
                }
            }
        }
    }
    public void RemoveEmployee (string no, string departmentName)
    {
        for (int i = 0; i < Departments.Count; i++)
        {
            if (Departments[i].Name == departmentName)
            {
                for (int j = 0;j < Departments.Count;j++)
                {
                    if (Departments[i].Employees[j] != null &&
                        Departments[i].Employees[j].No == no)
                    {
                        Departments[i].Employees[j] = null;
                        return;
                    }
                }
            }
        }
    }
    public void EditEmployee(string no, double salary, string position)
    {
        for (int i = 0; i < Departments.Count; i++)
        {
            for (int j = 0; i < Departments.Count; i++)
            {
                if (Departments[i].Employees[j] != null &&
                    Departments[i].Employees[j].No == no)
                {
                    Departments[i].Employees[j].Salary = salary;
                    Departments[i].Employees[j].Position = position;
                    return;
                }
            }
        }
    }
    

    // search??
}
