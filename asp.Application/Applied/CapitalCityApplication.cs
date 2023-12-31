namespace asp.Application.Applied;

public class CapitalCityApplication : ICapitalCity
{
    private readonly ICity _iCity;

    public CapitalCityApplication(ICity iCity)
    {
        _iCity=iCity;
    }
    public string Add(CapitalCity capitalCity)
    {
        return _iCity.Add(capitalCity);
    }

    public string Delete(int id)
    {
       var capital = GetById(id);
       return _iCity.Delete(capital);
    }

    public IReadOnlyList<CapitalCity> GetAll()
    {
        return _iCity.GetAll();
    }

    public CapitalCity GetById(int id)
    {
        return _iCity.GetById(id);
    }

    public string Update(int id)
    {
        throw new NotImplementedException();
    }
}