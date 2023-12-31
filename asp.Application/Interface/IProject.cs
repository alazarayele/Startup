namespace asp.Application.Interface;
public interface IProject
{
    IReadOnlyList<Project> GetAll();

    Project GetById(int id);

    string Add(Project project);

    string Delete(int id);

    string Update(Project project);
}