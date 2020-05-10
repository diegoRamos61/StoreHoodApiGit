using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreHood.Api.Application.Contracts;
using StoreHood.Api.Business.Models;
using StoreHood.Api.Mappers;
using StoreHood.Api.ViewModels;

namespace StoreHood.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        //Podemos inyectar los servicios que queramos por controlador.
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
    
        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json",Type= typeof(UserModel))]
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody]UserModel user)
        {
            //Para invocar a los metodos de negocio se tiene que transformar a DTO.
            var userAddDto = await _userService.AddUser(UserMapper.Map(user));
            //Pero la salida devolvemos el modelo.            
            return Ok(UserMapper.Map(userAddDto));
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var isDeleted = await _userService.Delete(id);

            return Ok(isDeleted);            
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(UserModel))]
        public async Task<IActionResult> UpdateUser([FromBody]UserModel user)
        {
            var userUpdDto = await _userService.UpdateUser(UserMapper.Map(user));

            return Ok(UserMapper.Map(userUpdDto));

        }

        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<UserModel>))]
        public async Task<IActionResult> GetUserAll()
        {
            var users = await _userService.GetAll();
            
            return Ok(users.Select(UserMapper.Map));
        }

        /// <summary>
        /// Get USER by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User</returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(UserModel))]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetUserId(id);
            
            return Ok(UserMapper.Map(user));
        }

    }
}