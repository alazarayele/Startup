namespace asp.Domain.Model;


public class EmployeeProject 
{
    public int EmployeeId{get;set;}
    public Employee Employee{get;set;}
    public int ProjectId{get;set;}
    public Project Project{get;set;}

    
}