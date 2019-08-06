using System;
using System.Collections.Generic;
using System.Linq;


namespace TravelingExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Lists();
            var place = new Place();
            var jumpGate = new JumpGate();
            var spacePort = new SpacePort();
            var instance = new Instance();
            var player = new Player();
            var travel = new Travel();

            var jumpGate1 = new JumpGate() { Name = "jg1" };
            var jumpGate2 = new JumpGate() { Name = "jg2" };
            var jumpGate3 = new JumpGate() { Name = "jg3" };

            var spacePort1 = new SpacePort() { InSolarSystem = "ss1", Name = "sp1" };
            var spacePort2 = new SpacePort() { InSolarSystem = "ss1", Name = "sp2" };
            var spacePort3 = new SpacePort() { InSolarSystem = "ss1", Name = "sp3" };
            var spacePort4 = new SpacePort() { InSolarSystem = "ss2", Name = "sp4" };
            var spacePort5 = new SpacePort() { InSolarSystem = "ss2", Name = "sp5" };
            var spacePort6 = new SpacePort() { InSolarSystem = "ss2", Name = "sp6" };
            var spacePort7 = new SpacePort() { InSolarSystem = "ss3", Name = "sp7" };
            var spacePort8 = new SpacePort() { InSolarSystem = "ss3", Name = "sp8" };
            var spacePort9 = new SpacePort() { InSolarSystem = "ss3", Name = "sp9" };

            var instance1 = new Instance() { InPlanet = "p1", Name = "i1" };
            var instance2 = new Instance() { InPlanet = "p1", Name = "i2" };
            var instance3 = new Instance() { InPlanet = "p2", Name = "i3" };
            var instance4 = new Instance() { InPlanet = "p2", Name = "i4" };
            var instance5 = new Instance() { InPlanet = "p4", Name = "i5" };
            var instance6 = new Instance() { InPlanet = "p3", Name = "i6" };
            var instance7 = new Instance() { InPlanet = "p4", Name = "i7" };
            var instance8 = new Instance() { InPlanet = "p4", Name = "i8" };
            var instance9 = new Instance() { InPlanet = "p5", Name = "i9" };
            var instance10 = new Instance() { InPlanet = "p5", Name = "i10"  };
            var instance11 = new Instance() { InPlanet = "p6", Name = "i11"  };
            var instance12 = new Instance() { InPlanet = "p6", Name = "i12"  };
            var instance13 = new Instance() { InPlanet = "p7", Name = "i13"  };
            var instance14 = new Instance() { InPlanet = "p7", Name = "i14"  };
            var instance15 = new Instance() { InPlanet = "p8", Name = "i15"  };
            var instance16 = new Instance() { InPlanet = "p8", Name = "i16"  };
            var instance17 = new Instance() { InPlanet = "p9", Name = "i17"  };
            var instance18 = new Instance() { InPlanet = "p9", Name = "i18" };

            list.listJumpGates.Add(jumpGate1);
            list.listJumpGates.Add(jumpGate2);
            list.listJumpGates.Add(jumpGate3);

            list.listSpacePort.Add(spacePort1);
            list.listSpacePort.Add(spacePort2);
            list.listSpacePort.Add(spacePort3);
            list.listSpacePort.Add(spacePort4);
            list.listSpacePort.Add(spacePort5);
            list.listSpacePort.Add(spacePort6);
            list.listSpacePort.Add(spacePort7);
            list.listSpacePort.Add(spacePort8);
            list.listSpacePort.Add(spacePort9);

            list.listInstance.Add(instance1);
            list.listInstance.Add(instance2);
            list.listInstance.Add(instance3);
            list.listInstance.Add(instance4);
            list.listInstance.Add(instance5);
            list.listInstance.Add(instance6);
            list.listInstance.Add(instance7);
            list.listInstance.Add(instance8);
            list.listInstance.Add(instance9);
            list.listInstance.Add(instance10);
            list.listInstance.Add(instance11);
            list.listInstance.Add(instance12);
            list.listInstance.Add(instance13);
            list.listInstance.Add(instance14);
            list.listInstance.Add(instance15);
            list.listInstance.Add(instance16);
            list.listInstance.Add(instance17);
            list.listInstance.Add(instance18);


            foreach (JumpGate jg in list.listJumpGates)
            {
                Console.WriteLine(jg.Name);
            }


            List<SpacePort> query = list.listSpacePort.Where(sp => sp.InSolarSystem == "ss1").ToList();


            foreach (SpacePort sp in query) 
            {
                Console.WriteLine(query.IndexOf(sp) + ") " + sp.Name);
            }
            var travelTo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(travelTo);

            player.SpacePortLocation = (query[travelTo].Name);

            Console.WriteLine(player.SpacePortLocation);



        }
    }
}
