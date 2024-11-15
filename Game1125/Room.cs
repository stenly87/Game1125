using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Game1125
{
    internal class Room
    {
        Random random = new Random();
        public Creature Player { get; set; }
        public List<Creature> Enemies { get; set; }

        Enemy GenerateRandomEnemy()
        {
            switch (random.Next(0, 4))
            {
                case 0: return new EnemyOrc();
                case 1: return new EnemySlime();
                case 2: return new EnemyDragon();
                default:
                    return new EnemyElf();
            }
        }

        public Room(Player player)
        {
            Player = player;
            Enemies = new List<Creature>();
            int count = random.Next(1, 4);
            for (int i = 0; i < count; i++)
                Enemies.Add(GenerateRandomEnemy());
        }

        public void RunBattle()
        {
            int round = 1;
            bool enemyIsDead = false;
            do
            {
                Console.WriteLine("############ ROUND " + round++);
                Player.RandomSpeed();
                foreach(var enemy in Enemies)
                    enemy.RandomSpeed();

                List<Creature> order = [Player];
                order.AddRange(Enemies);
                order = order.OrderByDescending(s=>s.Stats.Speed).ToList();
                foreach (var obj in order)
                    obj.RunAction(this);

                enemyIsDead = true;
                foreach (var obj in Enemies)
                    if (!obj.IsDead)
                        enemyIsDead = false;
            }
            while (!Player.IsDead && !enemyIsDead);

            
        }
    }
}
