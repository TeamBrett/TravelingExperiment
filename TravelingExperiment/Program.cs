﻿using CelestialTravels0_1.Consumables;
using CelestialTravels0_1.Consumables.EnergyKits;
using CelestialTravels0_1.Consumables.HealthKits;
using CelestialTravels0_1.Fights;
using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Monsters;
using CelestialTravels0_1.Persistence;
using CelestialTravels0_1.Places;
using CelestialTravels0_1.Players;
using CelestialTravels0_1.Persistence;
using CelestialTravels0_1.Spells;
using CelestialTravels0_1.Travels;
using CelestialTravels0_1.Weapons;

namespace CelestialTravels0_1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Variables that go into GameContext
            var list = new Lists();
            var jumpGate = new JumpGate();
            var spacePort = new SpacePort();
            var instance = new Instance();
            var player = new Player() { InSolarSystem = 1, Level = 1 };
            var travel = new Travel();
            var inventory = new Inventory();
            var playerInventory = new Inventory();
            var playerAttackCalculator = new PlayerAttackCalculator();
            var playerStats = new PlayerStats();
            var weaponMaker = new WeaponMaker();
            var playerMaker = new PlayerMaker();
            var loadGame = new LoadGame();
            var saveGame = new SaveGame();
            var randomNameGenerator = new RandomNameGenerator();
            var repairShop = new RepairShop();
            var store = new Store();
            var healthKitSmall = new HealthKitSmall() { Name = "Small Health Kit", Price = 100 };
            var healthKitLarge = new HealthKitLarge() { Name = "Large Health Kit", Price = 250 };
            var healthKitTotal = new HealthKitTotal() { Name = "Total Health Kit", Price = 1000 };
            var energyKitSmall = new EnergyKitSmall() { Name = "Small Energy Kit", Price = 100 };
            var energyKitLarge = new EnergyKitLarge() { Name = "Large Energy Kit", Price = 250 };
            var energyKitTotal = new EnergyKitTotal() { Name = "Total Energy Kit", Price = 1000 };
            var smokeGrenade = new SmokeGrenade() { Name = "Smoke Grenade", Price = 2000 };
            var blaster = new Weapon() { Price = player.Level * 150 };
            var doubleBlaster = new Weapon() { Price = player.Level * 300 };
            var photonSword = new Weapon() { Price = player.Level * 450 };
            var virtualGun = new VirtualGun() { Description = "Spend Energy to deal Damage to your opponent", Name = "Virtual Gun", UsedBy = "Gunslinger" };

            // Mechanics for Fighting
            var fight = new Fight();
            var roller = new Roller();

            // Factories for Fighting
            var monsterMaker = new MonsterMaker();

            // GameContext Variable
            var gameContext = new GameContext()
            {
                List = list,
                JumpGate = jumpGate,
                SpacePort = spacePort,
                Instance = instance,
                Player = player,
                Travel = travel,
                Inventory = inventory,
                PlayerInventory = playerInventory,
                PlayerAttackCalculator = playerAttackCalculator,
                PlayerStats = playerStats,
                WeaponMaker = weaponMaker,
                Fight = fight,
                Roller = roller,
                MonsterMaker = monsterMaker,
                PlayerMaker = playerMaker,
                LoadGame = loadGame,
                SaveGame = saveGame,
                RandomNameGenerator = randomNameGenerator,
                RepairShop = repairShop,
                Store = store,
                HealthKitSmall = healthKitSmall,
                HealthKitLarge = healthKitLarge,
                HealthKitTotal = healthKitTotal,
                EnergyKitSmall = energyKitSmall,
                EnergyKitLarge = energyKitLarge,
                EnergyKitTotal = energyKitTotal,
                SmokeGrenade = smokeGrenade,
                Blaster = blaster,
                DoubleBlaster = doubleBlaster,
                PhotonSword = photonSword,
                VirtualGun = virtualGun,
            };

            // Monster Creation for Fighting
            var whiteMonster01 = monsterMaker.CreateWhiteMonster(gameContext);
            var whiteMonster02 = monsterMaker.CreateWhiteMonster(gameContext);
            var whiteMonster03 = monsterMaker.CreateWhiteMonster(gameContext);
            var greenMonster01 = monsterMaker.CreateGreenMonster(gameContext);
            var greenMonster02 = monsterMaker.CreateGreenMonster(gameContext);
            var greenMonster03 = monsterMaker.CreateGreenMonster(gameContext);
            var redMonster01 = monsterMaker.CreateRedMonster(gameContext);
            var redMonster02 = monsterMaker.CreateRedMonster(gameContext);
            var redMonster03 = monsterMaker.CreateRedMonster(gameContext);

            gameContext.WhiteMonster01 = whiteMonster01;
            gameContext.WhiteMonster02 = whiteMonster02;
            gameContext.WhiteMonster03 = whiteMonster03;
            gameContext.GreenMonster01 = greenMonster01;
            gameContext.GreenMonster02 = greenMonster02;
            gameContext.GreenMonster03 = greenMonster03;
            gameContext.RedMonster01 = redMonster01;
            gameContext.RedMonster02 = redMonster02;
            gameContext.RedMonster03 = redMonster03;

            // Creating base variables
            var place = new Place();
            var startUpScreen = new StartUpScreen();

            // Creating JumpGates
            var jumpGate1 = new JumpGate() { InSolarSystem = 1, Name = "jg1" };
            var jumpGate2 = new JumpGate() { InSolarSystem = 2, Name = "jg2" };
            var jumpGate3 = new JumpGate() { InSolarSystem = 3, Name = "jg3" };

            // Creating SpacePorts
            var spacePort1 = new SpacePort() { InSolarSystem = 1, Name = "sp1" };
            var spacePort2 = new SpacePort() { InSolarSystem = 1, Name = "sp2" };
            var spacePort3 = new SpacePort() { InSolarSystem = 1, Name = "sp3" };

            var spacePort10 = new SpacePort() { InSolarSystem = 2, Name = "sp10" };
            var spacePort11 = new SpacePort() { InSolarSystem = 2, Name = "sp11" };
            var spacePort12 = new SpacePort() { InSolarSystem = 2, Name = "sp12" };

            var spacePort20 = new SpacePort() { InSolarSystem = 3, Name = "sp20" };
            var spacePort21 = new SpacePort() { InSolarSystem = 3, Name = "sp21" };
            var spacePort22 = new SpacePort() { InSolarSystem = 3, Name = "sp22" };

            // Creating Instances
            var instance1 = new Instance() { InSpacePort = "sp1", Name = "i1" };
            var instance2 = new Instance() { InSpacePort = "sp1", Name = "i2" };

            var instance10 = new Instance() { InSpacePort = "sp2", Name = "i10" };
            var instance11 = new Instance() { InSpacePort = "sp2", Name = "i11" };

            var instance20 = new Instance() { InSpacePort = "sp3", Name = "i20" };
            var instance21 = new Instance() { InSpacePort = "sp3", Name = "i21" };

            var instance30 = new Instance() { InSpacePort = "sp10", Name = "i30" };
            var instance31 = new Instance() { InSpacePort = "sp10", Name = "i31" };

            var instance40 = new Instance() { InSpacePort = "sp11", Name = "i40" };
            var instance41 = new Instance() { InSpacePort = "sp11", Name = "i41" };

            var instance50 = new Instance() { InSpacePort = "sp12", Name = "i50" };
            var instance51 = new Instance() { InSpacePort = "sp12", Name = "i51" };

            var instance60 = new Instance() { InSpacePort = "sp20", Name = "i60" };
            var instance61 = new Instance() { InSpacePort = "sp20", Name = "i61" };

            var instance70 = new Instance() { InSpacePort = "sp21", Name = "i70" };
            var instance71 = new Instance() { InSpacePort = "sp21", Name = "i71" };

            var instance80 = new Instance() { InSpacePort = "sp22", Name = "i80" };
            var instance81 = new Instance() { InSpacePort = "sp22", Name = "i81" };

            // Adding JumpGates to the list
            gameContext.List.listJumpGate.Add(jumpGate1);
            gameContext.List.listJumpGate.Add(jumpGate2);
            gameContext.List.listJumpGate.Add(jumpGate3);

            // Adding SpacePorts to the list
            gameContext.List.listSpacePort.Add(spacePort1);
            gameContext.List.listSpacePort.Add(spacePort2);
            gameContext.List.listSpacePort.Add(spacePort3);

            gameContext.List.listSpacePort.Add(spacePort10);
            gameContext.List.listSpacePort.Add(spacePort11);
            gameContext.List.listSpacePort.Add(spacePort12);

            gameContext.List.listSpacePort.Add(spacePort20);
            gameContext.List.listSpacePort.Add(spacePort21);
            gameContext.List.listSpacePort.Add(spacePort22);

            // Adding Instances to the list
            gameContext.List.listInstance.Add(instance1);
            gameContext.List.listInstance.Add(instance2);

            gameContext.List.listInstance.Add(instance10);
            gameContext.List.listInstance.Add(instance11);

            gameContext.List.listInstance.Add(instance20);
            gameContext.List.listInstance.Add(instance21);

            gameContext.List.listInstance.Add(instance30);
            gameContext.List.listInstance.Add(instance31);

            gameContext.List.listInstance.Add(instance40);
            gameContext.List.listInstance.Add(instance41);

            gameContext.List.listInstance.Add(instance50);
            gameContext.List.listInstance.Add(instance51);

            gameContext.List.listInstance.Add(instance60);
            gameContext.List.listInstance.Add(instance61);

            gameContext.List.listInstance.Add(instance70);
            gameContext.List.listInstance.Add(instance71);

            gameContext.List.listInstance.Add(instance80);
            gameContext.List.listInstance.Add(instance81);

            // Test area

            // Game Starts here
            startUpScreen.StartUp(gameContext);
        }
    }
}
