using System;
using BepInEx;
using BepInEx.Logging;

namespace SewerSocket;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;

    internal static void Error(string v) => Logger.LogError(v);

    internal static void Log(string v) => Logger.LogMessage(v);

    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        ServerConnection.Initialize(this.Config);
        Watcher.Initialize();

    }
}
