using DesignPetterns.Interfaces;

namespace DesignPetterns.Enitites.Undead;

public class Zombie : IMonsters
{
    public string Speak()
    {
        return "Iam a zombie";
    }
}
