using System;

using CelestialTravels0_1.Bases;
using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Players;
using CelestialTravels0_1.Verifications;


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
                // Choose Spell or Weapon
                if(attacker == gameContext.Player)
                {
                    ChooseSpellOrWeapon(gameContext, attacker, defender);
                }
                else // Computer's attack turn
                {
                    // Rolling
                    attacker.Roll = gameContext.Roller.GetRandomNumber(1, 12);
                    Console.WriteLine("attacker's roll " + attacker.Roll + "\n");

                    // Calculate Damage
                    var damage = (attacker.Roll / 10) * attacker.Attack;
                    Console.WriteLine("Damage " + (damage) + "\n");

                    // Apply damage to defender
                    defender.HitPointsCurrent = defender.HitPointsCurrent - damage;
                    Console.WriteLine("Defender's HP  " + defender.HitPointsCurrent + "\n");
                    StandardMessages.ReturnToContinue();
                }
                

                

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
                gameContext.Player.XP += looser.HitPointsTotal / 2;
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
                Console.WriteLine();

            }
        }

        public void ChooseWeaponToAttackWith(Character attacker, GameContext gameContext)
        {
                
                gameContext.PlayerInventory.EunumerateWeapons(gameContext);
                Console.WriteLine("Choose which weapon to attack with (enter the number) ");
                int chosenWeaponToAttackWith;
                var tempUserInput = Console.ReadLine();

                chosenWeaponToAttackWith = Verify.UserInputForNumberedOptionMenu(tempUserInput, gameContext.List.WeaponList.Count);

                gameContext.Player.WeaponDamageCurrent = gameContext.List.WeaponList[chosenWeaponToAttackWith].Attack;

                PlayerAttackCalculator.CalculatePlayerAttack(gameContext);

                gameContext.List.WeaponList[chosenWeaponToAttackWith].DurabilityCurrent -= 1;
        }

        public void ChooseSpellOrWeapon(GameContext gameContext, Character attacker, Character defender)
        {
            Console.WriteLine("0) Use a Spell");
            Console.WriteLine("1) Attack with a Weapon");
            Console.WriteLine("2) Use a Consumable");
            Console.WriteLine();
            Console.WriteLine("Please select an action using its number");
            var tempUserInput = Console.ReadLine();

            var playerSelection = Verify.UserInputForNumberedOptionMenu(tempUserInput, 3);

            switch(playerSelection)
            {
                case 0:
                    {
                        // Use Spell
                        gameContext.PlayerInventory.EnumerateSpells(gameContext);
                        Console.WriteLine("Choose a spell to use (Enter the number)");
                        tempUserInput = Console.ReadLine();
                        var chosenSpellToAttackWith = Verify.UserInputForNumberedOptionMenu(tempUserInput, gameContext.List.SpellList.Count);

                        // THIS IS GOING TO NEED TO BE FLESHED OUT  
                        gameContext.VirtualGun.Use(gameContext);

                    }
                case 1:
                    {
                        // Attack with Weapon

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
                        StandardMessages.ReturnToContinue();

                        break;
                    }
                case 2:
                    {
                        // Use a Consumable
                    }
            }
        }
    }
}
