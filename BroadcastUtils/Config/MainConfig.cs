﻿namespace BroadcastUtils
{
    using System.ComponentModel;

    public class MainConfig
    {
        [Description("Wheter the plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        public PlayerJoin PlayerJoined { get; set; } = new PlayerJoin();
        public class PlayerJoin
        {

            [Description("Wheter Player broadcast when he joins is enabled")]
            public bool isEnabled { get; set; } = true;

            [Description("Broadcast sent to player when he joins the server")]
            public string broadcast { get; set; } = "<color=#0000FF>Welcome to the server!</color>";

            [Description("Duration in seconds for the broadcast when player joins the server")]
            public ushort duration { get; set; } = 5;
        }

        public PlayerMute PlayerMuted { get; set; } = new PlayerMute();
        public class PlayerMute
        {

            [Description("Wheter Player broadcast when muted from Intercom or Voice Chat is enabled")]
            public bool isEnabled { get; set; } = true;
            public Ic Intercom { get; set; } = new Ic();
            public class Ic
            {   
                [Description("Broadcast sent to player when muted intercom")]
                public string broadcast { get; set; } = "<color=#FF0000>You have been restricted from using the Intercom!</color>";

                [Description("Duration in seconds for the broadcast when player gets muted from the Intercom")]
                public ushort duration { get; set; } = 5;
            }

                public Vc VoiceChat { get; set; } = new Vc();
                public class Vc
                {
                    [Description("Broadcast sent to player when muted from the Voice Chat")]
                    public string broadcast { get; set; } = "<color=#FF0000>You have been muted!</color>";

                    [Description("Duration in seconds for the broadcast when player gets muted from the Voice Chat")]
                    public ushort duration { get; set; } = 5;
                }
            }

            public PlayerUnMute PlayerUnMuted { get; set; } = new PlayerUnMute();
            public class PlayerUnMute
            {
                [Description("Wheter Player broadcast when unmuted from the Intercom or Voice Chat is enabled")]
                public bool isEnabled { get; set; } = true;
                public Ic Intercom { get; set; } = new Ic();
                public class Ic
                {
                    [Description("Broadcast sent to player when unmuted from the Intercom")]
                    public string broadcast { get; set; } = "<color=#00FF00>You are now able to use the Intercom again!</color>";

                    [Description("Duration in seconds for the broadcast when player gets unmuted from the Intercom")]
                    public ushort duration { get; set; } = 5;
                }

                public Vc VoiceChat { get; set; } = new Vc();
                public class Vc
                {
                    [Description("Broadcast sent to player when unmuted from the Voice Chat")]
                    public string broadcast { get; set; } = "<color=#00FF00>You are now able to speak again!</color>";

                    [Description("Duration in seconds for the broadcast when player gets unmuted from the Voice Chat")]
                    public ushort duration { get; set; } = 5;
                }
            }
    }
}