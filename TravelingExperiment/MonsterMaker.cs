using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class MonsterMaker
    {
        public Monster CreateWhiteMonster(GameContext gameContext)
        {
            PlayerAttackCalculator.CalculatePlayerAttack(gameContext);

            Monster whiteMonster01 = new Monster()
            {
                Name = "White Monster",
                Level = gameContext.Player.Level,
                Attack = (gameContext.Player.BaseAttack) - (gameContext.Player.BaseAttack / 2),
                CurrentHitPoints = (gameContext.Player.TotalHitPoints - (gameContext.Player.TotalHitPoints / 2)),
                TotalHitPoints = (gameContext.Player.TotalHitPoints - (gameContext.Player.TotalHitPoints / 2)),
            };
            return whiteMonster01;
        }

        public Monster CreateGreenMonster(GameContext gameContext)
        {
            Monster greenMonster01 = new Monster();
            {
                greenMonster01.Name = "Green Monster";
                greenMonster01.Level = gameContext.Player.Level;
                greenMonster01.Attack = (gameContext.Player.Attack - (gameContext.Player.Attack / 2));
                greenMonster01.CurrentHitPoints = (gameContext.Player.TotalHitPoints);
                greenMonster01.TotalHitPoints = (gameContext.Player.TotalHitPoints);
            }
            return greenMonster01;
        }

        public Monster CreateRedMonster(GameContext gameContext)
        {
            Monster redMonster01 = new Monster();
            {
                redMonster01.Name = "Red Monster";
                redMonster01.Level = gameContext.Player.Level;
                redMonster01.Attack = (gameContext.Player.Attack - (gameContext.Player.Attack / 2));
                redMonster01.CurrentHitPoints = (gameContext.Player.TotalHitPoints + (gameContext.Player.TotalHitPoints / 2));
                redMonster01.TotalHitPoints = (gameContext.Player.TotalHitPoints + (gameContext.Player.TotalHitPoints / 2));
            }
            return redMonster01;
        }
    }
}
