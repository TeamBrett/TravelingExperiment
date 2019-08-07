using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class MonsterMaker
    {
        public Monster CreateWhiteMonster(GameContext gameContext)
        {
            Monster whiteMonster = new Monster();


            {
                whiteMonster.Name = "White Monster";
                whiteMonster.Level = gameContext.Player.Level;
                whiteMonster.Attack = (gameContext.Player.Attack - (gameContext.Player.Attack / 2));
                whiteMonster.CurrentHitPoints = (gameContext.Player.TotalHitPoints - (gameContext.Player.TotalHitPoints / 2));
                whiteMonster.TotalHitPoints = (gameContext.Player.TotalHitPoints - (gameContext.Player.TotalHitPoints / 2));
            }
            return whiteMonster;
        }

        public Monster CreateGreenMonster(GameContext gameContext)
        {
            Monster greenMonster = new Monster();
            {
                greenMonster.Name = "Green Monster";
                greenMonster.Level = gameContext.Player.Level;
                greenMonster.Attack = (gameContext.Player.Attack - (gameContext.Player.Attack / 2));
                greenMonster.CurrentHitPoints = (gameContext.Player.TotalHitPoints);
                greenMonster.TotalHitPoints = (gameContext.Player.TotalHitPoints);
            }
            return greenMonster;
        }

        public Monster CreateRedMonster(GameContext gameContext)
        {
            Monster redMonster = new Monster();
            {
                redMonster.Name = "Red Monster";
                redMonster.Level = gameContext.Player.Level;
                redMonster.Attack = (gameContext.Player.Attack - (gameContext.Player.Attack / 2));
                redMonster.CurrentHitPoints = (gameContext.Player.TotalHitPoints + (gameContext.Player.TotalHitPoints / 2));
                redMonster.TotalHitPoints = (gameContext.Player.TotalHitPoints + (gameContext.Player.TotalHitPoints / 2));
            }
            return redMonster;
        }
    }
}
