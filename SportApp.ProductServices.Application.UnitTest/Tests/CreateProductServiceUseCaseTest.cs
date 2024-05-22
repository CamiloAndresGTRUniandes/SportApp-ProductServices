namespace SportApp.ProductsServices.Application.Tests ;
using Domain.Activities.Repositories;
using Domain.Allergies.Repositories;
using Domain.Common.Enums;
using Domain.Goals.Repositories;
using Domain.Nutrition.Repositories;
using Domain.ProductService.Commands;
using Domain.ProductService.Repositories;
using Domain.ProductService.ValueObjects;
using Domain.Training.Repositories;
using Moq;
using ProductService.UseCases;
using ProductServices.Application.UnitTest.Data;
using ProductService = Domain.ProductService.ProductService;

    public class CreateProductServiceUseCaseTests
    {
        private readonly Mock<IActivityRepository> _activityRepositoryMock = new();
        private readonly Mock<IGoalRepository> _goalRepositoryMock = new();
        private readonly Mock<INutritionalAllergyRepository> _nutritionalAllergyRepositoryMock = new();
        private readonly Mock<INutritionalPlanRepository> _nutritionalPlanRepositoryMock = new();
        private readonly Mock<IPlanRepository> _planRepositoryMock = new();
        private readonly Mock<IProductServiceRepository> _productServiceRepositoryMock = new();
        private readonly Mock<IServiceTypeRepository> _serviceTypeRepositoryMock = new();
        private readonly Mock<ITrainingPlanRepository> _trainingPlanRepositoryMock = new();
        private readonly Mock<ITypeOfNutritionRepository> _typeOfNutritionRepositoryMock = new();

        [Fact]
        public async Task ExecuteAsync_ShouldCreateNewProductService_WhenProductServiceDoesNotExist()
        {
            // Arrange
            var useCase = new CreateProductServiceUseCase(
                _productServiceRepositoryMock.Object,
                _planRepositoryMock.Object,
                _typeOfNutritionRepositoryMock.Object,
                _serviceTypeRepositoryMock.Object,
                _goalRepositoryMock.Object,
                _activityRepositoryMock.Object,
                _nutritionalAllergyRepositoryMock.Object,
                _nutritionalPlanRepositoryMock.Object,
                _trainingPlanRepositoryMock.Object
                );
            var serviceType = ServiceTypeMother.Create();
            var goal = GoalMother.Create();
            var request = new CreateProductServiceCommand
            {
                Id = Guid.Parse("39be2ca5-866c-4540-ae6d-423d36ff36b5"),
                Name = "Test Product",
                Description = "Test Description",
                Price = new Price(100),
                Picture = new Uri("http://test.com/image.png"),
                CountryId = Guid.Parse("dcdf29bc-9009-47d8-9f96-85286ffef7f9"),
                StateId = Guid.Parse("1576ecdf-5f4e-4289-830a-8930334bd683"),
                CityId = Guid.Parse("847fca12-b453-462b-83f8-2c6d8687bc87"),
                ServiceTypeId = serviceType.Id,
                SportLevel = SportLevel.Basico,
                User = Guid.Parse("4ec72f62-ee2f-4f63-bfad-f9ef5c1c4058"),
                StartDateTime = DateTime.UtcNow,
                EndDateTime = DateTime.UtcNow.AddDays(30)
            };

            _productServiceRepositoryMock.Setup(repo => repo.GetByIdAsync(request.Id)).ReturnsAsync((ProductService)null);
            _serviceTypeRepositoryMock.Setup(repo => repo.GetByIdAsync(request.ServiceTypeId))
                .ReturnsAsync(serviceType);

            // Act
            var result = await useCase.ExecuteAsync(request);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(request.Id, result.Id);
            Assert.Equal(request.Name, result.Name);
            Assert.Equal(request.Description, result.Description);
            _productServiceRepositoryMock.Verify(repo => repo.SaveAndPublishAsync(result), Times.Once);
        }

        //[Fact]
        //public async Task ExecuteAsync_ShouldUpdateExistingProductService_WhenProductServiceExists()
        //{
        //    // Arrange
        //    var existingProductService = ProductService.Build(
        //        Guid.NewGuid(),
        //        new Name("Existing Product"),
        //        new Description("Existing Description"),
        //        new Price(200),
        //        new Uri("http://existing.com/image.png"),
        //        GeographicInfo.Build("Country", "State", "City"),
        //        new Plan("Existing Plan"),
        //        new TypeOfNutrition("Existing Nutrition"),
        //        new NutritionalPlan("Existing Nutritional Plan"),
        //        new TrainingPlan("Existing Training Plan"),
        //        new ServiceType("Existing Service Type"),
        //        new SportLevel("Existing Sport Level"),
        //        Guid.NewGuid(),
        //        DateTime.UtcNow,
        //        DateTime.UtcNow.AddDays(30)
        //        );

        //    var useCase = new CreateProductServiceUseCase(
        //        _productServiceRepositoryMock.Object,
        //        _planRepositoryMock.Object,
        //        _typeOfNutritionRepositoryMock.Object,
        //        _serviceTypeRepositoryMock.Object,
        //        _goalRepositoryMock.Object,
        //        _activityRepositoryMock.Object,
        //        _nutritionalAllergyRepositoryMock.Object,
        //        _nutritionalPlanRepositoryMock.Object,
        //        _trainingPlanRepositoryMock.Object
        //        );

        //    var request = new CreateProductServiceCommand
        //    {
        //        Id = existingProductService.Id,
        //        Name = "Updated Product",
        //        Description = "Updated Description",
        //        Price = new Price(100),
        //        Picture = new Uri("http://updated.com/image.png"),
        //        CountryId = "Country",
        //        StateId = "State",
        //        CityId = "City",
        //        ServiceTypeId = Guid.NewGuid(),
        //        SportLevel = new SportLevel("Updated Sport Level"),
        //        User = Guid.NewGuid(),
        //        StartDateTime = DateTime.UtcNow,
        //        EndDateTime = DateTime.UtcNow.AddDays(30)
        //    };

        //    _productServiceRepositoryMock.Setup(repo => repo.GetByIdAsync(request.Id)).ReturnsAsync(existingProductService);
        //    _serviceTypeRepositoryMock.Setup(repo => repo.GetByIdAsync(request.ServiceTypeId))
        //        .ReturnsAsync(new ServiceType("Updated Service Type"));

        //    // Act
        //    var result = await useCase.ExecuteAsync(request);

        //    // Assert
        //    Assert.NotNull(result);
        //    Assert.Equal(request.Id, result.Id);
        //    Assert.Equal(request.Name, result.Name);
        //    Assert.Equal(request.Description, result.Description);
        //    Assert.Equal(request.Price, result.Price);
        //    _productServiceRepositoryMock.Verify(repo => repo.SaveAndPublishAsync(result), Times.Once);
        //}

        //[Fact]
        //public async Task ExecuteAsync_ShouldThrowException_WhenServiceTypeNotFound()
        //{
        //    // Arrange
        //    var useCase = new CreateProductServiceUseCase(
        //        _productServiceRepositoryMock.Object,
        //        _planRepositoryMock.Object,
        //        _typeOfNutritionRepositoryMock.Object,
        //        _serviceTypeRepositoryMock.Object,
        //        _goalRepositoryMock.Object,
        //        _activityRepositoryMock.Object,
        //        _nutritionalAllergyRepositoryMock.Object,
        //        _nutritionalPlanRepositoryMock.Object,
        //        _trainingPlanRepositoryMock.Object
        //        );

        //    var request = new CreateProductServiceCommand
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Test Product",
        //        Description = "Test Description",
        //        Price = new Price(100),
        //        Picture = new Uri("http://test.com/image.png"),
        //        CountryId = "Country",
        //        StateId = "State",
        //        CityId = "City",
        //        ServiceTypeId = Guid.NewGuid(),
        //        SportLevel = new SportLevel("Test Sport Level"),
        //        User = Guid.NewGuid(),
        //        StartDateTime = DateTime.UtcNow,
        //        EndDateTime = DateTime.UtcNow.AddDays(30)
        //    };

        //    _productServiceRepositoryMock.Setup(repo => repo.GetByIdAsync(request.Id)).ReturnsAsync((ProductService)null);
        //    _serviceTypeRepositoryMock.Setup(repo => repo.GetByIdAsync(request.ServiceTypeId)).ReturnsAsync((ServiceType)null);

        //    // Act & Assert
        //    await Assert.ThrowsAsync<ServiceTypeNotFoundConflictException>(() => useCase.ExecuteAsync(request));
        //}

        // Añadir más pruebas para otros casos y dependencias como GetPlanAsync, GetTypeOfNutritionAsync, GetGoalsAsync, GetActivitiesAsync, GetAllergiesAsync
    }
