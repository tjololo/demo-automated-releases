using FluentAssertions;

namespace HelloDemoLibrary.Tests;

public class GreetingsHelperTests
{
    [Fact]
    public void GetGreetingForName_returns_name_with_prefix()
    {
      var expected = "Hello test";
      GreetingHelper helper = new GreetingHelper();
      var actual = helper.GetGreetingForName("test");
      actual.Should().Be(expected);
    }
}