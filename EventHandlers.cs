using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using MEC;
using Exiled.Events.Handlers;
using Player = Exiled.Events.Handlers.Player;

namespace SCPSpeedBoost
{
    // Event Handler class where all the events that are called are stored
    public static class EventHandlers
    {
        public static void ChangingRole(ChangingRoleEventArgs ev)
        {
            if (!Plugin.plugin.Config.SpeedBoost.TryGetValue(ev.NewRole, out byte speedBoost)) return;
            if (speedBoost <= 0) return;
            Timing.CallDelayed(2f, () => Methods.AddEffect(ev.Player, speedBoost));
        }
    }
}
