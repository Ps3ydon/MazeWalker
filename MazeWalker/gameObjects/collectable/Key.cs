
namespace MazeWalker.gameObjects.collectable
{
    class Key : CollectableObject
    {
        public Key(char symbol = '?') : base(symbol) { }
        public Key(int posX, int posY, char symbol = '?') : base(posX, posY, symbol) { }

        public override void ObjectFunction(entity.Player player)
        {
            player.keyCount++;
        }
    }
}
