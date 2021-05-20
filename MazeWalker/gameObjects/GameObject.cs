
namespace MazeWalker.gameObjects
{
    public enum CollisionType
    {
        air,
        //collectable,
        wall,
        spike
    }

    public class GameObject : IGameObject
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public char symbol { get; set; }
        public CollisionType collisionType { get; set; }

        public GameObject() { }

        public GameObject(char symbol)
        {
            this.symbol = symbol;
        }

        public GameObject(char symbol, CollisionType collisionType)
        {
            this.symbol = symbol;
            this.collisionType = collisionType;
        }

        public GameObject(int posX, int posY, char symbol)
        {
            this.posX = posX;
            this.posY = posY;
            this.symbol = symbol;
        }

        public GameObject(int posX, int posY, char symbol, CollisionType collisionType)
        {
            this.posX = posX;
            this.posY = posY;
            this.symbol = symbol;
            this.collisionType = collisionType;
        }

        public virtual void ObjectFunction(entity.Player player, GameObject gameObj) { }
    }
}
