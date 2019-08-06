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

            var travelTo = Convert.ToInt32(Console.ReadLine());

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

            var travelTo = Convert.ToInt32(Console.ReadLine());

            player.JumpGateLocation = (query[travelTo].Name);

            Console.WriteLine(player.JumpGateLocation);

            jumpGate.JumpGateOptions(player, list, travel, spacePort, jumpGate);
        }

        public void TravelToJumpGateFromJumpGate(Player player, Lists list, Travel travel, SpacePort spacePort, JumpGate jumpGate)
        {
            List<JumpGate> query = list.listJumpGate.Where(sp => sp.InSolarSystem == player.InSolarSystem - 1).ToList();
            List<JumpGate> query1 = list.listJumpGate.Where(sp => sp.InSolarSystem == player.InSolarSystem).ToList();
            List<JumpGate> query2 = list.listJumpGate.Where(sp => sp.InSolarSystem == player.InSolarSystem + 1).ToList();
            query.AddRange(query1);
            query.AddRange(query2);




            foreach (JumpGate jg in query)
            {
                Console.WriteLine(query.IndexOf(jg) + ") " + jg.Name);
            }

            var travelTo = Convert.ToInt32(Console.ReadLine());

            player.JumpGateLocation = (query[travelTo].Name);
            player.InSolarSystem = (query[travelTo].InSolarSystem);

            Console.WriteLine(player.JumpGateLocation);

            jumpGate.JumpGateOptions(player, list, travel, spacePort, jumpGate);
        }
    }
}
