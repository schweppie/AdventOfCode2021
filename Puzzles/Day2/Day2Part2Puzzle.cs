using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2021.Puzzles.Day2
{
    public class Day2Part2Puzzle : Day2Puzzle
    {
        public override string GetSolution()
        {
            Regex regex = new Regex(@"(forward|up|down) (\d)");

            int distance = 0;
            int depth = 0;
            int aim = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                MatchCollection matchedCommands = regex.Matches(lines[i]);

                string command = matchedCommands[0].Groups[1].ToString();
                int value = int.Parse(matchedCommands[0].Groups[2].ToString());

                switch(command)
                {
                    case "up":
                        aim -= value;
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "forward":
                        distance += value;
                        depth += (aim * value);
                        break;
                }
            }

            return (distance * depth).ToString();
        }
    }
}
