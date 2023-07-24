namespace asp.Application.Interface;

public interface IStudent
{
    IReadOnlyList<Student> GetAll();

    Student GetById(int id);

    string Add(Student student);

    string Delete(int id);

  
 
   Task UpdateBookAsyncEasy(Student studentx, int id);
}