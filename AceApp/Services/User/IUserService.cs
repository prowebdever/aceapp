using AceApp.Data;

namespace AceApp.Services
{
    public interface IUserService : IDisposable
    {
        Task AddEditUserDetail(UserDetailDto registerDto);
        Task<UserDetailDto> GetUserDetail(string id);
    }
}
