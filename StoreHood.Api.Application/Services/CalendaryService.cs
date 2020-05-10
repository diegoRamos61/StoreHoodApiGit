using StoreHood.Api.Application.Contracts;
using StoreHood.Api.Business.Models;
using StoreHood.Api.DataAccess.Contracts.Repositories;
using StoreHood.Api.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Services
{
    public class CalendaryService : ICalendaryService
    {
        //Así accederíamos a métodos de otro servicio.
        private readonly ICalendaryRepository _calendaryRepository;

        public CalendaryService(ICalendaryRepository calendaryRepository)
        {
            _calendaryRepository = calendaryRepository;
        }

        public async Task<Calendary> GetCalendaryId(int id)
        {
            var entidad = CalendaryMapper.Map(await _calendaryRepository.GetById(id));

            return entidad;
        }

        public async Task<Calendary> AddCalendary(Calendary calendary)
        {
            var addedEntity = await _calendaryRepository.Add(CalendaryMapper.Map(calendary));

            return CalendaryMapper.Map(addedEntity);
        }

        public async Task<Calendary> UpdateCalendary(Calendary calendary)
        {
            //Convertimos el DTO a Entidad para que pueda ser actualizado.
            var updatedEntity = await _calendaryRepository.Update(CalendaryMapper.Map(calendary));
            //Mapeamos la entity devuelta del repository a DTO que será los objetos devueltos de negocio.
            return CalendaryMapper.Map(updatedEntity);
        }

        public async Task<bool> Delete(int id)
        {
            var deleted = await _calendaryRepository.DeleteAsync(id);

            return deleted;
        }

        public async Task<IEnumerable<Calendary>> GetAll()
        {
            var allCalendarys = await _calendaryRepository.GetAll();
            //Por cada item que contiene el listado lo mapea.
            return allCalendarys.Select(CalendaryMapper.Map);
        }

        public async Task<int> CountAll()
        {
            var countAll = await _calendaryRepository.CountAll();
            return countAll;
        }

    }
}
