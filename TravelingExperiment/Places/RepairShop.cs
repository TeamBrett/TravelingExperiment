using System;

using CelestialTravels0_1.GameContexts;
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
                int ChosenWeaponToRepair;
                tempUserInput = Console.ReadLine();

                if (tempUserInput == "exit")
                {
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                }
                else
                {
                    ChosenWeaponToRepair = Verify.UserInputForNumberedOptionMenu(gameContext.List.WeaponList.Count);

                    // Verify player has enough credits
                    var price = gameContext.List.WeaponList[ChosenWeaponToRepair].DurabilityMax - gameContext.List.WeaponList[ChosenWeaponToRepair].DurabilityCurrent;

                    if(Verify.HasEnoughMoneyToPurchase(gameContext, price))
                    {
                        gameContext.List.WeaponList[ChosenWeaponToRepair].DurabilityCurrent = gameContext.List.WeaponList[ChosenWeaponToRepair].DurabilityMax;
                        Console.WriteLine();
                        Console.WriteLine(gameContext.List.WeaponList[ChosenWeaponToRepair].Name + " has been repaired");
                        StandardMessages.ReturnToContinue();
                    }
                }
            }
        }
    }
}
