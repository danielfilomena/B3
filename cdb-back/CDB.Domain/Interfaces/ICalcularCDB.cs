using CDB.Domain.Entities;

namespace CDB.Domain.Interfaces
{
    public interface ICalcularCDB
    {

        Task<IEnumerable<RetornoCalculo>> CalcularCDB(Calculo calculo);
              
    }
}
