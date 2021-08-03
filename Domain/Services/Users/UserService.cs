using AutoMapper;
using Domain.Contracts;
using Infraestructure.Model.Constants;
using Infraestructure.Model.Interfaces;
using Infraestructure.Model.Model;
using Infraestructure.Repository.Helpers;
using Infraestructure.Repository.Repositories.Users;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Users
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings,
            IUserRepository userRepository,
            IMapperDependency mapperDependency)
        {
            _appSettings = appSettings.Value;
            _userRepository = userRepository;
            _mapper = mapperDependency.GetMapper();
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            User user = _userRepository.Autenticate(model.Username, model.Password);
            if (user == null)
            {
                throw new Exception("Username or password is incorrect");
            }
             
            string token = GenerateJwtToken(user);
            return new AuthenticateResponse(user, token);
        }

        public List<UserResponse> GetAll()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<List<UserResponse>>(users);
        }

        // helper methods

        private string GenerateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(AdminConstant.UserId, user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public User GetById(int userId)
        {
            return _userRepository.GetById(userId);
        }

        public async Task<bool> Create(UserRequest userRequest)
        {
            if (string.IsNullOrEmpty(userRequest.Username))
            {
                throw new Exception("The UserName is Required");
            }

            if (string.IsNullOrEmpty(userRequest.Password))
            {
                throw new Exception("The Password is Required");
            }

            if (userRequest.RolId == 0)
            {
                throw new Exception("The Rol is Required");
            }

            User user = _mapper.Map<User>(userRequest);

            await _userRepository.CreateAsync(user);

            return true;
        }

        public async Task<bool> Update(UserRequest userRequest)
        {
            if (string.IsNullOrEmpty(userRequest.Id))
            {
                throw new Exception("The UserId is Required");
            }

            if (string.IsNullOrEmpty(userRequest.Username))
            {
                throw new Exception("The UserName is Required");
            }

            if (string.IsNullOrEmpty(userRequest.Password))
            {
                throw new Exception("The Password is Required");
            }

            if (userRequest.RolId == 0)
            {
                throw new Exception("The Rol is Required");
            }

            User user = _mapper.Map<User>(userRequest);

            await _userRepository.UpdateAsync(user);

            return true;
        }

        public async Task<bool> Delete(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("The UserId is Required");
            }

            User user = GetById(int.Parse(userId));

            await _userRepository.DeleteAsync(user);

            return true;
        }
    }
}
