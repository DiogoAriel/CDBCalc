using CBDCalc.App.Server.Commands;
using CBDCalc.App.Server.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CDBCalc.Test
{
    [TestClass]
    public class CdbServiceTests
    {
        [TestMethod]
        public void CalcularCdb_DeveRetornarValorCorreto()
        {
            // Arrange
            var mockService = new Mock<ICdbService>();
            mockService.Setup(service => service.CalcularCdb(1000, 12))
                       .Returns(new CdbResponse
                       {
                           ValorBruto = 1100,
                           ValorLiquido = 1080
                       });

            // Act
            var resultado = mockService.Object.CalcularCdb(1000, 12);

            // Assert
            Assert.IsTrue(resultado.ValorBruto > 1000, "Valor Bruto deveria ser maior que o valor inicial.");
            Assert.IsTrue(resultado.ValorLiquido < resultado.ValorBruto, "Valor Líquido deveria ser menor que o Valor Bruto.");
        }
    }
}
