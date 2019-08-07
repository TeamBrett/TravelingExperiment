using System;
using System.Collections.Generic;
using System.Linq;


namespace TravelingExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables that go into GameContext
            var list = new Lists();
            var jumpGate = new JumpGate();
            var spacePort = new SpacePort();
            var instance = new Instance();
            var player = new Player() { InSolarSystem = 1 };
            var travel = new Travel();

            // GameContext Variable
            var gameContext = new GameContext() { List = list, JumpGate = jumpGate, SpacePort = spacePort, Instance = instance, Player = player, Travel = travel };


            // Creating base variables
            var place = new Place();

            // Creating JumpGates
            var jumpGate1 = new JumpGate() { InSolarSystem = 1, Name = "jg1" };
            var jumpGate2 = new JumpGate() { InSolarSystem = 2, Name = "jg2" };
            var jumpGate3 = new JumpGate() { InSolarSystem = 3, Name = "jg3" };

            // Creating SpacePorts
            var spacePort1 = new SpacePort() { InSolarSystem = 1, Name = "sp1" };
            var spacePort2 = new SpacePort() { InSolarSystem = 1, Name = "sp2" };
            var spacePort3 = new SpacePort() { InSolarSystem = 1, Name = "sp3" };
            var spacePort4 = new SpacePort() { InSolarSystem = 2, Name = "sp4" };
            var spacePort5 = new SpacePort() { InSolarSystem = 2, Name = "sp5" };
            var spacePort6 = new SpacePort() { InSolarSystem = 2, Name = "sp6" };
            var spacePort7 = new SpacePort() { InSolarSystem = 3, Name = "sp7" };
            var spacePort8 = new SpacePort() { InSolarSystem = 3, Name = "sp8" };
            var spacePort9 = new SpacePort() { InSolarSystem = 3, Name = "sp9" };

            // Creating Instances
            var instance1 = new Instance() { InSpacePort = "sp1", Name = "i1" };
            var instance2 = new Instance() { InSpacePort = "sp1", Name = "i2" };
            var instance3 = new Instance() { InSpacePort = "sp2", Name = "i3" };
            var instance4 = new Instance() { InSpacePort = "sp2", Name = "i4" };
            var instance5 = new Instance() { InSpacePort = "sp3", Name = "i5" };
            var instance6 = new Instance() { InSpacePort = "sp3", Name = "i6" };
            var instance7 = new Instance() { InSpacePort = "sp4", Name = "i7" };
            var instance8 = new Instance() { InSpacePort = "sp4", Name = "i8" };
            var instance9 = new Instance() { InSpacePort = "sp5", Name = "i9" };
            var instance10 = new Instance() { InSpacePort = "sp5", Name = "i10" };
            var instance11 = new Instance() { InSpacePort = "sp6", Name = "i11" };
            var instance12 = new Instance() { InSpacePort = "sp6", Name = "i12" };
            var instance13 = new Instance() { InSpacePort = "sp7", Name = "i13" };
            var instance14 = new Instance() { InSpacePort = "sp7", Name = "i14" };
            var instance15 = new Instance() { InSpacePort = "sp8", Name = "i15" };
            var instance16 = new Instance() { InSpacePort = "sp8", Name = "i16" };
            var instance17 = new Instance() { InSpacePort = "sp9", Name = "i17" };
            var instance18 = new Instance() { InSpacePort = "sp9", Name = "i18" };

            // Adding JumpGates to the list
            gameContext.List.listJumpGate.Add(jumpGate1);
            gameContext.List.listJumpGate.Add(jumpGate2);
            gameContext.List.listJumpGate.Add(jumpGate3);

            // Adding SpacePorts to the list
            gameContext.List.listSpacePort.Add(spacePort1);
            gameContext.List.listSpacePort.Add(spacePort2);
            gameContext.List.listSpacePort.Add(spacePort3);
            gameContext.List.listSpacePort.Add(spacePort4);
            gameContext.List.listSpacePort.Add(spacePort5);
            gameContext.List.listSpacePort.Add(spacePort6);
            gameContext.List.listSpacePort.Add(spacePort7);
            gameContext.List.listSpacePort.Add(spacePort8);
            gameContext.List.listSpacePort.Add(spacePort9);

            // Adding Instances to the list
            gameContext.List.listInstance.Add(instance1);
            gameContext.List.listInstance.Add(instance2);
            gameContext.List.listInstance.Add(instance3);
            gameContext.List.listInstance.Add(instance4);
            gameContext.List.listInstance.Add(instance5);
            gameContext.List.listInstance.Add(instance6);
            gameContext.List.listInstance.Add(instance7);
            gameContext.List.listInstance.Add(instance8);
            gameContext.List.listInstance.Add(instance9);
            gameContext.List.listInstance.Add(instance10);
            gameContext.List.listInstance.Add(instance11);
            gameContext.List.listInstance.Add(instance12);
            gameContext.List.listInstance.Add(instance13);
            gameContext.List.listInstance.Add(instance14);
            gameContext.List.listInstance.Add(instance15);
            gameContext.List.listInstance.Add(instance16);
            gameContext.List.listInstance.Add(instance17);
            gameContext.List.listInstance.Add(instance18);


            // Test area
            gameContext.Travel.TravelToSpacePort(gameContext);






            // Game Starts here






        }
    }
}
