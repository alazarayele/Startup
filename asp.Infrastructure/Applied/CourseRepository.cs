namespace asp.Infrastructure.Applied;

public class CourseRepository : BaseRepository<Course>,ICourseRepository
{
    private readonly AspContext _aspContext;

    public CourseRepository(AspContext aspContext):base(aspContext)
    {
        _aspContext = aspContext;
    }

    public override  IReadOnlyList<Course> GetAll()
    {
        return _aspContext.Courses.Include(x=>x.Student).ToList();
    }
}