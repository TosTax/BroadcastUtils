namespace BroadcastUtils
{
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using PluginAPI.Events;
    using MEC;

    public class Plugin
    {
        [PluginConfig]
        public MainConfig MainConfig;

        public static Plugin Instance { get; private set; }
        [PluginEntryPoint("BroadcastUtils", "1.0.0", "Different Broadcast Utilities for your SCP:SL server using NWAPI.", "TosTa")]

        public void OnEnabled()
        {
            if (!MainConfig.IsEnabled) return;
            Instance = this;
            EventManager.RegisterEvents(this);
            Log.Info("BroadcastUtils loaded successfully!");
        }

        [PluginEvent(ServerEventType.PlayerJoined)]
        public void OnPlayerJoin(Player player)
        {
            if (!MainConfig.PlayerJoined.isEnabled) return;
            {
                if (string.IsNullOrEmpty(MainConfig.PlayerJoined.broadcast) || MainConfig.PlayerJoined.duration == 0) return;
                Log.Info($"Player {player.DisplayNickname} ({player.UserId}) joined the server");
                string message = MainConfig.PlayerJoined.broadcast.Replace("%player%", $"{player.Nickname}");
                player.SendBroadcast(message, MainConfig.PlayerJoined.duration);
            }
        }

        [PluginEvent]
        public void OnPlayerSpawn(PlayerSpawnEvent args)
        {
            if (!MainConfig.PlayerSpawned.isEnabled) return;
            {
                if (string.IsNullOrEmpty(MainConfig.PlayerSpawned.broadcast) || MainConfig.PlayerSpawned.duration == 0) return;
                if (!args.Player.IsAlive || args.Player.Role is PlayerRoles.RoleTypeId.Tutorial) return;
                string message = MainConfig.PlayerSpawned.broadcast.Replace("%player%", $"{args.Player.Nickname}");
                Timing.CallDelayed(0.1f, () =>
                args.Player.SendBroadcast(message, MainConfig.PlayerSpawned.duration));
            }
        }

        [PluginEvent(ServerEventType.PlayerMuted)]
        public void OnPlayerMuted(Player player, Player issuer, bool isIntercom)
        {
            if (!MainConfig.PlayerMuted.isEnabled) return;
            {
                if (isIntercom == true)
                {
                    if (string.IsNullOrEmpty(MainConfig.PlayerMuted.Intercom.broadcast) || MainConfig.PlayerMuted.Intercom.duration == 0) return;
                    Log.Info($"Player {player.DisplayNickname} ({player.UserId}) has been muted from the Intercom by {issuer.Nickname} ({issuer.UserId})");
                    string message = MainConfig.PlayerMuted.Intercom.broadcast.Replace("%issuer%", $"{issuer.Nickname}");
                    player.SendBroadcast(message, MainConfig.PlayerMuted.Intercom.duration);
                }
                else
                {
                    if (string.IsNullOrEmpty(MainConfig.PlayerMuted.VoiceChat.broadcast) || MainConfig.PlayerMuted.VoiceChat.duration == 0) return;
                    Log.Info($"Player {player.DisplayNickname} ({player.UserId}) has been muted by {issuer.Nickname} ({issuer.UserId})");
                    string message = MainConfig.PlayerMuted.VoiceChat.broadcast.Replace("%issuer%", $"{issuer.Nickname}");
                    player.SendBroadcast(message, MainConfig.PlayerMuted.VoiceChat.duration);
                }
            }
        }

        [PluginEvent(ServerEventType.PlayerUnmuted)]
        public void OnPlayerUnMuted(Player player, Player issuer, bool isIntercom)
        {
            if (!MainConfig.PlayerUnMuted.isEnabled) return;
            {
                if (isIntercom == true)
                {
                    if (string.IsNullOrEmpty(MainConfig.PlayerUnMuted.Intercom.broadcast) || MainConfig.PlayerUnMuted.Intercom.duration == 0) return;
                    {
                        Log.Info($"Player {player.DisplayNickname} ({player.UserId}) has been unmuted from the Intercom by {issuer.Nickname} ({issuer.UserId})");
                        string message = MainConfig.PlayerUnMuted.Intercom.broadcast.Replace("%issuer%", $"{issuer.Nickname}");
                        player.SendBroadcast(message, MainConfig.PlayerUnMuted.Intercom.duration);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(MainConfig.PlayerUnMuted.VoiceChat.broadcast) || MainConfig.PlayerUnMuted.VoiceChat.duration == 0) return;
                    Log.Info($"Player {player.DisplayNickname} ({player.UserId}) has been muted by {issuer.Nickname} ({issuer.UserId})");
                    string message = MainConfig.PlayerUnMuted.VoiceChat.broadcast.Replace("%issuer%", $"{issuer.Nickname}");
                    player.SendBroadcast(message, MainConfig.PlayerUnMuted.VoiceChat.duration);
                }
            }
        }
    }
}