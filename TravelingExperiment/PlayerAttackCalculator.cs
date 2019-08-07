using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class PlayerAttackCalculator
    {
        public static void CalculatePlayerAttack(GameContext gameContext)
        {
            gameContext.Player.Attack = (gameContext.Player.CurrentWeaponDamage) * (gameContext.Player.WeaponSkill);
            gameContext.Player.BaseAttack = (gameContext.Player.Level) * (10);
        }
    }
}
