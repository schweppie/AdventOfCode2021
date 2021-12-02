namespace AdventOfCode2021.Puzzles.Day1
{
    public class Day1Part1Puzzle : Day1Puzzle
    {
        public override string GetSolution()
        {
            int increasedMeasurements = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                int previousDepth = int.Parse(lines[i-1]);
                int currentDepth = int.Parse(lines[i]);

                increasedMeasurements += currentDepth > previousDepth ? 1 : 0;
            }

            return increasedMeasurements.ToString();
        }
    }
}
