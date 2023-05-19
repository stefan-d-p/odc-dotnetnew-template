using OutSystems.ExternalLibraries.SDK;

namespace ODCExternalLogic;

public class ODCExternalLogic : IODCExternalLogic
{
    public string Echo(string message)
    {
        return message;
    }
}
