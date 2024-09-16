using CBDCalc.App.Server.Commands;
using CBDCalc.App.Server.Service;
using MediatR;

namespace CBDCalc.App.Server.Handler
{
    public class CalcularCdbCommandHandler : IRequestHandler<CalcularCdbCommand, CdbResponse>
    {
        private readonly ICdbService _cdbService;

        public CalcularCdbCommandHandler(ICdbService cdbService)
        {
            _cdbService = cdbService;
        }

        public Task<CdbResponse> Handle(CalcularCdbCommand request, CancellationToken cancellationToken)
        {
            var resultado = _cdbService.CalcularCdb(request.ValorInicial, request.PrazoMeses);
            return Task.FromResult(resultado);
        }
    }
}

