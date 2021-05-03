using System;

namespace CarSimulator
{
    class Simulator
    {
        int RoomX;
        int RoomY;

        Car Car;

        String Commands;

        public Simulator(int roomX, int roomY, int positionX, int positionY, char direction, string commands)
        {
            RoomX = roomX;
            RoomY = roomY;

            Car = new MonsterTruck(positionX, positionY, direction);

            Commands = commands;
        }

        /* Iterates every command. In
         * each iteration, the command
         * is handled before checking
         * whether the car has hit a wall.
         */
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("Running simulation");

            foreach (var c in Commands)
            {
                HandleCommand(c);

                if (CheckBounds() == true)
                {
                    return;
                }
            }

            Console.WriteLine("Simulation was successful");
            Console.WriteLine("Position: [" + Car.PositionX + ", " + Car.PositionY + "] Direction: " + Car.Direction);
        }

        /* Either moves or turns the car,
         * depending on the command.
         */
        void HandleCommand(char command)
        {
            switch (command)
            {
                case 'F':
                case 'B':
                    Car.Move(command);
                    break;
                case 'L':
                case 'R':
                    Car.Turn(command);
                    break;
                default:
                    break;
            }
        }

        /* Checks whether the car has
         * hit a wall and prints
         * the wall if it has.
         */
        bool CheckBounds()
        {
            var wall = "";

            if (Car.PositionY > RoomY)
            {
                wall = "north";
            }
            else if (Car.PositionY < 0)
            {
                wall = "south";
            }
            else if (Car.PositionX < 0)
            {
                wall = "west";
            }
            else if (Car.PositionX > RoomX)
            {
                wall = "east";
            }
            else
            {
                return false;
            }

            Console.WriteLine("Simulation failed");
            Console.WriteLine("Car hit " + wall + " wall");

            return true;
        }
    }
}
