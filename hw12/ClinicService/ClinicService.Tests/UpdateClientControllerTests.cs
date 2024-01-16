using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ClinicService.Tests
{
    public class UpdateClientControllerTests
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _mockClientRepository;

        public UpdateClientControllerTests()
        {
            _mockClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_mockClientRepository.Object);
        }

        public static object[][] CorrectCreateClientData =
        [
            [1, new DateTime(1986, 1, 22), "AA1 B11222", "Иванов1", "Станислав1", "Андреевич1"],
            [2, new DateTime(1986, 1, 22), "AA1 B11222", "Иванов2", "Станислав2", "Андреевич2"],
            //new object[] 3,{ new DateTime(2013, 1, 22), "AA1 B11222", "Иванов3", "Станислав3", "Андреевич3" },
            //new object[] 4,{ new DateTime(2018, 1, 22), "AA1 B11222", "Иванов4", "Станислав4", "Андреевич4" },
            [5, new DateTime(1986, 1, 22), "AA1 B11222", "Иванов5", "Станислав5", "Андреевич5"],
            //new object[] 6,{ new DateTime(1986, 1, 22), "AA1 B11222", "Иванов", "", "Андреевич" },
            [7, new DateTime(1986, 1, 22), "AA1 B11222", "Иванов6", "Станислав6", "Андреевич6"],
            [8, new DateTime(1986, 1, 22), "AA1 B11222", "Иванов7", "Станислав7", "Андреевич7"],
            [9, new DateTime(1986, 1, 22), "AA1 B11222", "Иванов8", "Станислав8", "Андреевич8"],

        ];

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void UpdateClientTest(int ClientId, DateTime birthday, string document, string surName, string firstName, string patronymic)
        {
            // [1] Подготовка данных для тестирования

            var updateClientRequest = new UpdateClientRequest
            {
                Birthday = birthday,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic,
                ClientId = ClientId
            };

            var res = 1;

            _mockClientRepository
                .Setup(repository => repository.Update(It.IsNotNull<Client>()))
                .Returns(res);


            // [2] Исполнение тестируемого метода
            var operationResult = _clientController.Update(updateClientRequest);

            // [3] Подготовка эталонного результата и проверка результата
            Assert.IsType<OkObjectResult>(operationResult.Result);

            var result = (OkObjectResult)operationResult.Result;
            Assert.IsAssignableFrom<int>(result.Value);

            _mockClientRepository.Verify(repository =>
            repository.Update(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

    }
}
