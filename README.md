# DamageLogs
A plugin for SCP:SL Smod2 servers, which allows advanced damage logs to be recorded to multiple log files and kept for a configurable amount of time. Extensive damage information, deaths, disconnects, and other event information can be configured to be logged. Administrators can use helpful commands to help sort through the data in-game if necessary.

## Installation
**[Smod2](https://github.com/Grover-c13/Smod2) must be installed for this to work.**

1. Grab the [latest release](https://github.com/NeonWizard/SCP-DamageLogs/releases/latest) of DamageLogs.
2) Place DamageLogs.dll in your server's `sm_plugins` folder.

## Commands
Command | Value Type | Description
--- | :---: | ---

## Configuration
Config Option | Value Type | Default Value | Description
--: | :---: | :---: | :--
dlogs_enable | Bool | True | Whether DamageLogs should be enabled on server start.
damagelogs_folder_path | String (Path) | %Appdata%\Roaming\SCP Secret Laboratory\ | Where the DamageLogs folder will be located.

*Note that all configs should go in your server config file, not config_remoteadmin.txt

### Place any suggestions/problems in [issues](https://github.com/NeonWizard/SCP-DamageLogs/issues)!
