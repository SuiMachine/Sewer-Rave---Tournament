namespace Server
{
	public static class Logger
	{
		private const string FILE_NAME = "Server.log";

		public static void Log(string text) => File.AppendText($"{DateTime.Now} {text}\r\n");
		public static void Error(string text) => File.AppendText($"[ERROR] {DateTime.Now} {text}\r\n");
	}
}
