
namespace MazeWalker.gameObjects.collectable
{
    public class CollectableObject : GameObject
    {
        public CollectableObject(char symbol, CollisionType collisionType = CollisionType.air) : base(symbol, collisionType) { }
        public CollectableObject(int posX, int posY, char symbol, CollisionType collisionType = CollisionType.air) : base(posX, posY, symbol, collisionType) { }

        public override void ObjectFunction(entity.Player player, GameObject gameObj)
        {
            ObjectManager.removeObject(gameObj);
            ObjectFunction(player);
            player.drawStatus();
        }

        public virtual void ObjectFunction(entity.Player player) { }
    }
}
