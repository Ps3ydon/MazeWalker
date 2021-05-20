using System.Collections.Generic;
using System.IO;

namespace MazeWalker
{
    static class fileIO
    {
        public static List<gameObjects.GameObject> loadMap(string file, bool originalTextures = true)
        {
            List<gameObjects.GameObject> objects = new List<gameObjects.GameObject>();
            string[] mapRow;

            if (File.Exists(file))
            {
                mapRow = File.ReadAllLines(file);
            }
            else
                return null;

            for (int i = 0; i < mapRow.Length; i++)
                for (int i_ = 0; i_ < mapRow[i].Length; i_++)
                {
                    if (mapRow[i].ToCharArray()[i_] != ' ')
                    {
                        gameObjects.GameObject gameObj;

                        switch (mapRow[i].ToCharArray()[i_])
                        {
                            case '▒':
                                gameObj = new gameObjects.Door(i_, i + 1);
                                break;
                            case '▲':
                                gameObj = new gameObjects.Spike(i_, i + 1);
                                break;
                            case '?':
                                gameObj = new gameObjects.collectable.Key(i_, i + 1);
                                break;
                            case '♥':
                                gameObj = new gameObjects.collectable.Heart(i_, i + 1);
                                break;
                            case 'O':
                                gameObj = new gameObjects.collectable.Apple(i_, i + 1);
                                break;
                            default:
                                gameObj = new gameObjects.Wall(i_, i + 1);
                                break;
                        }
                        if (originalTextures)
                            gameObj.symbol = mapRow[i].ToCharArray()[i_];
                        objects.Add(gameObj);
                    }
                }

            return objects;
        }
    }
}
