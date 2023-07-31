using AutoMapper;
using CDB.Application.DTOs;
using CDB.Application.Interfaces;
using CDB.Domain.Entities;
using CDB.Domain.Interfaces;

namespace CDB.Application.Services
{
    public class CalcularService : ICalcularCDBService
    {

        private ICalcularCDB _calcularCDB;
        private IMapper _mapper;

        public CalcularService(ICalcularCDB calcularCDB, IMapper mapper)
        {
            
            _calcularCDB = calcularCDB;
            _mapper = mapper;

        }

        public async Task<IEnumerable<RetornoCalculoDto>> CalcularCDB(CalculoCDBDto calculo)
        {

            var calculos = _mapper.Map<Calculo>(calculo);
            var resultado = await _calcularCDB.CalcularCDB(calculos);

            return _mapper.Map<IEnumerable<RetornoCalculoDto>>(resultado);

        }
       
    }
}
