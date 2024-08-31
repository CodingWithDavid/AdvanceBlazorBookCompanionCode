using Bunit;
using Xunit;
using Chapter7.Components; // Replace with your component's namespace

public class MyComponentTests : TestContext
{
    [Fact]
    public void MyComponent_Should_RenderCorrectly()
    {
        // Arrange
        var cut = RenderComponent<MyComponent>();

        // Act & Assert
        cut.MarkupMatches("<h1>Hello, world!</h1>");
    }
}
