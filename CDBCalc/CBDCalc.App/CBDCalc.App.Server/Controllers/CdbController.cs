using MediatR;
using Microsoft.AspNetCore.Mvc;
using CBDCalc.App.Server.Commands;

namespace CBDCalc.App.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CdbController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CdbController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("calcular")]
        public async Task<IActionResult> Calcular([FromBody] CalcularCdbCommand command)
        {
            var resultado = await _mediator.Send(command);
            return Ok(resultado);
        }
    }
}
