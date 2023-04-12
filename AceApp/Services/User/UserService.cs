using AceApp.Data;
using AceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AceApp.Services
{
    public class UserService : IUserService
    {
        private readonly AceAppDBContext _context;

        public UserService(AceAppDBContext context)
        {
            _context = context;

        }
        public async Task AddEditUserDetail(UserDetailDto registerDto)
        {
            var user = _context.UserDetail.Where(x => x.UserId == registerDto.UserId).FirstOrDefault();
            if (user == null)
            {
                user = new UserDetail
                {
                    UserName = registerDto.Name,
                    UserId = registerDto.UserId,
                    CompanyName = registerDto.CompanyName,
                    Office = registerDto.Office,
                    UpdatedDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Email = registerDto.Email,
                    FaxNumber = registerDto.FaxNumber,
                    PhoneNumber = registerDto.PhoneNumber,
                    Extension = registerDto.Extension,
                    Avtar = "",
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    IsActive = true,
                    IsDelete = false
                };
                await _context.UserDetail.AddAsync(user);
            }
            else
            {
                user.UserName = registerDto.Name;
                user.Email = registerDto.Email;
                user.UpdatedDate = DateTime.Now;
                user.FaxNumber = registerDto.FaxNumber;
                user.PhoneNumber = registerDto.PhoneNumber;
                user.Extension = registerDto.Extension;
                user.CompanyName = registerDto.CompanyName;
                user.Office = registerDto.Office;
                _context.UserDetail.Update(user);
            }
            await _context.SaveChangesAsync();

        }

        public async Task<UserDetailDto> GetUserDetail(string id)
        {
            var user = _context.UserDetail
                .Where(o => o.UserId == id)
                .Include(u => u.User).ThenInclude(ur => ur.AspNetUserRoles).ThenInclude(r => r.Role)
                .Select(u => new UserDetailDto
                {
                    UserId = u.UserId,
                    CompanyName = u.CompanyName,
                    Office = u.Office,
                    Email = u.Email,
                    Extension = u.Extension,
                    FaxNumber = u.FaxNumber,
                    Name = u.FirstName + " " + u.LastName,
                    PhoneNumber = u.PhoneNumber,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Id = u.Id,
                    
                })
                .FirstOrDefault();
            return await Task.FromResult(user);
        }
        public void Dispose()
        {

        }
    }
}
