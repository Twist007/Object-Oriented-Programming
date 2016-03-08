﻿using System;
using Empires.Charachters;
using Empires.Models.Units;

namespace Empires.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case"Archer":
                    return new Archer();
                case "Swordsman":
                   return new Swordsman();
                default:
                    throw new ArgumentException("Unknown unit type.");
            }
        }
    }
}
