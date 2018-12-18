using Smod2;
using Smod2.Attributes;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.Config;

namespace DamageLogs
{
	[PluginDetails(
		author = "Spooky",
		name = "DamageLogs",
		description = "Log player damage to organized files with configurable expirations.",
		id = "xyz.wizardlywonders.DamageLogs",
		version = "1.0.0",
		SmodMajor = 3,
		SmodMinor = 1,
		SmodRevision = 22
	)]
	public class DamageLogs : Plugin
	{
		public override void OnDisable()
		{
			this.Info("DamageLogs has been disabled.");
		}

		public override void OnEnable()
		{
			this.Info("DamageLogs has loaded successfully.");
		}

		public override void Register()
		{
			// Register config settings
			this.AddConfig(new ConfigSetting("dlogs_enable", true, SettingType.BOOL, true, "Whether DamageLogs should be enabled on server start."));
			// - log damage
			// - log kills
			// - log item pickups
			// - log item drops
			// - log grenade throws (?)
			// - log spawn events

			// Register events
			this.AddEventHandlers(new MiscEventHandler(this), Priority.Highest);
			this.AddEventHandlers(new LoggableEventsHandler(this), Priority.Highest);

			// Register commands
		}
	}
}
