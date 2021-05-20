
namespace MazeWalker.gameObjects.collectable
{
    class Apple : CollectableObject
    {
        public Apple(char symbol = '@') : base(symbol) { }
        public Apple(int posX, int posY, char symbol = '@') : base(posX, posY, symbol) { }

        public override void ObjectFunction(entity.Player player)
        {
            if (player.hp + (player.maxHp / 2) >= player.maxHp)
                player.hp = player.maxHp;
            else
                player.hp += (player.maxHp / 2);
        }
    }
}
