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
	class LoggableEventsHandler : IEventHandlerPlayerHurt, IEventHandlerPlayerDie
	{
		private readonly DamageLogs plugin;

		public LoggableEventsHandler(DamageLogs plugin) => this.plugin = plugin;

		public void OnPlayerDie(PlayerDeathEvent ev)
		{
			throw new NotImplementedException();
		}

		public void OnPlayerHurt(PlayerHurtEvent ev)
		{
			throw new NotImplementedException();
		}
	}
}
