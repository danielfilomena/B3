using CDB.Domain.Entities;

namespace CDB.Application.DTOs
{
    public class RetornoCalculoDto
    {
        public decimal ValorInicial { get; set; }
        public int Prazo { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
        public Imposto? Imposto { get; set; }

    }
}
