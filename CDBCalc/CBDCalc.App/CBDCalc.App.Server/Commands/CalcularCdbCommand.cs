using MediatR;

namespace CBDCalc.App.Server.Commands
{
    public class CalcularCdbCommand : IRequest<CdbResponse>
    {
        public decimal ValorInicial { get; set; }
        public int PrazoMeses { get; set; }
    }

    public class CdbResponse
    {
        public decimal ValorBruto { get; set; }
        public decimal ValorLiquido { get; set; }
    }
}

