using StoreHood.Api.Application.Contracts;
using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Repositories;
using StoreHood.Api.DataAccess.Mappers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreHood.Api.Application
{
    public class UserService : IUserService
    {
        /*
         * En los diferentes métodos nos llegará los objetos DTO, los mapearemos a entidades para poder 
         * realizar las actualizaciones en la capa de DataLayers y lo devuelto lo volvemos a convertir a DTO.         
         */

        //Readonly porque así se incializa con el constructor y no más.
        private readonly IUserRepository _userRepository;
        
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserId(int id)
        {
            var entidad = UserMapper.Map(await _userRepository.GetById(id));

            return entidad;
        }

        public async Task<User> AddUser(User user)
        {
            var addedEntity = await _userRepository.Add(UserMapper.Map(user));

            return UserMapper.Map(addedEntity);
        }

        public async Task<User> UpdateUser(User user)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _userRepository.Update(UserMapper.Map(user));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return UserMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _userRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<User>> GetAll()
        {            
            var allUsers =  await _userRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allUsers.Select(UserMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _userRepository.CountAll();
            return countAll;
        }

    }
}
