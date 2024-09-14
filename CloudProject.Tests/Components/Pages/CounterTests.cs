using Bunit;
using CloudProject.Components.Pages;
using Xunit;

namespace CloudProject.Tests.Components.Pages;

public class CounterTests
{
    [Fact]
    public void ShouldBe0AtInit()
    {
        // Arrange
        using var ctx = new BunitContext();
        var counter = ctx.Render<Counter>();
        
        // Act
        var button = counter.Find("button");
        button.Click();
        
        // Assert
        var currentCount = counter.Find("#current-count");
        currentCount.TextContent.MarkupMatches("Current count: 1");
    }
}