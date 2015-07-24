
using System.Web.Http;
using AutoMapper;
using Market.Domain.Entities;
using Market.Services.Services;
using Market.Web.Api.Models;

namespace Market.Web.Api.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("signup")]
        public IHttpActionResult Signup(UserViewModel userModel)
        {
           
                Mapper.CreateMap<UserViewModel, User>();
                var user = Mapper.Map<User>(userModel);
                user.UserName = userModel.Email;
                _userService.Create(user, userModel.Password, userModel.ConfirmPassword);
                return Ok();
            
        }
    }
}