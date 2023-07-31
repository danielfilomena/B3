using CDB.Domain.Entities;
using CDB.Domain.Interfaces;

namespace CDB.Data.Repositories
{
    public class CalcularCDBRepository : ICalcularCDB
    {
        public async Task<IEnumerable<RetornoCalculo>> CalcularCDB(Calculo calculo)
        {

            List<RetornoCalculo> retornoCalculos = new List<RetornoCalculo>();

            var valorInicial = calculo.Valor;

            for (int i = 0; i < calculo.Prazo; i++)
            {

                var valorFinal = Math.Round(valorInicial * (i + 1 + (Base.CDI * Base.TB / 100)) / 100, 2);

                retornoCalculos.Add(new RetornoCalculo
                {
                    ValorInicial = Math.Round(valorInicial, 2),
                    Prazo = i + 1,
                    ValorBruto = valorInicial + valorFinal,
                    Imposto = CalcularImposto( (valorInicial + valorFinal), i + 1),
                    ValorLiquido = CalcularValorLiquido((valorInicial + valorFinal), i + 1)

                });

                valorInicial = valorInicial + valorFinal;
                                   
            }

            return retornoCalculos;
                    
        }

        private decimal CalcularValorLiquido(decimal valor, int quantidade)
        {

            var valorImposto = CalcularImposto(valor, quantidade);

            return valor - valorImposto.ValorImposto;


        }

        private Imposto CalcularImposto(decimal valor, int qtd)
        {

            Imposto imposto = new Imposto();

            if (qtd <= 6) 
            {

                imposto.PercentualImposto = 22.5M;
                imposto.ValorImposto = Math.Round(valor * imposto.PercentualImposto / 100, 2);

            }
            else if (qtd > 6 && qtd <= 12)
            {
                imposto.PercentualImposto = 20M;
                imposto.ValorImposto = Math.Round(valor * imposto.PercentualImposto / 100, 2);
            }
            else if (qtd > 12 && qtd <= 24)
            {
                imposto.PercentualImposto = 17.5M;
                imposto.ValorImposto = Math.Round(valor * imposto.PercentualImposto / 100, 2);
            }
            else
            {
                imposto.PercentualImposto = 15;
                imposto.ValorImposto = Math.Round(valor * imposto.PercentualImposto / 100, 2);
            }

            return imposto;

        }

    }
}
