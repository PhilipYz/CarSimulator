using System;

namespace CarSimulator
{
    class InputParser
    {
        int _roomX;
        public int RoomX { get { return _roomX; } }

        int _roomY;
        public int RoomY { get { return _roomY; } }

        int _positionX;
        public int PositionX { get { return _positionX; } }

        int _positionY;
        public int PositionY { get { return _positionY; } }

        char _direction;
        public char Direction { get { return _direction; } }

        string _commands;
        public string Commands { get { return _commands; } }

        /* Parses the input and handles
         * any errors by forcing the user
         * to retype the parameters. 
         */
        public void Parse()
        {
            string inputString;
            string[] inputs;

            do
            {
                Console.WriteLine("Enter room dimensions (X Y), X and Y must be positive integers");

                inputString = Console.ReadLine();
                inputs = inputString.Split(' ');
            } while (inputs.Length != 2 ||
                     !Int32.TryParse(inputs[0], out _roomX) ||
                     !Int32.TryParse(inputs[1], out _roomY) ||
                     _roomX <= 0 || _roomY <= 0);

            _roomX = _roomX - 1;
            _roomY = _roomY - 1;

            do
            {
                Console.WriteLine("Enter car position and direction (X Y D), position must be inside room and direction must be N/S/W/E");

                inputString = Console.ReadLine();
                inputs = inputString.Split(' ');
            } while (inputs.Length != 3 ||
                     !Int32.TryParse(inputs[0], out _positionX) ||
                     !Int32.TryParse(inputs[1], out _positionY) ||
                     _positionX < 0 || _positionX > _roomX ||
                     _positionY < 0 || _positionY > _roomY ||
                     !Utility.StringToChar(inputs[2], out _direction)
                     );

            do
            {
                Console.WriteLine("Enter commands (CCC...), commands are F/B/L/R");

                _commands = Console.ReadLine();
            } while (!Utility.CheckCommands(_commands));
        }
    }
}
