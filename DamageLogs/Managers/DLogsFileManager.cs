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
	public class DLogsFileManager
	{
		static IConfigFile Config => ConfigManager.Manager.Config;

		private static readonly string appFolder = FileManager.GetAppFolder();
	}
}
