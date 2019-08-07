using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class PlayerAttackCalculator
    {
        public static void CalculatePlayerAttack(GameContext gameContext)
        {
            gameContext.Player.Attack = (gameContext.Player.CurrentWeaponDamage) * (gameContext.Player.WeaponSkill);
        }
    }
}
