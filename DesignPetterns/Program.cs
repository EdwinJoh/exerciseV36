using DesignPetterns.Factories;
using DesignPetterns.Interfaces;

IMonsters monster = null;
MonsterFactory monsterFactory = null;
string sound = null;

//Crate demon factory object by passing the factory type as demon
monsterFactory = MonsterFactory.CreateMonsterFactory("Demons");
Console.WriteLine("Monster factory type: " + monsterFactory.GetType().Name);

//Get Demon
monster = monsterFactory.GetMonsters("largedemon");
Console.WriteLine("Monster type is: " + monster.GetType().Name);











Console.ReadKey();