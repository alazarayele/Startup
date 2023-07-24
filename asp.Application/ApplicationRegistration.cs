namespace asp.Application;


public static class ApplicationRegistration
{
    public static IServiceCollection AddApplicationRegistraion(this IServiceCollection iService)
    {
        iService.AddScoped<IStudent,StudentApplication>();
        iService.AddScoped<ICourse,CourseApplication>();
        iService.AddScoped<IProject,ProjectApplication>();
        iService.AddScoped<IEmployee,EmployeeApplication>();
        iService.AddScoped<ICountry,CountryApplication>();
        iService.AddScoped<ICapitalCity,CapitalCityApplication>();

        return iService;
    }
}