namespace HRManagementApp;

internal interface IHumanResourceManager
{
    public List<Department> Departments { get; }
    public List<Department> GetDepartments { get; }
}
