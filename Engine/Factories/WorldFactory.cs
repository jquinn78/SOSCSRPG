﻿using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -2, "Farmer's Field", "There are rows of corn growing here with giant rats hiding between them.", "C:/Users/Josh/source/repos/SOSCSRPG/Images/Locations/FarmFields.png");

            newWorld.AddLocation(-1, -1, "Farmer's House", "This is the house of your neighbor, Farmer John", "C:/Users/Josh/source/repos/SOSCSRPG/Images/Locations/Farmhose.png");

            newWorld.AddLocation(0, -1, "Home", "This is your home", "C:/Users/Josh/source/repos/SOSCSRPG/Images/Locations/Home.png");

            newWorld.AddLocation(-1, 0, "Trading Shop", "The shop of Susan the trader.", "C:/Users/Josh/source/repos/SOSCSRPG/Images/Locations/Trader.png");

            newWorld.AddLocation(0, 0, "Town Square", "You see a fountain here.", "C:/Users/Josh/source/repos/SOSCSRPG/Engine/Images/Locations/TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                "C:/Users/Josh/source/repos/SOSCSRPG/Images/Locations/TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest", "The trees in this forest are covered with spider webs.", "C:/Users/Josh/source/repos/SOSCSRPG/Images/Locations/SpiderForest.png");

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                "C:/Users/Josh/source/repos/SOSCSRPG/Images/Locations/HerbalistsHut.png");

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                "C:/Users/Josh/source/repos/SOSCSRPG/Images/Locations/HerbalistsGarden.png");

            return newWorld;
        }
    }
}
