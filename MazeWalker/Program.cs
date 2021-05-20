using MazeWalker.gameObjects;
using MazeWalker.gameObjects.collectable;
using MazeWalker.gameObjects.entity;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MazeWalker
{
    class Program
    {
        //public static List<GameObject> objects = fileIO.loadMap("map.txt", false);
        public static Player player = new Player(16, 2);

        static void Main(string[] args)
        {
            /*List<GameObject> spikes = new List<GameObject>();
            spikes = objects.FindAll(x => x.collisionType == CollisionType.spike);
            GameObject spike = null;*/


            Output.drawMaze(ObjectManager.objects);
            Output.drawSingleObject(player);
            player.drawStatus();

            bool lol = false;
            new Thread(() =>
            {
                while (true)
                {
                    if (!lol)
                    {
                        Console.SetCursorPosition(player.posX, player.posY);

                        Direction direction = Input.getInput();
                        player.calcMove(direction);

                        /*collision(direction);
                        GameObject gameObj = detectObj((Direction)(((int)direction + 2) % 4), spikes);
                        if (gameObj != null)
                            spike = gameObj;*/

                        lol = true;
                    }
                }
            }).Start();

            while (true)
            {
                if (lol)
                {
                    //if (spike != null)
                        //Output.drawSingleObject(spike);
                    //else
                        //Output.drawSingleObject(player.oldX, player.oldY, ' ');
                    //Output.drawSingleObject(player);

                    lol = false;
                }
            }
        }

        /*static void collision(Direction direction)
        {
            GameObject gameObj = detectObj(direction, objects);
            if (gameObj == null)
                gameObj = new GameObject();

            gameObj.ObjectFunction(player, gameObj);

            switch (gameObj.collisionType)
            {
                case CollisionType.wall:
                    return;
                case CollisionType.spike:
                    break;
                case CollisionType.air:
                    break;
                default:
                    break;
            }

            switch (direction)
            {
                case Direction.up:
                    if (player.posY == 1)
                        return;
                    player.move(0, -1);
                    break;
                case Direction.left:
                    if (player.posX == 1)
                        return;
                    player.move(-1, 0);
                    break;
                case Direction.down:
                    if (player.posY == 24)
                        return;
                    player.move(0, 1);
                    break;
                case Direction.right:
                    if (player.posX == 99)
                        return;
                    player.move(1, 0);
                    break;
            }
        }

        static GameObject detectObj(Direction direction, List<GameObject> objects)
        {
            GameObject lol = new GameObject();

            switch (direction)
            {
                case Direction.up:
                    lol = objects.Find(x => x.posX == player.posX && x.posY == player.posY - 1);
                    break;
                case Direction.left:
                    lol = objects.Find(x => x.posX == player.posX - 1 && x.posY == player.posY);
                    break;
                case Direction.down:
                    lol = objects.Find(x => x.posX == player.posX && x.posY == player.posY + 1);
                    break;
                case Direction.right:
                    lol = objects.Find(x => x.posX == player.posX + 1 && x.posY == player.posY);
                    break;
            }

            return lol;
        }

        public static void removeObject(GameObject gameObj)
        {
            objects.Remove(gameObj);
            Output.drawSingleObject(gameObj);
        }*/
    }
}
