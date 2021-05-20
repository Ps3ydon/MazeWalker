
using System;

namespace MazeWalker.gameObjects.entity
{
    public enum EntityBehavement
    {
        aggressive,
        assertive,
        passive
    }

    public class Entity : GameObject
    {
        public int maxHp = 10, hp;
        public int oldX, oldY;
        EntityBehavement behavement;
        byte speed = 1, getActiveRange = 5;

        public Entity(char symbol = '☺', CollisionType collisionType = CollisionType.wall, EntityBehavement behavement = EntityBehavement.assertive) : base(symbol, collisionType) { }
        public Entity(int posX, int posY, char symbol = '☺', CollisionType collisionType = CollisionType.wall, EntityBehavement behavement = EntityBehavement.assertive) : base(posX, posY, symbol, collisionType)
        {
            hp = maxHp;
        }

        public void calcMove()
        {
            Random r = new Random();
            byte direction = (byte) r.Next(4);

            collision((Direction)direction);

            Output.drawSingleObject(this);
        }

        public void calcMove(Direction direction)
        {
            collision(direction);

            Output.drawSingleObject(this);
        }

        void move(int moveX, int moveY)
        {
            oldX = posX;
            oldY = posY;
            Output.drawSingleObject(posX, posY, ' ');
            posX += moveX;
            posY += moveY;
        }

        void move(Direction direction)
        {
            switch (direction)
            {
                case Direction.up:
                    if (posY == 1)
                        return;
                    move(0, -1);
                    break;
                case Direction.left:
                    if (posX == 1)
                        return;
                    move(-1, 0);
                    break;
                case Direction.down:
                    if (posY == 24)
                        return;
                    move(0, 1);
                    break;
                case Direction.right:
                    if (posX == 99)
                        return;
                    move(1, 0);
                    break;
            }
        }

        double calcDistanceTo(GameObject obj)
        {
            double distanceX = posX - obj.posX;
            double distanceY = posY - obj.posY;

            return Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
        }

        void collision(Direction direction)
        {
            GameObject gameObj = ObjectManager.detectObj(direction, this);
            if (gameObj != null)
            {
                gameObj.ObjectFunction((Player)this, gameObj);

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
            }

            move(direction);
        }
    }
}
