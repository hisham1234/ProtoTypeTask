namespace PharmacyAPI.Database
{
    public class UserService:IUser
    {
        private readonly IDbService _dbService;
       
        public UserService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<List<UserMaster>> GetAllUsers()
        {
            
            var employeeList = await _dbService.GetAll<UserMaster>("SELECT * FROM public.usermaster", new { });
            return employeeList;
        }

        public async Task<List<UserMaster>> GetAllUsers(string PharmacyCode,string UserId)
        {

            var employeeList = await _dbService.GetAll<UserMaster>("SELECT * FROM public.usermaster where 薬局コード=@PharmacyCode AND ユーザーid=@UserId AND 削除フラグ=false", new {PharmacyCode,UserId });
            return employeeList;
        }
    }
}
