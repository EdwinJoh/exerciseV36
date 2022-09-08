using DesignPetterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPetterns.Factories;

public abstract class MonsterFactory
{
    public abstract IMonsters GetMonsters(string MonsterType);

    public static MonsterFactory CreateMonsterFactory(string FactoryType)
    {
        if (FactoryType.Equals("Demons"))
            return new DemonFactory();

        if (FactoryType.Equals("Kittens"))
            return new KittenFactory();
        else
            return new UndeadFactory();
    }
}
