using OutSystems.ExternalLibraries.SDK;

namespace ODCExternalLogic
{
    [OSInterface(
        Description = "Sample template action")]
    public interface IActions
    {
        /// <summary>
        /// Sample ODC server action
        /// </summary>
        /// <param name="message">Any text that will</param>
        /// <returns>A text message including the message parameter</returns>

        [OSAction(
            Description = "Echoes back a message",
            ReturnName = "EchoMessage",
            ReturnType = OSDataType.Text)]
        string Echo(
            [OSParameter(
                DataType = OSDataType.Text,
                Description = "Message to echo back")]
            string message);
    }
}