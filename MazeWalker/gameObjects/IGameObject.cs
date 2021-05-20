
namespace MazeWalker.gameObjects
{
    interface IGameObject
    {
        int posX { get; set; }
        int posY { get; set; }
        char symbol { get; set; }
        CollisionType collisionType { get; set; }

    }
}
