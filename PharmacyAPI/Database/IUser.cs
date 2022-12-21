namespace PharmacyAPI.Database
{
    public interface IUser
    {
        Task<List<UserMaster>> GetAllUsers();

        Task<List<UserMaster>> GetAllUsers(string PharmacyCode, string UserId);
    }
}
