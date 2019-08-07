using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TravelingExperiment
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
                    break;
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
                //travelTo = Convert.ToInt32(Console.ReadLine());
                if (travelTo > 0 && travelTo < query.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter an integer between zero and " + (query.Count - 1));
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
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input is not valid, try entering an integer");
                    }
                    //travelTo = Convert.ToInt32(Console.ReadLine());
                    if (travelTo > 0 && travelTo < query.Count)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (query.Count - 1));
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
                    break;
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
                //travelTo = Convert.ToInt32(Console.ReadLine());
                if (travelTo > 0 && travelTo < query.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter an integer between zero and " + (query.Count - 1));
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
                    break;
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
                //travelTo = Convert.ToInt32(Console.ReadLine());
                if (travelTo > 0 && travelTo < query.Count)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter an integer between zero and " + (query.Count - 1));
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
                case "i3":      
                    gameContext.Instance.Instance3(gameContext);
                    break;      
                case "i4":      
                    gameContext.Instance.Instance4(gameContext);
                    break;      
                case "i5":      
                    gameContext.Instance.Instance5(gameContext);
                    break;      
                case "i6":      
                    gameContext.Instance.Instance6(gameContext);
                    break;      
                case "i7":      
                    gameContext.Instance.Instance7(gameContext);
                    break;      
                case "i8":      
                    gameContext.Instance.Instance8(gameContext);
                    break;      
                case "i9":      
                    gameContext.Instance.Instance9(gameContext);
                    break;      
                case "i10":     
                    gameContext.Instance.Instance10(gameContext);
                    break;      
                case "i11":     
                    gameContext.Instance.Instance11(gameContext);
                    break;      
                case "i12":     
                    gameContext.Instance.Instance12(gameContext);
                    break;      
                case "i13":     
                    gameContext.Instance.Instance13(gameContext);
                    break;      
                case "i14":     
                    gameContext.Instance.Instance14(gameContext);
                    break;      
                case "i15":     
                    gameContext.Instance.Instance15(gameContext);
                    break;      
                case "i16":     
                    gameContext.Instance.Instance16(gameContext);
                    break;      
                case "i17":     
                    gameContext.Instance.Instance17(gameContext);
                    break;      
                case "i18":     
                    gameContext.Instance.Instance18(gameContext);
                    break;
            }
        }
    }
}
