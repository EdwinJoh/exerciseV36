using DesignPetterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPetterns.Enitites.Undead
{
    public class Skeleton: IMonsters
    {
        public string Speak()
        {
            return "Iam a Skeleton";
        }
    }
}
