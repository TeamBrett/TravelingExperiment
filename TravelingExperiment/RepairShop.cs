using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class RepairShop
    {


        public void Repair(GameContext gameContext)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(gameContext.Player.Name + " fully healed");
                Console.WriteLine();
                gameContext.Player.HitPointsCurrent = gameContext.Player.HitPointsTotal;
                Console.WriteLine(@"Choose which weapon to repair (enter the number).  Or type ""exit"" to exit.");
                gameContext.PlayerInventory.EunumerateWeapons();
                string tempUserInput;
                int ChosenWeaponToRepair;
                tempUserInput = Console.ReadLine();

                if (tempUserInput == "exit")
                {
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                }
                else
                {
                    //Checks to see if the input is an int
                    if (int.TryParse(tempUserInput, out ChosenWeaponToRepair)) 
                    {
                        // Checks that the user input is a valid int.
                        if (ChosenWeaponToRepair >= 0 && ChosenWeaponToRepair < gameContext.PlayerInventory.WeaponList.Count) 
                        {
                            // Checks that the player has enough Credits to buy the repair.
                            if(gameContext.PlayerInventory.WeaponList[ChosenWeaponToRepair].DurabilityMax - gameContext.PlayerInventory.WeaponList[ChosenWeaponToRepair].DurabilityCurrent <= gameContext.Player.Credits)
                            {
                                gameContext.Player.Credits -= gameContext.PlayerInventory.WeaponList[ChosenWeaponToRepair].DurabilityMax - gameContext.PlayerInventory.WeaponList[ChosenWeaponToRepair].DurabilityCurrent;
                                gameContext.PlayerInventory.WeaponList[ChosenWeaponToRepair].DurabilityCurrent = gameContext.PlayerInventory.WeaponList[ChosenWeaponToRepair].DurabilityMax;
                                Console.WriteLine();
                                Console.WriteLine(gameContext.PlayerInventory.WeaponList[ChosenWeaponToRepair].Name + " has been repaired");
                            }
                            else
                            {
                                Console.WriteLine("You do not have enough Credits to repair this item.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("please enter an integer between zero and " + (gameContext.PlayerInventory.WeaponList.Count - 1));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input is not valid, try entering an integer");
                    }
                }
            }
        }
    }
}
