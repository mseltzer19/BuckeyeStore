using System;
using Xunit;

namespace BuckeyeStore.Core.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var product = new ProductTests
            {
                Id = 1,
                Name = "T-Shirt",
                Brand = "Nike"
            };

            var review = new review
            {
                Id = 1,
                Body = "A durable Buckeye T-shirt."
            };

            //Act
            product.AddReview(review);

            //Assert
            Assert.NoNull(product.Review);
            Assert.Equal(review.Id, product.Review.Id);
            Assert.Equal(review.Body, product.Review.Body);
        }
    }
}
