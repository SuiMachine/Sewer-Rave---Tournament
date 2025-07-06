using WebSocketSharp;
using WebSocketSharp.Server;

namespace Server.ClientService
{
	public class ReceivePlayerDataService : WebSocketBehavior
	{
		protected override void OnClose(CloseEventArgs e)
		{
			MainForm.Instance?.AppendLogTextWithTime($"Client disconnected (session {this.ID})");
		}

		protected override void OnError(WebSocketSharp.ErrorEventArgs e)
		{
			MainForm.Instance?.AppendLogTextWithTime($"Error with connection of {this.Context.UserEndPoint.Address}: {e.Message}");
		}

		protected override void OnMessage(MessageEventArgs e)
		{
			MainForm.Instance?.AppendLogTextWithTime($"Received message connected from {this.Context.UserEndPoint.Address} (session {this.ID}): {e.Data}");
		}

		protected override void OnOpen()
		{
			MainForm.Instance?.AppendLogTextWithTime($"Client connected from {this.Context.UserEndPoint.Address} (session {this.ID})");
		}
	}
}
