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
        
        [Description("The speed boost for SCPs (up to 255). Leave 0 for no boost:")]
        public Dictionary<RoleTypeId, byte> SpeedBoost { get; set; } = new Dictionary<RoleTypeId, byte>
        {
            [RoleTypeId.Scp173] = 0,
            [RoleTypeId.Scp096] = 0,
            [RoleTypeId.Scp106] = 0,
            [RoleTypeId.Scp939] = 0,
            [RoleTypeId.Scp049] = 0,
            [RoleTypeId.Scp0492] = 0
        };
    }
}
