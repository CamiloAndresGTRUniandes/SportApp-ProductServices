namespace SportApp.ProductServices.Application.UnitTest.Tests ;
using Data;
using Moq;
using ProductsServices.Application.Activity.UseCases;
using ProductsServices.Domain.Activities.Commands;
using ProductsServices.Domain.Activities.Repositories;

    public class CreateActivityUseCaseTest
    {
        private readonly Mock<IActivityRepository> _activityRepositoryMock;
        private readonly CreateActivityUseCase _createActivityUseCase;

        public CreateActivityUseCaseTest()
        {
            _activityRepositoryMock = new Mock<IActivityRepository>();
            _createActivityUseCase = new CreateActivityUseCase(_activityRepositoryMock.Object);
        }

        [Fact]
        public async Task CreateActivitySuccessFull()
        {
            //Arrange
            var activity = ActivityMother.Create();
            var request = new CreateActivityCommand
            {
                Id = Guid.Parse("7300e12e-f3df-4a8b-9847-45f07362cee9"),
                Name = "New Goal",
                User = Guid.Parse("6ad77258-01bf-4d2b-b8ee-37e2099e0216")
            };

            _activityRepositoryMock.Setup(x => x.SaveAndPublishAsync(activity));

            //Act
            var response = await _createActivityUseCase.ExecuteAsync(request);

            //Assert
            Assert.Equal(request.Id, response.Id);
            Assert.Equal(request.Name, response.Name);
            Assert.Equal(request.User, response.CreatedBy);
        }
    }
