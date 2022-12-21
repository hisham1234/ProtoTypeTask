namespace PharmacyAPI.Database
{
    public interface IDbService
    {
        Task<List<T>> GetAll<T>(string command, object parms);
    }
}
