using System;

namespace CarSimulator
{
    static class Utility
    {
        /* Performs mathematical modulo on
         * integers, negative nominators
         * will give positive remainders.
         */
        public static int MathematicalModulo(int nominator, int denominator)
        {
            if (nominator >= 0)
            {
                return nominator % denominator;
            }
            else
            {
                return ((nominator % denominator) + denominator) % denominator;
            }
        }

        /* Checks whether input string
         * contains one character matching
         * the directions.
         */
        public static bool StringToChar(string input, out char output)
        {
            if (input.Length == 1)
            {
                if (input[0] == 'N' ||
                    input[0] == 'S' ||
                    input[0] == 'W' ||
                    input[0] == 'E')
                {
                    output = input[0];

                    return true;
                }
            }

            output = ' ';

            return false;
        }

        /* Checks whether input string
         * contains the correct command
         * characters.
         */
        public static bool CheckCommands(string commands)
        {
            for (var i = 0; i < commands.Length; i++)
            {
                if (commands[i] != 'F' &&
                    commands[i] != 'B' &&
                    commands[i] != 'L' &&
                    commands[i] != 'R')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
