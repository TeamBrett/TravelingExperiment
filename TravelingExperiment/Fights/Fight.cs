using System;

using CelestialTravels0_1.Bases;
using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Players;


namespace CelestialTravels0_1.Fights

{
    public class Fight
    {
        public void DoFight(GameContext gameContext)
        {
            PlayerAttackCalculator.CalculatePlayerAttack(gameContext);

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
                defender.HitPointsCurrent = defender.HitPointsCurrent - damage;
                Console.WriteLine("Defender's HP  " + defender.HitPointsCurrent + "\n");
                Console.WriteLine("Return to continue");
                Console.ReadLine();

                // End fight and declare winner or switch roles 
                if (defender.HitPointsCurrent <= 0)
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
                gameContext.Player.Experience += looser.HitPointsTotal;
                gameContext.Player.HitPointsCurrent = gameContext.Player.HitPointsTotal;


                Console.WriteLine("YOU ARE A WINNER");
                Console.WriteLine("You received " + looser.HitPointsTotal + " Experience Points.");
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
                Console.WriteLine("player health   " + attacker.HitPointsCurrent);
                Console.WriteLine("monster health   " + defender.HitPointsCurrent);


            }
            else
            {
                attacker = gameContext.WhiteMonster01;
                defender = gameContext.Player;
                Console.WriteLine("Monster wins the toss and is the Attacker");
                Console.WriteLine("player health   " + defender.HitPointsCurrent);
                Console.WriteLine("Monster health   " + attacker.HitPointsCurrent);
                Console.WriteLine("");

            }
        }

        public void ChooseWeaponToAttackWith(Character attacker, GameContext gameContext)
        {
            if (attacker == gameContext.Player)
            {
                Console.WriteLine("Choose which weapon to attack with (enter the number) ");
                gameContext.PlayerInventory.EunumerateWeapons(gameContext);
                int ChosenWeaponToAttackWith;
                while(true)
                {
                    if (int.TryParse(Console.ReadLine(), out ChosenWeaponToAttackWith))
                    {
                        if (ChosenWeaponToAttackWith >= 0 && ChosenWeaponToAttackWith < gameContext.List.WeaponList.Count)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("please enter an integer between zero and " + (gameContext.List.WeaponList.Count - 1));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input is not valid, try entering an integer");
                    }
                }
                

                gameContext.Player.WeaponDamageCurrent = gameContext.List.WeaponList[ChosenWeaponToAttackWith].Attack;

                PlayerAttackCalculator.CalculatePlayerAttack(gameContext);

                gameContext.List.WeaponList[ChosenWeaponToAttackWith].DurabilityCurrent -= 1;
            }

        }
    }
}
