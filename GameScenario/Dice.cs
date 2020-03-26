using System;
using System.Collections.Generic;
using System.Text;

namespace GameScenario {
    public class Dice : IDice {
        private Random randomGenerator = new Random();

        public int Roll() => randomGenerator.Next(1, 7);
    }
}
