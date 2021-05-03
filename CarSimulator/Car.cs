using System;


namespace CarSimulator
{
    enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3
    };

    abstract class Car
    {
        public int PositionX { get; protected set; }
        public int PositionY { get; protected set; }

        public Direction Direction { get; protected set; }

        protected Car(int positionX, int positionY, char direction)
        {
            PositionX = positionX;
            PositionY = positionY;

            switch (direction)
            {
                case 'N':
                    Direction = Direction.North;
                    break;
                case 'S':
                    Direction = Direction.South;
                    break;
                case 'W':
                    Direction = Direction.West;
                    break;
                case 'E':
                    Direction = Direction.East;
                    break;
                default:
                    break;
            }
        }

        public abstract void Move(char movement);

        public abstract void Turn(char rotation);
    }
}
