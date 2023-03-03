using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using PlayerRoles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPSpeedBoost
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled:")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug Config:")]
        public bool Debug { get; set; } = true;

        /*
        [Description("Whether or not the effect will apply to the specified SCPs at the beginning of the round:")]
        public bool EffectOnRoundStart { get; set; } = true;

        [Description("Whether or not the effect will apply to the specified SCPs when you forceclass them:")]
        public bool EffectOnForceclass { get; set; } = true;
        */

        [Description("SCP 173s Movement Boost percentage (up to 255). Leave 0 for no boost:")]
        public byte SCP173Boost { get; set; } = 0;

        [Description("SCP 096s Movement Boost percentage (up to 255). Leave 0 for no boost:")]
        public byte SCP096Boost { get; set; } = 0;

        [Description("SCP 106s Movement Boost percentage (up to 255). Leave 0 for no boost:")]
        public byte SCP106Boost { get; set; } = 0;

        [Description("SCP 939s Movement Boost percentage (up to 255). Leave 0 for no boost:")]
        public byte SCP939Boost { get; set; } = 0;

        [Description("SCP 049s Movement Boost percentage (up to 255). Leave 0 for no boost:")]
        public byte SCP049Boost { get; set; } = 0;

        [Description("SCP 049-2s Movement Boost percentage (up to 255). Leave 0 for no boost:")]
        public byte SCP0492Boost { get; set; } = 0;

    }
}
