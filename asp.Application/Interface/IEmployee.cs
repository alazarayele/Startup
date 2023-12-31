namespace asp.Application.Interface;
public interface IEmployee
{
    IReadOnlyList<Employee> GetAll();

    Employee GetById(int id);

    string Add(Employee employee);

    string Delete(int id);

    string Update(Employee employee);
}