using System;

using CelestialTravels0_1.GameContexts;

namespace CelestialTravels0_1.Players
{
    public class PlayerAttackCalculator
    {
        public static void CalculatePlayerAttack(GameContext gameContext)
        {
            gameContext.Player.Attack = gameContext.Player.WeaponDamageCurrent * gameContext.Player.WeaponSkill;
            gameContext.Player.BaseAttack = gameContext.Player.Level * 10;
        }
    }
}
