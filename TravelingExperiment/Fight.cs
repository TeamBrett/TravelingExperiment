using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class Fight
    {
        public void DoFight(GameContext gameContext)
        {
            var monster = gameContext.WhiteMonster01;
            var fightOver = false;
            Character winner = gameContext.Player;
            Character looser = gameContext.Player;




            PreBattleRoll(gameContext, out Character attacker, out Character defender);


            while (fightOver == false)
            {
                // Select Weapon
                ChooseWeaponToAttackWith(attacker, gameContext);


                // Rolling
                attacker.Roll = gameContext.Roller.GetRandomNumber(1, 12);
                Console.WriteLine("attacker's roll " + attacker.Roll + "\n");

                // Calculate Damage
                var damage = (attacker.Roll / 10) * attacker.Attack;
                Console.WriteLine("Damage " + (damage) + "\n");

                // Apply damage to defender
                defender.CurrentHitPoints = defender.CurrentHitPoints - damage;
                Console.WriteLine("Defender's HP  " + defender.CurrentHitPoints + "\n");
                Console.ReadLine();

                // End fight and declare winner or switch roles 
                if (defender.CurrentHitPoints <= 0)
                {
                    // End the fight
                    fightOver = true;
                    winner = attacker;
                    looser = defender;
                }
                else
                {
                    // Switch roles
                    var temporaryCharacter = attacker;
                    attacker = defender;
                    defender = temporaryCharacter;

                    Console.WriteLine("the Attacker is now " + attacker.Name + "\n");
                }

            }

            // Post battle stuff.
            if (winner.Name == gameContext.Player.Name)
            {
                gameContext.Player = (Player)winner;
                gameContext.Player.Experience += looser.TotalHitPoints;
                gameContext.Player.CurrentHitPoints = gameContext.Player.TotalHitPoints;


                Console.WriteLine("YOU ARE A WINNER");
                Console.WriteLine("You received " + looser.TotalHitPoints + " Experience Points.");
                gameContext.PlayerStats.PrintPlayerStats(gameContext);
            }
            else
            {
                gameContext.Player = (Player)looser;



                Console.WriteLine("YOU ARE A LOOSER!");
            }

        }






        public static void PreBattleRoll(GameContext gameContext, out Character attacker, out Character defender)
        {
            gameContext.Player.Roll = gameContext.Roller.GetRandomNumber(1, 100);
            gameContext.WhiteMonster01.Roll = gameContext.Roller.GetRandomNumber(1, 100);

            if (gameContext.Player.Roll > gameContext.WhiteMonster01.Roll)
            {
                attacker = gameContext.Player;
                defender = gameContext.WhiteMonster01;
                Console.WriteLine("Player wins the toss and is the Attacker");
                Console.WriteLine("player health   " + gameContext.Player.CurrentHitPoints);
                Console.WriteLine("monster health   " + defender.CurrentHitPoints);

            }
            else
            {
                attacker = gameContext.WhiteMonster01;
                defender = gameContext.Player;
                Console.WriteLine("Monster wins the toss and is the Attacker");
                Console.WriteLine("player health   " + gameContext.Player.CurrentHitPoints);
                Console.WriteLine("Monster health   " + attacker.CurrentHitPoints);
                Console.WriteLine("");

            }
        }

        public void ChooseWeaponToAttackWith(Character attacker, GameContext gameContext)
        {
            if (attacker == gameContext.Player)
            {
                Console.WriteLine("Choose which weapon to attack with (enter the number) ");
                gameContext.PlayerInventory.EunumerateWeapons();
                var TempChosenWeaponToAttackWith = Console.ReadLine();

                // Need to check if the input is an int or else it throws exeption when I type wrong.


                int ChosenWeaponToAttackWith = Convert.ToInt32(TempChosenWeaponToAttackWith);

                gameContext.Player.CurrentWeaponDamage = gameContext.PlayerInventory.WeaponList[ChosenWeaponToAttackWith].Attack;

                PlayerAttackCalculator.CalculatePlayerAttack(gameContext);

                gameContext.PlayerInventory.WeaponList[ChosenWeaponToAttackWith].Durability -= 1;
            }

        }
    }
}
