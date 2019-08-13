using System;

using CelestialTravels0_1.Consumables;
using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Verifications;


namespace CelestialTravels0_1.Places
{
    public class Store
    {
        public void StoreOptions(GameContext gameContext)
        {
            gameContext.Player.Credits = 500000;
            string tempUserInput;
            int playerSelection;

            Console.WriteLine();
            Console.WriteLine("Welcome to the store");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0) Consumables Department");
            Console.WriteLine("1) Weapons Department");
            Console.WriteLine("2) Exit Store");
            Console.WriteLine();
            Console.WriteLine(@"Please select a department");
            Console.WriteLine();
            tempUserInput = Console.ReadLine();

            // Input verification and exit.

            playerSelection = Verify.UserInputForNumberedOptionMenu(tempUserInput, 3);


            switch(playerSelection)
            {
                case 0:
                    {
                        // Consumables 
                        gameContext.Store.ConsumablesDepartment(gameContext);

                        break;
                    }
                case 1:
                    {
                        // Weapons
                        gameContext.Store.WeaponsDepartment(gameContext);

                        break;
                    }
                case 2:
                    {
                        // Exit
                        gameContext.SpacePort.SpacePortOptions(gameContext);
                        break;
                    }
            }
        }



        public void ConsumablesDepartment(GameContext gameContext)
        {
            string tempUserInput;
            int playerSelection;

            Console.WriteLine();
            Console.WriteLine("Welcome to the Consumables Department");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"0) Small Health Kit (Restores 50 HP, Costs 100 Credits)");
            Console.WriteLine(@"1) Large Health Kit (Restores 100 HP, Costs 250 Credits)");
            Console.WriteLine(@"2) Total Health Kit (Restores ALL HP, Costs 1,000 Credits)");
            Console.WriteLine(@"3) Small Energy Kit (Restores 50 Engy, Costs 100 Credits)");
            Console.WriteLine(@"4) Large Energy Kit (Restores 100 Engy, Costs 250 Credits)");
            Console.WriteLine(@"5) Total Energy Kit (Restores ALL Engy, Costs 1,000 Credits)");
            Console.WriteLine(@"6) Smoke Grenade (Allows you to leave the instance while in Battle, Costs 2,000)");
            Console.WriteLine("7) Exit the store");
            Console.WriteLine();
            Console.WriteLine(@"Please select a consumable");
            tempUserInput = Console.ReadLine();

            playerSelection = Verify.UserInputForNumberedOptionMenu(tempUserInput, 8);

            switch (playerSelection)
            {
                
                case 0:
                    {
                        gameContext.Store.BuyConsumable(gameContext, gameContext.HealthKitSmall);

                        break;
                    }
                case 1:
                    {
                        gameContext.Store.BuyConsumable(gameContext, gameContext.HealthKitLarge);

                        break;
                    }
                case 2:
                    {

                        gameContext.Store.BuyConsumable(gameContext, gameContext.HealthKitTotal);

                        break;
                    }
                case 3:
                    {
                        gameContext.Store.BuyConsumable(gameContext, gameContext.EnergyKitSmall);

                        break;
                    }
                case 4:
                    {
                        gameContext.Store.BuyConsumable(gameContext, gameContext.EnergyKitLarge);

                        break;
                    }
                case 5:
                    {
                        gameContext.Store.BuyConsumable(gameContext, gameContext.EnergyKitTotal);

                        break;
                    }
                case 6:
                    {
                        gameContext.Store.BuyConsumable(gameContext, gameContext.SmokeGrenade);

                        break;
                    }
                case 7:
                    {
                        gameContext.Store.StoreOptions(gameContext);
                        break;
                    }
            }

        }

        public void BuyConsumable(GameContext gameContext, Consumable consumable)
        {
            
            int quantitySelection;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("How many " + consumable.Name + " would you like");
                var quantityInput = Console.ReadLine();

                if (int.TryParse(quantityInput, out quantitySelection))
                {
                    if (quantitySelection > 0)
                    {
                        if (gameContext.Player.Credits > (quantitySelection * consumable.Price))
                        {
                            gameContext.Player.Credits -= (quantitySelection * consumable.Price);
                            gameContext.Player.HealthKitSmallCount += quantitySelection;

                            Console.WriteLine();
                            Console.WriteLine($"You bought " + quantitySelection + " " + consumable.Name + " for " + (quantitySelection * consumable.Price) + " Credits");
                            Console.WriteLine();
                            StandardMessages.ReturnToContinue();

                            gameContext.Store.ConsumablesDepartment(gameContext);

                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer greater than zero");
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }
        }

        public void WeaponsDepartment(GameContext gameContext)
        {
            string tempUserInput;
            int playerSelection;

            Console.WriteLine();
            Console.WriteLine("Welcome to the Weapons Department");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"0) Blaster (Costs " + gameContext.Blaster.Price + " Credits)");
            Console.WriteLine(@"1) Double Blaster (Costs " + gameContext.DoubleBlaster.Price + " Credits)");
            Console.WriteLine(@"2) Photon Sword (Costs " + gameContext.PhotonSword.Price + " Credits)");
            Console.WriteLine(@"3) Drop a weapon");
            Console.WriteLine("4) Exit the store");
            Console.WriteLine();
            Console.WriteLine(@"Please select a weapon");
            tempUserInput = Console.ReadLine();

            playerSelection = Verify.UserInputForNumberedOptionMenu(tempUserInput, 5);



            switch (playerSelection)
            {

                case 0:
                    {
                        // Create Blaster
                        gameContext.WeaponMaker.CreateWeaponBlaster(gameContext);

                        break;
                    }
                case 1:
                    {
                        // Create Double Blaster
                        gameContext.WeaponMaker.CreateWeaponDoubleBlaster(gameContext);
                        break;
                    }
                case 2:
                    {
                        // Create Photon Sword
                        gameContext.WeaponMaker.CreateWeaponPhotonSword(gameContext);
                        break;
                    }
                case 3:
                    {
                        // Drop Weapon
                        gameContext.Store.DropWeapon(gameContext);

                        break;
                    }
                case 4:
                    {
                        // Exit Department
                        gameContext.Store.StoreOptions(gameContext);

                        break;
                    }
            }
            gameContext.Store.WeaponsDepartment(gameContext);

        }

        public void DropWeapon(GameContext gameContext)
        {
            Console.WriteLine(@"Choose which weapon to drop (enter the number).  Or type ""exit"" to exit.");
            gameContext.Inventory.EunumerateWeapons(gameContext);

            var tempUserInput = Console.ReadLine();

            var ChosenWeaponToDrop = Verify.UserInputForNumberedOptionMenuWithExit(gameContext, tempUserInput, gameContext.List.WeaponList.Count);

            gameContext.List.WeaponList.RemoveAt(ChosenWeaponToDrop);
        }
    }
}
