namespace BroadcastUtils
{
    using System.ComponentModel;

    public class MainConfig
    {
        [Description("Whether the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        public PlayerJoin PlayerJoined { get; set; } = new PlayerJoin();
        public class PlayerJoin
        {

            [Description("Whether Player broadcast when he joins is enabled")]
            public bool isEnabled { get; set; } = true;

            [Description("Broadcast sent to player when he joins the server (use %player% to show his nickname)")]
            public string broadcast { get; set; } = "<color=#0000FF>Welcome to the server %player%!</color>";

            [Description("Duration in seconds for the broadcast when player joins the server")]
            public ushort duration { get; set; } = 5;
        }

        public PlayerSpawn PlayerSpawned { get; set; } = new PlayerSpawn();
        public class PlayerSpawn
        {

            [Description("Whether Player broadcast when he spawns is enabled")]
            public bool isEnabled { get; set; } = true;

            [Description("Broadcast sent to player when he spawns (use %player% to show his nickname)")]
            public string broadcast { get; set; } = "<color=#0000FF>Remember the rules %player%!</color>";

            [Description("Duration in seconds for the broadcast when player spawns")]
            public ushort duration { get; set; } = 2;
        }

        public PlayerMute PlayerMuted { get; set; } = new PlayerMute();
        public class PlayerMute
        {

            [Description("Whether Player broadcast when muted from Intercom or Voice Chat is enabled")]
            public bool isEnabled { get; set; } = true;
            public Ic Intercom { get; set; } = new Ic();
            public class Ic
            {
                [Description("Broadcast sent to player when muted from the Intercom (Use %issuer% to get the nickname of the moderator)")]
                public string broadcast { get; set; } = "<color=#FF0000>You have been restricted from using the Intercom!</color>";

                [Description("Duration in seconds for the broadcast when player gets muted from the Intercom")]
                public ushort duration { get; set; } = 5;
            }

            public Vc VoiceChat { get; set; } = new Vc();
            public class Vc
            {
                [Description("Broadcast sent to player when muted from the Voice Chat (Use %issuer% to get the nickname of the moderator)")]
                public string broadcast { get; set; } = "<color=#FF0000>You have been muted by %issuer%!</color>";

                [Description("Duration in seconds for the broadcast when player gets muted from the Voice Chat")]
                public ushort duration { get; set; } = 5;
            }
        }

        public PlayerUnMute PlayerUnMuted { get; set; } = new PlayerUnMute();
        public class PlayerUnMute
        {
            [Description("whether Player broadcast when unmuted from the Intercom or Voice Chat is enabled")]
            public bool isEnabled { get; set; } = true;
            public Ic Intercom { get; set; } = new Ic();
            public class Ic
            {
                [Description("Broadcast sent to player when unmuted from the Intercom (Use %issuer% to get the nickname of the moderator)")]
                public string broadcast { get; set; } = "<color=#00FF00>You are now able to use the Intercom again!</color>";

                [Description("Duration in seconds for the broadcast when player gets unmuted from the Intercom")]
                public ushort duration { get; set; } = 5;
            }

            public Vc VoiceChat { get; set; } = new Vc();
            public class Vc
            {
                [Description("Broadcast sent to player when unmuted from the Voice Chat (Use %issuer% to get the nickname of the moderator)")]
                public string broadcast { get; set; } = "<color=#00FF00>You are now able to speak again!</color>";

                [Description("Duration in seconds for the broadcast when player gets unmuted from the Voice Chat")]
                public ushort duration { get; set; } = 5;
            }
        }
    }
}
