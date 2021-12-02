using System;
using System.Diagnostics;

namespace AdventOfCode2021.Puzzles
{
    public class PuzzleSolver
    {
        private PuzzleFactory puzzleFactory;
        private PuzzleBase puzzleToSolve;

        private int day;
        private int part = -1;

        private bool isSolving;

        public PuzzleSolver()
        {
            puzzleFactory = new PuzzleFactory();
            puzzleFactory.Initialize();
        }

        public void Start(string[] args)
        {
            isSolving = true;
            string puzzleInput;
            while (isSolving)
            {

                Console.WriteLine("Enter Puzzle day and part: day,part");
                puzzleInput = Console.ReadLine();

                if (puzzleInput.StartsWith('q'))
                {
                    isSolving = false;
                    continue;
                }

                if(!GetDayAndPart(puzzleInput, out day, out part))
                {
                    Console.WriteLine("Invalid input..");
                    continue;
                }

                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                puzzleToSolve = puzzleFactory.GetPuzzle(day, part);

                if (puzzleToSolve != null)
                    Console.WriteLine("Solution: " + puzzleToSolve.GetSolution());
                else
                    Console.WriteLine("Puzzle not found..");

                stopwatch.Stop();
                Console.WriteLine(stopwatch.ElapsedMilliseconds + "ms " + stopwatch.ElapsedTicks + "ticks");
            }
        }

        private bool GetDayAndPart(string puzzleInput, out int day, out int part)
        {
            string[] puzzleInputData;
            day = -1;
            part = -1;

            if(string.IsNullOrEmpty(puzzleInput))
                return false;

            puzzleInputData = puzzleInput.Split(',');

            if(!int.TryParse(puzzleInputData[0], out day))
                return false;

            if(puzzleInputData.Length > 1 && !int.TryParse(puzzleInputData[1], out part))
                part = -1;

            return true;
        }
    }
}
