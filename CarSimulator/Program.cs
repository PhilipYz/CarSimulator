using System;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputParser = new InputParser();
            inputParser.Parse();

            var simulator = new Simulator(inputParser.RoomX, inputParser.RoomY, inputParser.PositionX, inputParser.PositionY, inputParser.Direction, inputParser.Commands);
            simulator.Run();

            Console.ReadKey();
        }
    }
}
