using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeWalker.gameObjects.entity
{
    public class Player : Entity
    {
        public byte keyCount = 0;

        public Player(char symbol = '±') : base(symbol) { }
        public Player(int posX, int posY, char symbol = '±') : base(posX, posY, symbol) { }

        public void drawStatus()
        {
            Output.drawStatus(this);
        }
    }
}
