
namespace MazeWalker.gameObjects.collectable
{
    class Heart : CollectableObject
    {
        public Heart(char symbol = '♥') : base(symbol) { }
        public Heart(int posX, int posY, char symbol = '♥') : base(posX, posY, symbol) { }

        public override void ObjectFunction(entity.Player player)
        {
            player.maxHp += 10;
            player.hp = (int)(((float)player.hp / ((float)player.maxHp - 10)) * (float)player.maxHp);
        }
    }
}
