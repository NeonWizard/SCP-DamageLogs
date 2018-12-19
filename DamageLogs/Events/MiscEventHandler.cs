using Smod2;
using Smod2.API;
using Smod2.Events;
using Smod2.EventHandlers;
using UnityEngine;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Linq;

namespace DamageLogs
{
	class MiscEventHandler : IEventHandlerWaitingForPlayers
	{
		private readonly DamageLogs plugin;
		static IConfigFile Config => ConfigManager.Manager.Config;

		public MiscEventHandler(DamageLogs plugin) => this.plugin = plugin;

		public void OnWaitingForPlayers(WaitingForPlayersEvent ev)
		{
			if (!Config.GetBoolValue("damagelogs_enable", true)) this.plugin.pluginManager.DisablePlugin(plugin);
		}
	}
}
