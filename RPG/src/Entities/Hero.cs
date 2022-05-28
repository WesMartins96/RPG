using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Hero
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }


        //Contrutor da classe Hero
        public Hero(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public string Attack()
        {
            return $"{Name} Atacou com a sua espada";
        }

        public string MageAttack()
        {
            return $"{Name} Lançou sua Magia";
        }

        public string NinjaAttack()
        {
            return $"{Name} Jogou sua Kunai";
        }

        public override string ToString()
        {
            return $"{Name} | Level: {Level} | Classe: {HeroType}";
        }


    }
}
