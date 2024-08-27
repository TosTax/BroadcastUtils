# BroadcastUtils ![Downloads](https://img.shields.io/github/downloads/TosTax/BroadcastUtils/total)
SCP:SL plugin with different Broadcast utilities. Made using [NorthWood Plugin API](https://github.com/northwood-studios/NwPluginAPI).

This plugin was made inspired by the EXILED plugin [AutoBroadcast](https://github.com/Misfiy/AutoBroadcast)


# Features
* Broadcast message displayed to the player when they join the server
* Broadcast message displayed to the player when they spawn
* Broadcast message displayed to the player when they are muted
* Broadcast message displayed to the player when they are unmuted


# Installation

## Automatic
1. If you don't have the plugin manager enabled run in the server console `p`and then `p confirm`to enable the plugin manager
2. Run `p install TosTax/BroadcastUtils`in your console to automatically install the plugin in your server
3. Restart your server

## Manual
1. Download the `BroadcastUtils.dll` from the [latest release](https://github.com/TosTax/BroadcastUtils/releases/latest)
2. Place the dll in your plugins folder
3. Restart your server


# Support
* For any issues create an issue or contact me in [Discord](https://discord.gg/fxHnJNukfp)
* If you want something added you can ask for it in Discord too


# Config
* Example config file:
```yaml
is_enabled: true
player_joined:
  is_enabled: true
  broadcast: <color=#0000FF>Welcome to the server %player%!</color>
  duration: 5
player_spawned:
  is_enabled: true
  broadcast: <color=#0000FF>Remember the rules, %player%!</color>
  duration: 3
player_muted:
  is_enabled: true
  intercom:
    broadcast: <color=#FF0000>You have been restricted from using the Intercom!</color>
    duration: 5
  voice_chat:
    broadcast: <color=#FF0000>You have been muted by %issuer%!</color>
    duration: 5
player_un_muted:
  is_enabled: true
  intercom:
    broadcast: <color=#00FF00>You are now able to use the Intercom again!</color>
    duration: 5
  voice_chat:
    broadcast: <color=#00FF00>You are now able to speak again!</color>
    duration: 5
```
