
namespace MazeWalker.gameObjects
{
    public class Wall : GameObject
    {
        public Wall(char symbol = '▓', CollisionType collisionType = CollisionType.wall) : base(symbol, collisionType) { }
        public Wall(int posX, int posY, char symbol = '▓', CollisionType collisionType = CollisionType.wall) : base(posX, posY, symbol, collisionType) { }
    }
}
