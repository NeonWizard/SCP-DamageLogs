using Smod2;
using Smod2.Attributes;
using Smod2.Events;
using Smod2.EventHandlers;
using Smod2.API;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DamageLogs.Managers
{
	public class LogManager
	{
		static IConfigFile Config => ConfigManager.Manager.Config;

		internal class LogData
		{
			internal string Content;
			internal string Type;
			internal string Time;
			internal bool Saved;
		}
		private readonly List<LogData> logs = new List<LogData>();

		private int _maxlen;

		private static readonly string damagelogsFolderPath = Config.GetStringValue("damagelogs_folder_path", string.Empty);
		private static readonly string appFolder = FileManager.GetAppFolder();

		private static readonly string DamageLogsFolder = (damagelogsFolderPath != string.Empty)
			? ((damagelogsFolderPath.EndsWith(Path.DirectorySeparatorChar.ToString())) ? "DamageLogs" : Path.DirectorySeparatorChar + "DamageLogs")
			: appFolder + "DamageLogs";

		public string GetFolderLocation()
		{
			return DamageLogsFolder;
		}

		public enum LogType
		{
			Kill,
			TeamKill,
			Suicide,
			TeamDamage,
			Damage,
			Misc
		}
	}
}
