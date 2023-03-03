using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.Handlers;
using ServerEv = Exiled.Events.Handlers.Server;
using PlayerEv = Exiled.Events.Handlers.Player;
using Exiled.CustomItems.API.Features;
using Exiled.CustomRoles.API.Features;

namespace SCPSpeedBoost
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "SCP Speed Boost";
        public override string Author => "TtroubleTT";
        public override Version Version => new Version(1, 0, 1);
        public static Plugin plugin;

        public override void OnEnabled()
        {
            plugin = this;
            PlayerEv.ChangingRole += EventHandlers.ChangingRole;


            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            plugin = null;
            PlayerEv.ChangingRole -= EventHandlers.ChangingRole;

            base.OnDisabled();
        }
    }
}
