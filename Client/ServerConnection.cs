using System;
using BepInEx.Configuration;

namespace SewerSocket
{
    public class ServerConnection
    {
        public static bool IsAlive => ws.IsAlive;
        private static ConfigEntry<string> SERVER_IP;
        private static ConfigEntry<int> SERVER_PORT;
        private static WebSocketSharp.WebSocket ws;

        public static void Initialize(BepInEx.Configuration.ConfigFile config)
        {
            SERVER_IP = config.Bind("SewerSocket", "IP_Address", "127.0.0.1", "IP address to connect to");
            SERVER_PORT = config.Bind("SewerSocket", "Port", 4567, "Port to use");

            Plugin.Log($"Connecting to: {SERVER_IP.Value}:{SERVER_PORT.Value}");
            ws = new WebSocketSharp.WebSocket($"ws://{SERVER_IP.Value}:{SERVER_PORT.Value}/Client");
            ws.OnOpen += Ws_OnOpen;
            ws.OnClose += Ws_OnClose;
            ws.OnMessage += Ws_OnMessage;
            ws.OnError += Ws_OnError;
            Plugin.Log($"Connecting");
            ws.ConnectAsync();
        }

        public static void Send(string data)
        {
            Plugin.Log($"Data to send: {data}");
            if(ws.IsAlive)
            {
                ws.SendAsync(data, new Action<bool>((res) =>
                {
                    if (!res)
                        Plugin.Error("Failed to send update!");
                }));
            }
        }

        private static void Ws_OnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            Plugin.Error($"Socket error");
        }

        private static void Ws_OnMessage(object sender, WebSocketSharp.MessageEventArgs e)
        {
            if(e.Data != null)
            {
                Plugin.Log($"{e.Data}");
            }
            else
                Plugin.Log($"Message received");
        }

        private static void Ws_OnClose(object sender, WebSocketSharp.CloseEventArgs e)
        {
            Plugin.Log($"Closed connection");
        }

        private static void Ws_OnOpen(object sender, System.EventArgs e)
        {
            Plugin.Log($"Opened connection");
            ws.Send("Connection");
        }
    }
}
