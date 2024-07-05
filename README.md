# BroadcastUtils ![Downloads](https://img.shields.io/github/downloads/TosTax/BroadcastUtils/total)
 My first SCP:SL plugin made public using the Official NorthWood API.

 This plugin was made inspired by the EXILED plugin [AutoBroadcast](https://github.com/Misfiy/AutoBroadcast)

 # Features
* Broadcast message displayed to the player when they join the server
* Broadcast message displayed to the player when they spawn
* Broadcast message displayed to the player when they are muted
* Broadcast message displayed to the player when they are unmuted

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
