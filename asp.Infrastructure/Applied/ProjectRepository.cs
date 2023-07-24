namespace asp.Infrastructure.Applied;

public class ProjectRepository : BaseRepository<Project>,IProjectRepository
{
   
private readonly AspContext _aspContex;
   public ProjectRepository(AspContext aspContext):base(aspContext)
   {
        _aspContex=aspContext;
   }
}
