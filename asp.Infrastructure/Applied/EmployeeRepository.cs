namespace asp.Infrastructure.Applied;


public class EmployeeRepository : BaseRepository<Employee>,IEmployeeRepository
{


private readonly AspContext _aspContext;

public EmployeeRepository(AspContext aspContext):base(aspContext)
{
    _aspContext=aspContext;
}

public override IReadOnlyList<Employee>GetAll()
{
    return _aspContext.Employees.Include(x=>x.EmployeeProjects).ToList();
}
}


