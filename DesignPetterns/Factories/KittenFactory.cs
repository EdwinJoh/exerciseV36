using DesignPetterns.Enitites.Demons;
using DesignPetterns.Enitites.Kittens;
using DesignPetterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPetterns.Factories
{
    public class KittenFactory : MonsterFactory
    {
        public override IMonsters GetMonsters(string MonsterType)
        {
            IMonsters monster = null;
            switch (MonsterType)
            {
                case "angrykitten":
                    monster = new AngryKitten();
                    break;

                case "cuddykitten":
                    monster = new CuddyKitten();
                    break;
                case "deadoralivekitten":
                    monster = new DeadOrAliveKitten();
                    break;
            }
            return monster!;
        }
    }
}
