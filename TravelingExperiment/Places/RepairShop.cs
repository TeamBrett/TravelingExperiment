using System;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.UserInterface;
using CelestialTravels0_1.Verifications;

namespace CelestialTravels0_1.Places
{
    public class RepairShop
    {
        public void Repair(GameContext gameContext)
        {
            while (true)
            {
                // Heal Player
                Console.WriteLine();
                Console.WriteLine(gameContext.Player.Name + " fully healed");
                Console.WriteLine();
                gameContext.Player.HitPointsCurrent = gameContext.Player.HitPointsTotal;

                // Repair Weapons
                Console.WriteLine(@"Choose which weapon to repair (enter the number).  Or type ""exit"" to exit.");
                gameContext.Inventory.EunumerateWeapons(gameContext);
                string tempUserInput;
                int chosenWeaponToRepair;
                tempUserInput = Console.ReadLine();

                if (tempUserInput == "exit")
                {
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                }
                else if (tempUserInput == "drop")
                {
                    gameContext.Store.DropWeapon(gameContext);
                }
                else
                {
                    chosenWeaponToRepair = new InteractionService().GetUserInputForNumberedOptionMenu(tempUserInput, gameContext.List.WeaponList.Count);

                    // Verify player has enough credits
                    var price = gameContext.List.WeaponList[chosenWeaponToRepair].DurabilityMax - gameContext.List.WeaponList[chosenWeaponToRepair].DurabilityCurrent;

                    if (new Verify().HasEnoughMoneyToPurchase(gameContext, price))
                    {
                        gameContext.List.WeaponList[chosenWeaponToRepair].DurabilityCurrent = gameContext.List.WeaponList[chosenWeaponToRepair].DurabilityMax;
                        Console.WriteLine();
                        Console.WriteLine(gameContext.List.WeaponList[chosenWeaponToRepair].Name + " has been repaired");
                        StandardMessages.ReturnToContinue();
                    }
                }
            }
        }
    }
}
