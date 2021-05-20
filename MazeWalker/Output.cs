using System;
using System.Collections.Generic;


namespace MazeWalker
{
    public static class Output
    {
        public static void drawMaze(List<gameObjects.GameObject> objects)
        {
            foreach (gameObjects.GameObject gameObj in objects)
            {
                Console.SetCursorPosition(gameObj.posX, gameObj.posY);
                Console.Write(gameObj.symbol);
            }
        }

        public static void drawStatus(gameObjects.entity.Player player)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("HP: " + player.hp);
            Console.Write("\t\tMax HP: " + player.maxHp);
            Console.Write("\t\tKeys: " + player.keyCount);
        }

        public static void drawSingleObject(int posX, int posY, char symbol)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(symbol);
        }

        public static void drawSingleObject(gameObjects.GameObject obj)
        {
            Console.SetCursorPosition(obj.posX, obj.posY);
            Console.Write(obj.symbol);
        }
    }
}
