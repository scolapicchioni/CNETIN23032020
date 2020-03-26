using System;
using System.Collections.Generic;
using System.Text;

namespace GameScenario {
    public class Player : IPlayer {
        private IDice dice;
        public Player(IDice dice) {
            this.dice = dice;
        }

        public string Name { get ; set; }

        public int Play() => dice.Roll();

    }
}
