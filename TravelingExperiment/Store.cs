using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class Store
    {
        public void StoreOptions(GameContext gameContext)
        {
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
                        break;
                    }
                case 1:
                    {
                        // Weapons
                        break;
                    }
                case 2:
                    {
                        gameContext.SpacePort.SpacePortOptions(gameContext);
                        break;
                    }
            }
        }



        public void ConsumablesStore(GameContext gameContext)
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
            Console.WriteLine(@"Please select a department, or ""exit"" to leave the store");
            Console.WriteLine();
            playerInput = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(playerInput, out playerSelection))
                {
                    if (playerSelection > 0 && playerSelection <= 7)
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


            string quantityInput;


            switch (playerSelection)
            {
                
                case 0:
                    {


                        Console.WriteLine("How many Small Health Kits would you like");
                        quantityInput = Console.ReadLine();

                        gameContext.Store.BuyConsumable(gameContext, gameContext.HealthKitSmall, quantityInput);

                        //while (true)
                        //{
                        //    if (int.TryParse(quantityInput, out quantitySelection))
                        //    {
                        //        if (quantitySelection > 0)
                        //        {
                        //            if(gameContext.Player.Credits > (quantitySelection * gameContext.HealthKitSmall.Price))
                        //            {
                        //                gameContext.Player.Credits -= (quantitySelection * gameContext.HealthKitSmall.Price);
                        //                gameContext.Player.HealthKitSmallCount += quantitySelection;

                        //                Console.WriteLine();
                        //                Console.WriteLine($"You bought " + quantitySelection + " for " + (quantitySelection * gameContext.HealthKitSmall.Price) + " Credits");
                        //                Console.WriteLine();

                        //                gameContext.Store.ConsumablesStore(gameContext);

                        //                break;
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("please enter an integer greater than zero");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Input is not valid, try entering an integer");
                        //    }
                        //}
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("How many Large Health Kits would you like");
                        quantityInput = Console.ReadLine();

                        gameContext.Store.BuyConsumable(gameContext, gameContext.HealthKitLarge, quantityInput);


                        //while (true)
                        //{
                        //    if (int.TryParse(quantityInput, out quantitySelection))
                        //    {
                        //        if (quantitySelection > 0)
                        //        {
                        //            if (gameContext.Player.Credits > (quantitySelection * gameContext.HealthKitLarge.Price))
                        //            {
                        //                gameContext.Player.Credits -= (quantitySelection * gameContext.HealthKitLarge.Price);
                        //                gameContext.Player.HealthKitLargeCount += quantitySelection;

                        //                Console.WriteLine();
                        //                Console.WriteLine($"You bought " + quantitySelection + " for " + (quantitySelection * gameContext.HealthKitLarge.Price) + " Credits");
                        //                Console.WriteLine();

                        //                gameContext.Store.ConsumablesStore(gameContext);

                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("please enter an integer greater than zero");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Input is not valid, try entering an integer");
                        //    }
                        //}
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("How many Total Health Kits would you like");
                        quantityInput = Console.ReadLine();

                        gameContext.Store.BuyConsumable(gameContext, gameContext.HealthKitTotal, quantityInput);

                        //while (true)
                        //{
                        //    if (int.TryParse(quantityInput, out quantitySelection))
                        //    {
                        //        if (quantitySelection > 0)
                        //        {
                        //            if (gameContext.Player.Credits > (quantitySelection * gameContext.HealthKitTotal.Price))
                        //            {
                        //                gameContext.Player.Credits -= (quantitySelection * gameContext.HealthKitTotal.Price);
                        //                gameContext.Player.HealthKitTotalCount += quantitySelection;

                        //                Console.WriteLine();
                        //                Console.WriteLine($"You bought " + quantitySelection + " for " + (quantitySelection * gameContext.HealthKitTotal.Price) + " Credits");
                        //                Console.WriteLine();

                        //                gameContext.Store.ConsumablesStore(gameContext);

                        //                break;
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("please enter an integer greater than zero");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Input is not valid, try entering an integer");
                        //    }
                        //}
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("How many Small Energy Kits would you like");
                        quantityInput = Console.ReadLine();

                        gameContext.Store.BuyConsumable(gameContext, gameContext.EnergyKitSmall, quantityInput);

                        //while (true)
                        //{
                        //    if (int.TryParse(quantityInput, out quantitySelection))
                        //    {
                        //        if (quantitySelection > 0)
                        //        {
                        //            if (gameContext.Player.Credits > (quantitySelection * gameContext.EnergyKitSmall.Price))
                        //            {
                        //                gameContext.Player.Credits -= (quantitySelection * gameContext.EnergyKitSmall.Price);
                        //                gameContext.Player.EnergyKitSmallCount += quantitySelection;

                        //                Console.WriteLine();
                        //                Console.WriteLine($"You bought " + quantitySelection + " for " + (quantitySelection * gameContext.EnergyKitSmall.Price) + " Credits");
                        //                Console.WriteLine();

                        //                gameContext.Store.ConsumablesStore(gameContext);

                        //                break;
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("please enter an integer greater than zero");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Input is not valid, try entering an integer");
                        //    }
                        //}
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("How many Large Energy Kits would you like");
                        quantityInput = Console.ReadLine();

                        gameContext.Store.BuyConsumable(gameContext, gameContext.EnergyKitLarge, quantityInput);

                        //while (true)
                        //{
                        //    if (int.TryParse(quantityInput, out quantitySelection))
                        //    {
                        //        if (quantitySelection > 0)
                        //        {
                        //            if (gameContext.Player.Credits > (quantitySelection * gameContext.EnergyKitLarge.Price))
                        //            {
                        //                gameContext.Player.Credits -= (quantitySelection * gameContext.EnergyKitLarge.Price);
                        //                gameContext.Player.EnergyKitLargeCount += quantitySelection;

                        //                Console.WriteLine();
                        //                Console.WriteLine($"You bought " + quantitySelection + " for " + (quantitySelection * gameContext.EnergyKitLarge.Price) + " Credits");
                        //                Console.WriteLine();

                        //                gameContext.Store.ConsumablesStore(gameContext);

                        //                break;
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("please enter an integer greater than zero");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Input is not valid, try entering an integer");
                        //    }
                        //}
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("How many Total Energy Kits would you like");
                        quantityInput = Console.ReadLine();

                        gameContext.Store.BuyConsumable(gameContext, gameContext.EnergyKitTotal, quantityInput);

                        //while (true)
                        //{
                        //    if (int.TryParse(quantityInput, out quantitySelection))
                        //    {
                        //        if (quantitySelection > 0)
                        //        {
                        //            if (gameContext.Player.Credits > (quantitySelection * gameContext.EnergyKitTotal.Price))
                        //            {
                        //                gameContext.Player.Credits -= (quantitySelection * gameContext.EnergyKitTotal.Price);
                        //                gameContext.Player.EnergyKitTotalCount += quantitySelection;

                        //                Console.WriteLine();
                        //                Console.WriteLine($"You bought " + quantitySelection + " for " + (quantitySelection * gameContext.EnergyKitTotal.Price) + " Credits");
                        //                Console.WriteLine();

                        //                gameContext.Store.ConsumablesStore(gameContext);

                        //                break;
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("please enter an integer greater than zero");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Input is not valid, try entering an integer");
                        //    }
                        //}
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("How many Smoke Grenades would you like");
                        quantityInput = Console.ReadLine();

                        gameContext.Store.BuyConsumable(gameContext, gameContext.SmokeGrenade, quantityInput);

                        //while (true)
                        //{
                        //    if (int.TryParse(quantityInput, out quantitySelection))
                        //    {
                        //        if (quantitySelection > 0)
                        //        {
                        //            if (gameContext.Player.Credits > (quantitySelection * gameContext.SmokeGrenade.Price))
                        //            {
                        //                gameContext.Player.Credits -= (quantitySelection * gameContext.SmokeGrenade.Price);
                        //                gameContext.Player.SmokeGrenadeCount += quantitySelection;

                        //                Console.WriteLine();
                        //                Console.WriteLine($"You bought " + quantitySelection + " for " + (quantitySelection * gameContext.SmokeGrenade.Price) + " Credits");
                        //                Console.WriteLine();

                        //                gameContext.Store.ConsumablesStore(gameContext);

                        //                break;
                        //            }
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("please enter an integer greater than zero");
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("Input is not valid, try entering an integer");
                        //    }
                        //}
                        break;
                    }
                case 7:
                    {
                        gameContext.SpacePort.SpacePortOptions(gameContext);
                        break;
                    }
            }
        }

        public void BuyConsumable(GameContext gameContext, Consumable consumable, string quantityInput)
        {
            int quantitySelection;

            while (true)
            {
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

                            gameContext.Store.ConsumablesStore(gameContext);

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
    }
}
