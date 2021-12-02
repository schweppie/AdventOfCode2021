namespace AdventOfCode2021.Puzzles.Day1
{
    public class Day1Part2Puzzle : Day1Puzzle
    {
        public override string GetSolution()
        {
            int increasedMeasurements = 0;

            for (int i = 0; i < lines.Length-1; i++)
            {
                int previousSum = GetMeasurementSum(i);
                int currentSum = GetMeasurementSum(i+1);

                increasedMeasurements += currentSum > previousSum ? 1 : 0;
            }

            return increasedMeasurements.ToString();
        }

        private int GetMeasurementSum(int index)
        {
            int sum = 0;

            for (int i = index; i < index + 3; i++)
            {
                if (i < lines.Length)
                    sum += int.Parse(lines[i]);
            }

            return sum;
        }
    }
}
