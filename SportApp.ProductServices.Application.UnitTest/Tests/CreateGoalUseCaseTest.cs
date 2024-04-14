namespace SportApp.ProductServices.Application.UnitTest.Tests ;
using Data;
using Moq;
using ProductsServices.Application.Goal.UseCases;
using ProductsServices.Domain.Goals.Commands;
using ProductsServices.Domain.Goals.Repositories;

    public class CreateGoalUseCaseTest
    {
        private readonly CreateGoalUseCase _createGoalUseCase;
        private readonly Mock<IGoalRepository> _repositoryMock;

        public CreateGoalUseCaseTest()
        {
            _repositoryMock = new Mock<IGoalRepository>();
            _createGoalUseCase = new CreateGoalUseCase(_repositoryMock.Object);
        }

        [Fact]
        public async Task CreateGoalSuccessFull()
        {
            //Arrange
            var goal = GoalMother.Create();
            var request = new CreateGoalCommand
            {
                Id = Guid.Parse("7300e12e-f3df-4a8b-9847-45f07362cee9"),
                Name = "New Goal",
                User = Guid.Parse("6ad77258-01bf-4d2b-b8ee-37e2099e0216")
            };
            _repositoryMock.Setup(x => x.SaveAndPublishAsync(goal));

            //Act
            var response = await _createGoalUseCase.ExecuteAsync(request);

            //Assert
            Assert.Equal(request.Id, response.Id);
            Assert.Equal(request.Name, response.Name);
            Assert.Equal(request.User, response.CreatedBy);
        }
    }
