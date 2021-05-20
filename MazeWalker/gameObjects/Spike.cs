
namespace MazeWalker.gameObjects
{
    class Spike : GameObject
    {
        public Spike(char symbol = '▲', CollisionType collisionType = CollisionType.spike) : base(symbol, collisionType) { }
        public Spike(int posX, int posY, char symbol = '▲', CollisionType collisionType = CollisionType.spike) : base(posX, posY, symbol, collisionType) { }

        public override void ObjectFunction(entity.Player player, GameObject gameObj)
        {
            player.hp -= 2;
            player.drawStatus();
        }
    }
}
