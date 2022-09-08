using DesignPetterns.Enitites.Demons;
using DesignPetterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPetterns.Factories
{
    public class DemonFactory : MonsterFactory
    {
        public override IMonsters GetMonsters(string MonsterType)
        {
            IMonsters monster = null;
            switch (MonsterType)
            {
                case "largedemon":
                    monster = new LargeDemon();
                    break;
                case "smalldemon":
                    monster = new SmallDemon();
                    break;
            }
            return monster!;
        }
    }
}
