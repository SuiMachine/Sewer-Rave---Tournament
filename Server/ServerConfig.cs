
using System.Xml.Serialization;

namespace Server
{
	[Serializable]
	public class ServerConfig
	{
		private const string CONFIG_NAME = "ServerConfig.xml";
		public int Port { get; set; } = 4567;

		public static ServerConfig Load()
		{
			if (File.Exists(CONFIG_NAME))
			{
				try
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(ServerConfig));
					using FileStream fs = new FileStream(CONFIG_NAME, FileMode.Open);
					var newConfig = xmlSerializer.Deserialize(fs) as ServerConfig;
					return newConfig!;
				}
				catch (Exception ex)
				{
					Logger.Error("Failed to read config file " + ex.ToString());
					var config = new ServerConfig();
					config.Save();
					return config;
				}
			}
			else
			{
				var config = new ServerConfig();
				config.Save();
				return config;
			}
		}

		private void Save()
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(ServerConfig));
			using FileStream fs = new FileStream(CONFIG_NAME, FileMode.Create);
			xmlSerializer.Serialize(fs, this);
			fs.Close();
		}
	}
}
