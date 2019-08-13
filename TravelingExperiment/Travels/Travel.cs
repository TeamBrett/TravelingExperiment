using System;
using System.Collections.Generic;
using System.Linq;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Places;


namespace CelestialTravels0_1.Travels
{
    public class Travel
    {
        public void TravelToSpacePort(GameContext gameContext)
        {
            List<SpacePort> query = gameContext.List.listSpacePort.Where(sp => sp.InSolarSystem == gameContext.Player.InSolarSystem).ToList();


            foreach (SpacePort sp in query)
            {
                Console.WriteLine(query.IndexOf(sp) + ") " + sp.Name);
            }

            // trying to add some verification logic to the user input
            int travelTo;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out travelTo))
                {
                    if (travelTo >= 0 && travelTo < query.Count)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (query.Count - 1));
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }

            gameContext.Player.SpacePortLocation = (query[travelTo].Name);

            Console.WriteLine(gameContext.Player.SpacePortLocation);

            gameContext.SpacePort.SpacePortOptions(gameContext);
        }

        public void TravelToJumpGateFromSpacePort(GameContext gameContext)
        {
            List<JumpGate> query = gameContext.List.listJumpGate.Where(sp => sp.InSolarSystem == gameContext.Player.InSolarSystem).ToList();


            foreach (JumpGate jg in query)
            {
                Console.WriteLine(query.IndexOf(jg) + ") " + jg.Name);
            }

            // trying to add some verification logic to the user input
            int travelTo;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out travelTo))
                {
                    if (travelTo >= 0 && travelTo < query.Count)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (query.Count - 1));
                    }
                }
                
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
                
                
            }

            gameContext.Player.JumpGateLocation = (query[travelTo].Name);

            Console.WriteLine(gameContext.Player.JumpGateLocation);

            gameContext.JumpGate.JumpGateOptions(gameContext);
        }

        public void TravelToJumpGateFromJumpGate(GameContext gameContext)
        {
            List<JumpGate> query = gameContext.List.listJumpGate.Where(sp => sp.InSolarSystem == gameContext.Player.InSolarSystem - 1 || sp.InSolarSystem == gameContext.Player.InSolarSystem || sp.InSolarSystem == gameContext.Player.InSolarSystem + 1).ToList();

            foreach (JumpGate jg in query)
            {
                Console.WriteLine(query.IndexOf(jg) + ") " + jg.Name);
            }

            int travelTo;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out travelTo))
                {
                    if (travelTo >= 0 && travelTo < query.Count)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (query.Count - 1));
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
                
            }

            gameContext.Player.JumpGateLocation = (query[travelTo].Name);
            gameContext.Player.InSolarSystem = (query[travelTo].InSolarSystem);

            Console.WriteLine(gameContext.Player.JumpGateLocation);

            gameContext.JumpGate.JumpGateOptions(gameContext);
        }

        public void TravelToInstance(GameContext gameContext)
        {
            List<Instance> query = gameContext.List.listInstance.Where(inst => inst.InSpacePort == gameContext.Player.SpacePortLocation).ToList();


            foreach (Instance inst in query)
            {
                Console.WriteLine(query.IndexOf(inst) + ") " + inst.Name);
            }

            // trying to add some verification logic to the user input
            int travelTo;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out travelTo))
                {
                    if (travelTo >= 0 && travelTo < query.Count)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (query.Count - 1));
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
                
            }

            gameContext.Player.InstanceLocation = (query[travelTo].Name);

            switch (gameContext.Player.InstanceLocation)
            {
                case "i1":
                    gameContext.Instance.Instance1(gameContext);
                    break;      
                case "i2":      
                    gameContext.Instance.Instance2(gameContext);
                    break;      
                case "i10":      
                    gameContext.Instance.Instance10(gameContext);
                    break;      
                case "i11":      
                    gameContext.Instance.Instance11(gameContext);
                    break;      
                case "i20":      
                    gameContext.Instance.Instance20(gameContext);
                    break;      
                case "i21":      
                    gameContext.Instance.Instance21(gameContext);
                    break;      
                case "i30":      
                    gameContext.Instance.Instance30(gameContext);
                    break;      
                case "i31":      
                    gameContext.Instance.Instance31(gameContext);
                    break;      
                case "i40":      
                    gameContext.Instance.Instance40(gameContext);
                    break;      
                case "i41":     
                    gameContext.Instance.Instance41(gameContext);
                    break;      
                case "i50":     
                    gameContext.Instance.Instance50(gameContext);
                    break;      
                case "i51":     
                    gameContext.Instance.Instance51(gameContext);
                    break;      
                case "i60":     
                    gameContext.Instance.Instance60(gameContext);
                    break;      
                case "i61":     
                    gameContext.Instance.Instance61(gameContext);
                    break;      
                case "i70":     
                    gameContext.Instance.Instance70(gameContext);
                    break;      
                case "i71":     
                    gameContext.Instance.Instance71(gameContext);
                    break;      
                case "i80":     
                    gameContext.Instance.Instance80(gameContext);
                    break;      
                case "i81":     
                    gameContext.Instance.Instance81(gameContext);
                    break;
            }
        }

        public void ReturnToSpacePortFromInstance(GameContext gameContext)
        {
            Console.WriteLine("Sending you back to the SpacePort");
            StandardMessages.ReturnToContinue();
            gameContext.SpacePort.SpacePortOptions(gameContext);
        }
    }
}
