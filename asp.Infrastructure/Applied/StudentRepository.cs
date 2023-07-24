namespace asp.Infrastructure.Applied;
public class StudentRepository : BaseRepository<Student>,IStudentRepository
{
    private readonly AspContext _aspContext;
    public StudentRepository(AspContext aspContext):base(aspContext)
    {
        _aspContext=aspContext;
    }
    public override IReadOnlyList<Student> GetAll()
    {
        return _aspContext.Students.Include(x=>x.Courses).ToList();
    }

    
   
}