using System;

using CelestialTravels0_1.Consumables;
using CelestialTravels0_1.GameContexts;


namespace CelestialTravels0_1.Places
{
    public class Store
    {
        public void StoreOptions(GameContext gameContext)
        {
            gameContext.Player.Credits = 500000;
            string playerInput;
            int playerSelection;

            Console.WriteLine();
            Console.WriteLine("Welcome to the store");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0) Consumables Department");
            Console.WriteLine("1) Weapons Department");
            Console.WriteLine("2) Exit Store");
            Console.WriteLine();
            Console.WriteLine(@"Please select a department, or ""exit"" to leave the store");
            Console.WriteLine();
            playerInput = Console.ReadLine();

            // Input verification and exit.
            while(true)
            {
                if(int.TryParse(playerInput, out playerSelection))
                {
                    if(playerSelection >= 0 && playerSelection <=2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and 2");
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }

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
                        gameContext.SpacePort.SpacePortOptions(gameContext);
                        break;
                    }
            }
        }



        public void ConsumablesDepartment(GameContext gameContext)
        {
            string playerInput;
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
            Console.WriteLine(@"Please select a consumable, or ""exit"" to leave the department");


            while (true)
            {
                
                Console.WriteLine();
                playerInput = Console.ReadLine();
                if (int.TryParse(playerInput, out playerSelection))
                {
                    if (playerSelection >= 0 && playerSelection <= 7)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (7));
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }




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
                        gameContext.Store.ConsumablesDepartment(gameContext);
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
            string playerInput;
            int playerSelection;

            Console.WriteLine();
            Console.WriteLine("Welcome to the Weapons Department");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"0) Blaster (Costs " + gameContext.Blaster.Price + " Credits)");
            Console.WriteLine(@"1) Double Blaster (Costs " + gameContext.DoubleBlaster.Price + " Credits)");
            Console.WriteLine(@"2) Photon Sword (Costs " + gameContext.PhotonSword.Price + " Credits)");
            Console.WriteLine("3) Exit the store");
            Console.WriteLine();
            Console.WriteLine(@"Please select a consumable, or ""exit"" to leave the store");


            while (true)
            {

                Console.WriteLine();
                playerInput = Console.ReadLine();
                if (int.TryParse(playerInput, out playerSelection))
                {
                    if (playerSelection >= 0 && playerSelection <= 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (3));
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }

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
                        // Exit Department
                        gameContext.Store.StoreOptions(gameContext);

                        break;
                    }
            }
        gameContext.Store.WeaponsDepartment(gameContext);

        }
    }
}
