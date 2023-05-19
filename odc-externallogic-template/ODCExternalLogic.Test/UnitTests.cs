namespace ODCExternalLogic.Test;

public class Tests
{

    private static readonly IODCExternalLogic _actions = new ODCExternalLogic();

    [SetUp]
    public void Setup()
    {
 
    }

    [Test]
    public void Echo_Returns_Successful()
    {
        string message = "Pingback";
        var result = _actions.Echo(message);
        Assert.That(result, Is.EqualTo(message));
    }
}