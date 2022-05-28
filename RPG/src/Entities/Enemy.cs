using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Enemy
    {

        public string Name { get; set; }
        public int Level { get; set; }
        public string EnemyType { get; set; }


        //Contrutor da classe Hero
        public Enemy(string name, int level, string enemyType)
        {
            Name = name;
            Level = level;
            EnemyType = enemyType;
        }

        public override string ToString()
        {
            return $"{Name} | Level: {Level} | Classe: {EnemyType}";
        }

    }
}
