using LyainBot.Plugins;

namespace LyainBot.ExamplePlugin;

public class ExamplePlugin : IPlugin
{
    private readonly SharedData _sharedData;

    public ExamplePlugin(SharedData sharedData)
    {
        _sharedData = sharedData;
    }
    
    public void Load()
    {
        _sharedData.CommandManager.RegisterCommand(new ExampleCommand());
    }

    public void Unload()
    {
    }
}