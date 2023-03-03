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

namespace SCPSpeedBoost
{
    // Event Handler class where all the events that are called are stored
    public static class EventHandlers
    {
        public static void ChangingRole(ChangingRoleEventArgs ev)
        {
            switch (ev.NewRole)
            {
                case RoleTypeId.Scp173:
                    Timing.CallDelayed(2f, () => Methods.AddEffect(ev.Player, Plugin.plugin.Config.SCP173Boost));
                    break;
                case RoleTypeId.Scp096:
                    Timing.CallDelayed(2f, () => Methods.AddEffect(ev.Player, Plugin.plugin.Config.SCP096Boost));
                    break;
                case RoleTypeId.Scp106:
                    Timing.CallDelayed(2f, () => Methods.AddEffect(ev.Player, Plugin.plugin.Config.SCP106Boost));
                    break;
                case RoleTypeId.Scp939:
                    Timing.CallDelayed(2f, () => Methods.AddEffect(ev.Player, Plugin.plugin.Config.SCP939Boost));
                    break;
                case RoleTypeId.Scp049:
                    Timing.CallDelayed(2f, () => Methods.AddEffect(ev.Player, Plugin.plugin.Config.SCP049Boost));
                    break;
                case RoleTypeId.Scp0492:
                    Timing.CallDelayed(2f, () => Methods.AddEffect(ev.Player, Plugin.plugin.Config.SCP0492Boost));
                    break;
                case RoleTypeId.Spectator:
                    ev.Player.DisableEffect(EffectType.MovementBoost);
                    break;

            }
        }
    }
}
