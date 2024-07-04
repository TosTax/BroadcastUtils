namespace BroadcastUtils
{
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using PluginAPI.Events;

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
                Log.Info($"Player {player.DisplayNickname} ({player.UserId}) joined the server");
                player.SendBroadcast(MainConfig.PlayerJoined.broadcast, MainConfig.PlayerJoined.duration);
            }
        }

        [PluginEvent(ServerEventType.PlayerMuted)]
        public void OnPlayerMuted(Player player, Player issuer, bool isIntercom)
        {
            if (!MainConfig.PlayerMuted.isEnabled) return;
            {
                if (isIntercom == true)
                {
                    Log.Info($"Player {player.DisplayNickname} ({player.UserId}) has been muted from the Intercom by {issuer.Nickname} ({issuer.UserId})");
                    player.SendBroadcast(MainConfig.PlayerMuted.Intercom.broadcast, MainConfig.PlayerMuted.Intercom.duration);
                }
                else
                {
                    Log.Info($"Player {player.DisplayNickname} ({player.UserId}) has been muted by {issuer.Nickname} ({issuer.UserId})");
                    player.SendBroadcast(MainConfig.PlayerMuted.VoiceChat.broadcast, MainConfig.PlayerMuted.VoiceChat.duration);
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
                    Log.Info($"Player {player.DisplayNickname} ({player.UserId}) has been unmuted from the Intercom by {issuer.Nickname} ({issuer.UserId})");
                    player.SendBroadcast(MainConfig.PlayerUnMuted.Intercom.broadcast, MainConfig.PlayerUnMuted.Intercom.duration);
                }
                else
                {
                    Log.Info($"Player {player.DisplayNickname} ({player.UserId}) has been muted by {issuer.Nickname} ({issuer.UserId})");
                    player.SendBroadcast(MainConfig.PlayerUnMuted.VoiceChat.broadcast, MainConfig.PlayerUnMuted.VoiceChat.duration);
                }
            }
        }
    }
}