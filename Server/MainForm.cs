using WebSocketSharp.Server;
using System.ComponentModel;

namespace Server
{
	public partial class MainForm : Form
	{
		public WebSocketServer Server;
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public ServerConfig Config { get; private set; }
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public static MainForm Instance { get; private set; }

		public MainForm()
		{
			Config = ServerConfig.Load();
			Instance = this;
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			NumB_PortUsed.DataBindings.Add("Value", Config, nameof(Config.Port), false, DataSourceUpdateMode.OnPropertyChanged);
			CreateServer();
		}

		private void CreateServer()
		{
			AppendLogText($"Starting a server on port {Config.Port}");
			Server = new WebSocketServer(Config.Port);
			Server.AddWebSocketService<ClientService.ReceivePlayerDataService>("/Client");
			Server.Start();
			AppendLogText($"Started!");
		}

		private void B_Reset_Click(object sender, EventArgs e)
		{
			AppendLogText("Stopping server");
			Server.Stop();
			CreateServer();
		}

		public void AppendLogText(string text)
		{
			if (text == null)
				return;

			if (RB_Log.InvokeRequired)
			{
				RB_Log.Invoke(new Action(() =>
				{
					AppendLogText(text);
				}));
			}
			else
			{
				RB_Log.AppendText(text + "\r\n");
			}
		}

		public void AppendLogTextWithTime(string text) => AppendLogText($"{DateTime.Now}: {text}");
	}
}
