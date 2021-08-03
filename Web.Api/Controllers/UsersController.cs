using Domain.Contracts;
using Domain.Services.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Api.Helpers;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public async Task<Response<AuthenticateResponse>> Authenticate(AuthenticateRequest model)
        {
            Response<AuthenticateResponse> response = new Response<AuthenticateResponse>();

            try
            {
                response.Data = _userService.Authenticate(model);
            }
            catch (Exception ex)
            {
                response.Header.Code = 500;
                response.Header.Message = ex.Message;
            }

            return response;
        }

        [Authorize]
        [HttpPost("CreateUser")]
        public async Task<Response<bool>> CreateUser(UserRequest model)
        {
            Response<bool> response = new Response<bool>();

            try
            {
                response.Data = await _userService.Create(model);
            }
            catch (Exception ex)
            {
                response.Header.Code = 500;
                response.Header.Message = ex.Message;
            }

            return response;
        }

        [Authorize]
        [HttpPost("UpdateUser")]
        public async Task<Response<bool>> UpdateUser(UserRequest model)
        {
            Response<bool> response = new Response<bool>();

            try
            {
                response.Data = await _userService.Update(model);
            }
            catch (Exception ex)
            {
                response.Header.Code = 500;
                response.Header.Message = ex.Message;
            }

            return response;
        }

        [Authorize]
        [HttpGet("DeleteUser")]
        public async Task<Response<bool>> DeleteUser(string userId)
        {
            Response<bool> response = new Response<bool>();

            try
            {
                response.Data = await _userService.Delete(userId);
            }
            catch (Exception ex)
            {
                response.Header.Code = 500;
                response.Header.Message = ex.Message;
            }

            return response;
        }

        [Authorize]
        [HttpGet("getall")]
        public async Task<Response<List<UserResponse>>> GetAll()
        {
            Response<List<UserResponse>> response = new Response<List<UserResponse>>();
            try
            {
                response.Data = _userService.GetAll();
            }
            catch (Exception ex)
            {
                response.Header.Code = 500;
                response.Header.Message = ex.Message;
            }

            return response;
        }
    }
}