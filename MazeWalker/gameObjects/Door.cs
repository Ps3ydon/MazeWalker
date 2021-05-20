
namespace MazeWalker.gameObjects
{
    class Door : GameObject
    {
        public Door(char symbol = '▒', CollisionType collisionType = CollisionType.wall) : base(symbol, collisionType) { }
        public Door(int posX, int posY, char symbol = '▒', CollisionType collisionType = CollisionType.wall) : base(posX, posY, symbol, collisionType) { }

        public override void ObjectFunction(entity.Player player, GameObject gameObj)
        {
            if (player.keyCount <= 0)
                return;
            player.keyCount--;
            ObjectManager.removeObject(gameObj);
            player.drawStatus();
        }
    }
}
