using CBDCalc.App.Server.Commands;

namespace CBDCalc.App.Server.Service
{
    public interface ICdbService
    {
        CdbResponse CalcularCdb(decimal valorInicial, int prazoMeses);
    }
}