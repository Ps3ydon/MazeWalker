using MazeWalker.gameObjects;
using MazeWalker.gameObjects.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeWalker
{
    public static class ObjectManager
    {
        public static List<GameObject> objects = fileIO.loadMap("map.txt", false);

        public static GameObject detectObj(Direction direction, Entity entity)
        {
            GameObject lol = new GameObject();

            switch (direction)
            {
                case Direction.up:
                    lol = objects.Find(x => x.posX == entity.posX && x.posY == entity.posY - 1);
                    break;
                case Direction.left:
                    lol = objects.Find(x => x.posX == entity.posX - 1 && x.posY == entity.posY);
                    break;
                case Direction.down:
                    lol = objects.Find(x => x.posX == entity.posX && x.posY == entity.posY + 1);
                    break;
                case Direction.right:
                    lol = objects.Find(x => x.posX == entity.posX + 1 && x.posY == entity.posY);
                    break;
            }

            return lol;
        }

        public static void removeObject(GameObject gameObj)
        {
            objects.Remove(gameObj);
            Output.drawSingleObject(gameObj.posX, gameObj.posY, ' ');
        }
    }
}
