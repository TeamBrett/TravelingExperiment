using System;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Players;

namespace CelestialTravels0_1.Monsters
{
    public class MonsterMaker
    {
        public Monster CreateWhiteMonster(GameContext gameContext)
        {
            PlayerAttackCalculator.CalculatePlayerAttack(gameContext);

            Monster whiteMonster01 = new Monster
            {
                Name = "White Monster",
                Level = gameContext.Player.Level,
                Attack = gameContext.Player.BaseAttack - (gameContext.Player.BaseAttack / 2),
                HitPointsCurrent = gameContext.Player.HitPointsTotal - (gameContext.Player.HitPointsTotal / 2),
                HitPointsTotal = gameContext.Player.HitPointsTotal - (gameContext.Player.HitPointsTotal / 2),
            };
            return whiteMonster01;
        }

        public Monster CreateGreenMonster(GameContext gameContext)
        {
            PlayerAttackCalculator.CalculatePlayerAttack(gameContext);

            Monster greenMonster01 = new Monster
            {
                Name = "Green Monster",
                Level = gameContext.Player.Level,
                Attack = gameContext.Player.Attack - (gameContext.Player.Attack / 2),
                HitPointsCurrent = gameContext.Player.HitPointsTotal,
                HitPointsTotal = gameContext.Player.HitPointsTotal,
            };

            return greenMonster01;
        }

        public Monster CreateRedMonster(GameContext gameContext)
        {
            PlayerAttackCalculator.CalculatePlayerAttack(gameContext);

            Monster redMonster01 = new Monster
            {
                Name = "Red Monster",
                Level = gameContext.Player.Level,
                Attack = gameContext.Player.Attack - (gameContext.Player.Attack / 2),
                HitPointsCurrent = gameContext.Player.HitPointsTotal + (gameContext.Player.HitPointsTotal / 2),
                HitPointsTotal = gameContext.Player.HitPointsTotal + (gameContext.Player.HitPointsTotal / 2),
            };

            return redMonster01;
        }
    }
}
