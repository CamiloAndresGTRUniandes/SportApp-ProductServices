namespace SportApp.ProductServices.Application.UnitTest.Tests ;
using Data;
using Moq;
using ProductsServices.Application.ProductService.Exceptions;
using ProductsServices.Application.ProductService.UseCases;
using ProductsServices.Domain.Common.ValueObjects;
using ProductsServices.Domain.ProductService;
using ProductsServices.Domain.ProductService.Commands;
using ProductsServices.Domain.ProductService.Repositories;

    public class CreateCategoryUseCaseTest
    {
        private readonly Mock<ICategoryRepository> _categoryRepositoryMock;
        private readonly CreateCategoryUseCase _useCase;

        public CreateCategoryUseCaseTest()
        {
            _categoryRepositoryMock = new Mock<ICategoryRepository>();
            _useCase = new CreateCategoryUseCase(_categoryRepositoryMock.Object);
        }

        [Fact]
        public async Task CategoryCreatedSuccessFully()
        {
            //Arrange
            var request = new CreateCategoryCommand
            {
                Id = Guid.Parse("7300e12e-f3df-4a8b-9847-45f07362cee9"),
                Name = "New Category",
                Description = "Category Description",
                User = Guid.Parse("6ad77258-01bf-4d2b-b8ee-37e2099e0216")
            };
            _categoryRepositoryMock.Setup(x => x.GetByNameAsync(It.IsAny<Name>())).ReturnsAsync((Category)null);
            _categoryRepositoryMock.Setup(x => x.SaveAndPublishAsync(It.IsAny<Category>()));

            //Act
            var response = await _useCase.ExecuteAsync(request);

            //Assert
            Assert.Equal(request.Id, response.Id);
            Assert.Equal(request.Name, response.Name);
            Assert.Equal(request.Description, response.Description);
            Assert.Equal(request.User, response.CreatedBy);
            _categoryRepositoryMock.Verify(x => x.GetByNameAsync(It.IsAny<Name>()), Times.Once);
            _categoryRepositoryMock.Verify(x => x.SaveAndPublishAsync(It.IsAny<Category>()), Times.Once);
        }

        [Fact]
        public async Task CreateCategoryThrowsCategoryAlreadyExistException()
        {
            //Arrange
            var category = CategoryMother.Create();
            var request = new CreateCategoryCommand
            {
                Id = Guid.Parse("7300e12e-f3df-4a8b-9847-45f07362cee9"),
                Name = "New Category",
                Description = "Category Description",
                User = Guid.Parse("6ad77258-01bf-4d2b-b8ee-37e2099e0216")
            };
            _categoryRepositoryMock.Setup(x => x.GetByNameAsync(It.IsAny<Name>())).ReturnsAsync(category);

            //Act
            var exception =
                await Assert.ThrowsAsync<CategoryAlreadyExistConflictException>(() => _useCase.ExecuteAsync(request));

            //Assert
            Assert.Equal("Category New Category Name, already exist", exception.Message);

            _categoryRepositoryMock.Verify(x => x.GetByNameAsync(It.IsAny<Name>()), Times.Once);
            _categoryRepositoryMock.Verify(x => x.SaveAndPublishAsync(It.IsAny<Category>()), Times.Never);
        }
    }
