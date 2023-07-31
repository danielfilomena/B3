using CDB.Application.DTOs;

namespace CDB.Application.Interfaces
{
    public interface ICalcularCDBService
    {
        Task<IEnumerable<RetornoCalculoDto>> CalcularCDB(CalculoCDBDto calculo);

    }
}
