using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ClinicService.Tests
{
    public class DeleteClientControllerTests
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _mockClientRepository;

        public DeleteClientControllerTests()
        {
            _mockClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_mockClientRepository.Object);
        }

        public static object[][] CorrectCreateClientData = [[1], [2], [3], [4], [5]];

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void DeleteClientTest(int ClientId)
        {
            // [1] Подготовка данных для тестирования

            var res = 1;

            _mockClientRepository
                .Setup(repository => repository.Delete(It.IsAny<int>()))
                .Returns(res);

            // [2] Исполнение тестируемого метода
            var operationResult = _clientController.Delete(ClientId);

            // [3] Подготовка эталонного результата и проверка результата
            Assert.IsType<OkObjectResult>(operationResult.Result);

            var result = (OkObjectResult)operationResult.Result;
            Assert.IsAssignableFrom<int>(result.Value);

            _mockClientRepository.Verify(repository => repository.Delete(It.IsAny<int>()), Times.AtLeastOnce());
        }

    }
}
