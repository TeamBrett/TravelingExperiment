using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TravelingExperiment
{
    public class Travel
    {
        public void TravelToSpacePort(Player player, Lists list, Travel travel, SpacePort spacePort, JumpGate jumpGate)
        {
            List<SpacePort> query = list.listSpacePort.Where(sp => sp.InSolarSystem == player.InSolarSystem).ToList();


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

            player.SpacePortLocation = (query[travelTo].Name);

            Console.WriteLine(player.SpacePortLocation);

            spacePort.SpacePortOptions(player, list, travel, spacePort, jumpGate);
        }

        public void TravelToJumpGateFromSpacePort(Player player, Lists list, Travel travel, SpacePort spacePort, JumpGate jumpGate)
        {
            List<JumpGate> query = list.listJumpGate.Where(sp => sp.InSolarSystem == player.InSolarSystem).ToList();


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

            player.JumpGateLocation = (query[travelTo].Name);

            Console.WriteLine(player.JumpGateLocation);

            jumpGate.JumpGateOptions(player, list, travel, spacePort, jumpGate);
        }

        public void TravelToJumpGateFromJumpGate(Player player, Lists list, Travel travel, SpacePort spacePort, JumpGate jumpGate)
        {
            List<JumpGate> query = list.listJumpGate.Where(sp => sp.InSolarSystem == player.InSolarSystem - 1 || sp.InSolarSystem == player.InSolarSystem || sp.InSolarSystem == player.InSolarSystem + 1).ToList();

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

            player.JumpGateLocation = (query[travelTo].Name);
            player.InSolarSystem = (query[travelTo].InSolarSystem);

            Console.WriteLine(player.JumpGateLocation);

            jumpGate.JumpGateOptions(player, list, travel, spacePort, jumpGate);
        }
    }
}
