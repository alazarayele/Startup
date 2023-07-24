namespace asp.Application.Applied;

public class CountryApplication : ICountry
{
    private readonly ICountryRepository _iCountryRepository;

    public CountryApplication(ICountryRepository iCountryRepository)
    {
        _iCountryRepository=iCountryRepository;
    }
    public string Add(Country country)
    {
        return _iCountryRepository.Add(country);
    }

    public string Delete(int id)
    {
        var country = GetById(id);
        return _iCountryRepository.Delete(country);
    }

    public IReadOnlyList<Country> GetAll()
    {
        return _iCountryRepository.GetAll();
    }

    public Country GetById(int id)
    {
        return _iCountryRepository.GetById(id);
    }

    public string Update(int id)
    {
        throw new NotImplementedException();
    }
}