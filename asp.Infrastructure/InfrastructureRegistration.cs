namespace asp.Infrastructure;

public static class InfrastructureRegistration
{
    public static IServiceCollection AddInfrastructureRegistration(this IServiceCollection iService,IConfiguration iConfig)
    {
        var conn = iConfig.GetConnectionString("DataBaseConnection");
        iService.AddDbContext<AspContext>(dbcontext => {
            dbcontext.UseMySql(conn,ServerVersion.AutoDetect(conn));
        });
        iService.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        iService.AddScoped<IStudentRepository,StudentRepository>();
        iService.AddScoped<ICourseRepository,CourseRepository>();
        iService.AddScoped<IProjectRepository,ProjectRepository>();
        iService.AddScoped<IEmployeeRepository,EmployeeRepository>();
        iService.AddScoped<ICountryRepository,CountryRepository>();
        iService.AddScoped<ICity,CityRepository>();

        return iService;
    }   
} 