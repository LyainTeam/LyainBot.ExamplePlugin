using LyainBot.Command;
using LyainBot.Extension;
using Newtonsoft.Json;
using TL;
using WTelegram;

namespace LyainBot.ExamplePlugin;

[CommandInfo("example", "This is an example command.", true, "sample")]
public class ExampleCommand : ICommand
{
    public void OnInvoke(Message message, UpdateManager manager, Client client, string[] args)
    {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Formatting = Formatting.Indented;
        serializer.NullValueHandling = NullValueHandling.Ignore;
        Dictionary<string, string> testData = new()
        {
            { "LyainBot", ">=1.0.0" },
            { "WTelegram", ">=2.0.0" },
            { "Newtonsoft.Json", ">=13.0.0" }
        };
        string json = JsonConvert.SerializeObject(testData, Formatting.Indented);
        
        message.Edit("This is a example command! Test dependency: " + json);
    }
}