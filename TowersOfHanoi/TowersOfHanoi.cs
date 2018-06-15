using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class Game
    {
        public Tower[] towers { get; set; }

        public Game()
        {
            this.towers = new Dict
        }
    }

    class Tower
    {
        private Block[] blocks;


        public void PushBlock()
        {

        }

        public void PopBlock()
        {

        }



        
    }

    class Block
    {
        public Block (int weight) {
            this.Weight = weight;
        }

        public int Weight { get; private set; }

    }
}
