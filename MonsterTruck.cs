using System;

namespace CarSimulator
{
    class MonsterTruck : Car
    {
        public MonsterTruck(int positionX, int positionY, char direction) : base(positionX, positionY, direction)
        {

        }

        /* Modifies the position of the car 
         * based on the direction and
         * whether the car is moving forwards
         * or backwards.
         */
        public override void Move(char movement)
        {
            var move = 0;

            if(movement == 'F')
            {
                move = 1;
            }
            else if(movement == 'B')
            {
                move = -1;
            }

            switch (Direction)
            {
                case Direction.North:
                    PositionY += move;
                    break;
                case Direction.South:
                    PositionY -= move;
                    break;
                case Direction.West:
                    PositionX -= move;
                    break;
                case Direction.East:
                    PositionX += move;
                    break;
                default:
                    break;
            }
        }

        /* Modifies the direction of the car 
         * based on the current direction and
         * whether the car is turning left
         * or right.
         */
        public override void Turn(char rotation)
        {
            switch (rotation)
            {
                case 'L':
                    Direction = (Direction)Utility.MathematicalModulo((int)--Direction, Enum.GetNames(typeof(Direction)).Length);
                    break;
                case 'R':
                    Direction = (Direction)Utility.MathematicalModulo((int)++Direction, Enum.GetNames(typeof(Direction)).Length);
                    break;
                default:
                    break;
            }
        }
    }
}
