using Domain.Contracts;
using Infraestructure.Model.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.Users
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Task<bool> Create(UserRequest userRequest);
        Task<bool> Delete(string userId);
        List<UserResponse> GetAll();
        User GetById(int userId);
        Task<bool> Update(UserRequest userRequest);
    }
}
