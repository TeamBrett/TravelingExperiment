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
            var player = new Player() { InSolarSystem = 1 };
            var travel = new Travel();

            var jumpGate1 = new JumpGate() { InSolarSystem = 1, Name = "jg1" };
            var jumpGate2 = new JumpGate() { InSolarSystem = 2, Name = "jg2" };
            var jumpGate3 = new JumpGate() { InSolarSystem = 3, Name = "jg3" };

            var spacePort1 = new SpacePort() { InSolarSystem = 1, Name = "sp1" };
            var spacePort2 = new SpacePort() { InSolarSystem = 1, Name = "sp2" };
            var spacePort3 = new SpacePort() { InSolarSystem = 1, Name = "sp3" };
            var spacePort4 = new SpacePort() { InSolarSystem = 2, Name = "sp4" };
            var spacePort5 = new SpacePort() { InSolarSystem = 2, Name = "sp5" };
            var spacePort6 = new SpacePort() { InSolarSystem = 2, Name = "sp6" };
            var spacePort7 = new SpacePort() { InSolarSystem = 3, Name = "sp7" };
            var spacePort8 = new SpacePort() { InSolarSystem = 3, Name = "sp8" };
            var spacePort9 = new SpacePort() { InSolarSystem = 3, Name = "sp9" };

            var instance1 = new Instance() { InSpacePort = "sp1", Name = "i1" };
            var instance2 = new Instance() { InSpacePort = "sp1", Name = "i2" };
            var instance3 = new Instance() { InSpacePort = "sp2", Name = "i3" };
            var instance4 = new Instance() { InSpacePort = "sp2", Name = "i4" };
            var instance5 = new Instance() { InSpacePort = "sp3", Name = "i5" };
            var instance6 = new Instance() { InSpacePort = "sp3", Name = "i6" };
            var instance7 = new Instance() { InSpacePort = "sp4", Name = "i7" };
            var instance8 = new Instance() { InSpacePort = "sp4", Name = "i8" };
            var instance9 = new Instance() { InSpacePort = "sp5", Name = "i9" };
            var instance10 = new Instance() { InSpacePort = "sp5", Name = "i10"  };
            var instance11 = new Instance() { InSpacePort = "sp6", Name = "i11"  };
            var instance12 = new Instance() { InSpacePort = "sp6", Name = "i12"  };
            var instance13 = new Instance() { InSpacePort = "sp7", Name = "i13"  };
            var instance14 = new Instance() { InSpacePort = "sp7", Name = "i14"  };
            var instance15 = new Instance() { InSpacePort = "sp8", Name = "i15"  };
            var instance16 = new Instance() { InSpacePort = "sp8", Name = "i16"  };
            var instance17 = new Instance() { InSpacePort = "sp9", Name = "i17"  };
            var instance18 = new Instance() { InSpacePort = "sp9", Name = "i18" };

            list.listJumpGate.Add(jumpGate1);
            list.listJumpGate.Add(jumpGate2);
            list.listJumpGate.Add(jumpGate3);

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


            


            travel.TravelToSpacePort(player, list, travel, instance, spacePort, jumpGate);



        }
    }
}
