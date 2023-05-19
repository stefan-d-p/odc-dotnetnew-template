using OutSystems.ExternalLibraries.SDK;

namespace ODCExternalLogic;

public class Actions : IActions
{
    public string Echo(string message)
    {
        return message;
    }
}
