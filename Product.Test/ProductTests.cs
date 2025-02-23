using Microsoft.EntityFrameworkCore;
using Product.API.Context;
using Product.API.IRepository;
using Product.API.Models;
using Product.API.Repository;
using System;

namespace Product.Test
{
    public class ProductTests
    {
        private readonly IProductRepository _repository;

        public ProductTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            var context = new AppDbContext(options);
            _repository = new ProductRepository(context);
        }

        [Fact]
        public async Task AddProduct_Should_AddProductSuccessfully()
        {
            var product = new MyProduct { Name = "Test Product", Price = 10, StockQuantity = 5 };
            await _repository.AddAsync(product);
            var retrievedProduct = await _repository.GetByIdAsync(product.ProductId);
            Assert.NotNull(retrievedProduct);
        }

        [Fact]
        public async Task GetProduct_Should_ReturnNotFound()
        {
            var product = await _repository.GetByIdAsync(999);
            Assert.Null(product);
        }

        [Fact]
        public async Task DeleteProduct_Should_RemoveProduct()
        {
            var product = new MyProduct { Name = "Test Product", Price = 10, StockQuantity = 5 };
            await _repository.AddAsync(product);
            await _repository.DeleteAsync(product.ProductId);
            var deletedProduct = await _repository.GetByIdAsync(product.ProductId);
            Assert.Null(deletedProduct);
        }
    }
}