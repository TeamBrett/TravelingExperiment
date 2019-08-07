using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TravelingExperiment
{
    public class Travel
    {
        public void TravelToSpacePort(Player player, Lists list, Travel travel, Instance instance, SpacePort spacePort, JumpGate jumpGate)
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

            spacePort.SpacePortOptions(player, list, travel, instance, spacePort, jumpGate);
        }

        public void TravelToJumpGateFromSpacePort(Player player, Lists list, Travel travel, Instance instance, SpacePort spacePort, JumpGate jumpGate)
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

            jumpGate.JumpGateOptions(player, list, travel, instance, spacePort, jumpGate);
        }

        public void TravelToJumpGateFromJumpGate(Player player, Lists list, Travel travel, Instance instance, SpacePort spacePort, JumpGate jumpGate)
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

            jumpGate.JumpGateOptions(player, list, travel, instance, spacePort, jumpGate);
        }

        public void TravelToInstance(Player player, Lists list, Travel travel, Instance instance, SpacePort spacePort, JumpGate jumpGate)
        {
            List<Instance> query = list.listInstance.Where(inst => inst.InSpacePort == player.SpacePortLocation).ToList();


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

            player.InstanceLocation = (query[travelTo].Name);

            switch (player.InstanceLocation)
            {
                case "i1":
                    instance.Instance1(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i2":
                    instance.Instance2(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i3":
                    instance.Instance3(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i4":
                    instance.Instance4(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i5":
                    instance.Instance5(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i6":
                    instance.Instance6(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i7":
                    instance.Instance7(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i8":
                    instance.Instance8(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i9":
                    instance.Instance9(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i10":
                    instance.Instance10(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i11":
                    instance.Instance11(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i12":
                    instance.Instance12(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i13":
                    instance.Instance13(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i14":
                    instance.Instance14(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i15":
                    instance.Instance15(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i16":
                    instance.Instance16(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i17":
                    instance.Instance17(player, list, travel, instance, spacePort, jumpGate);
                    break;
                case "i18":
                    instance.Instance18(player, list, travel, instance, spacePort, jumpGate);
                    break;
            }
        }
    }
}
