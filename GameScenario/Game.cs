using System;

namespace GameScenario {
    public class Game {
        private IPlayer player1;
        private IPlayer player2;

        public Game(IPlayer p1, IPlayer p2) {
            player1 = p1;
            player2 = p2;
        }

        public IPlayer Play() {
            int p1result = player1.Play();
            int p2result = player2.Play();
            if (p1result > p2result) {
                return player1;
            } else if (p2result > p1result) {
                return player2;
            } else {
                return null;
            }
        }
    }
}
