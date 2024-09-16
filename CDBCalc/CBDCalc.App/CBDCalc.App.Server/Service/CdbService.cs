using CBDCalc.App.Server.Commands;
using CBDCalc.App.Server.Service;

public class CdbService : ICdbService
{
    private const decimal CDI = 0.009m;  // 0,9%
    private const decimal TB = 1.08m;    // 108%

    public CdbResponse CalcularCdb(decimal valorInicial, int prazoMeses)
    {
        decimal valorFinal = valorInicial;
        for (int i = 0; i < prazoMeses; i++)
        {
            valorFinal *= (1 + (CDI * TB));
        }

        decimal imposto = CalcularImposto(prazoMeses, valorFinal - valorInicial);
        decimal valorLiquido = valorFinal - imposto;

        return new CdbResponse
        {
            ValorBruto = valorFinal,
            ValorLiquido = valorLiquido
        };
    }

    private decimal CalcularImposto(int prazoMeses, decimal rendimento)
    {
        decimal aliquota = prazoMeses <= 6 ? 0.225m :
                           prazoMeses <= 12 ? 0.20m :
                           prazoMeses <= 24 ? 0.175m : 0.15m;

        return rendimento * aliquota;
    }
}

