using Xunit;

public class ProductTests
{
    [Fact]
    public void ProductName_ShouldNotBeEmpty()
    {
        // Arrange
        var product = new Product
        {
            Name = ""
        };

        // Act
        bool isValid = !string.IsNullOrWhiteSpace(product.Name);

        // Assert
        Assert.False(isValid, "O nome do produto não pode estar vazio.");
    }
}

public class Product
{
    public string Name { get; set; }
}
