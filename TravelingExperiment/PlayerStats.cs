using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class PlayerStats
    {
        public void PrintPlayerStats(GameContext gameContext)
        {

            PlayerAttackCalculator.CalculatePlayerAttack(gameContext);
            Console.WriteLine($"NAME:...............{gameContext.Player.Name}");
            Console.WriteLine($"GENDER:.............{gameContext.Player.Gender}");
            Console.WriteLine($"RACE:...............{gameContext.Player.Race}");
            Console.WriteLine($"JOB:................{gameContext.Player.Job}");
            Console.WriteLine("");

            Console.WriteLine($"CREDITS:............{gameContext.Player.Credits}");
            Console.WriteLine($"EXPERIENCE:.........{gameContext.Player.Experience}");
            Console.WriteLine($"LEVEL:..............{gameContext.Player.Level}");
            Console.WriteLine("");

            Console.WriteLine($"CURRENT HIT POINTS..{gameContext.Player.CurrentHitPoints}");
            Console.WriteLine($"TOTAL HIT POINTS....{gameContext.Player.TotalHitPoints}");
            Console.WriteLine("");

            Console.WriteLine($"ATTACK:.............{gameContext.Player.Attack}");
            Console.WriteLine($"WEAPON SKILL:.......{gameContext.Player.WeaponSkill}");
            Console.WriteLine($"WEAPON DAMAGE.......{gameContext.Player.CurrentWeaponDamage}");
            Console.WriteLine("");

            Console.WriteLine($"ARMOR SKILL:........{gameContext.Player.ArmorSkill}");
            Console.WriteLine($"NAVIGATION SKILL:...{gameContext.Player.NavigationSkill}");
            Console.WriteLine($"TIME SKILL:.........{gameContext.Player.TimeSkill}");
        }
    }
}
