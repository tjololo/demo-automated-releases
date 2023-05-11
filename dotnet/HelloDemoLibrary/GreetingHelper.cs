namespace HelloDemoLibrary;

/// <summary>
/// Helper class for greetings
/// </summary>
public class GreetingHelper
{
    private const string GREETING_PREFIX = "Hello";

    /// <summary>
    /// Get greeting string for given name
    /// </summary>
    /// <param name="name">Name in greeting</param>
    /// <returns>Greeting for name</returns>
    public string GetGreetingForName(string name)
    {
        return $"{GREETING_PREFIX} {name}.";
    }
}
