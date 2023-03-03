using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomPlayerEffects;
using Exiled.API.Features;
using Exiled.CustomRoles.API;
using Exiled.CustomRoles.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace SCPSpeedBoost
{
    public static class Methods
    {
        public static void AddEffect(Player player, byte intensity)
        {
            player.EnableEffect<MovementBoost>();
            player.ChangeEffectIntensity<MovementBoost>(intensity);
        }
    }

}
