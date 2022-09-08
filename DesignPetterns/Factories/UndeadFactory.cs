using DesignPetterns.Enitites.Undead;
using DesignPetterns.Interfaces;

namespace DesignPetterns.Factories;

public class UndeadFactory : MonsterFactory
{
    public override IMonsters GetMonsters(string MonsterType)
    {
        IMonsters monster = null;
        switch (MonsterType)
        {
            case "skeleton":
                monster = new Skeleton();
                break;

            case "zombie":
                monster = new Zombie();
                break;
        }
        return monster!;
    }

}
