/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Milo Wearn
- Assignment: Week 9: Score Stats (Methods + LINQ)
-
- What does this program do?:
- Defines a ScoreReport class students complete using LINQ methods.
- */

using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;

namespace ScoreStats;

internal class ScoreReport
{
    private readonly int[] _scores;

    public ScoreReport(int[] scores, int threshold)
    {
        _scores = scores;
        Threshold = threshold;
    }

    public int Threshold { get; }

    public int Count => _scores.Length;

    // calls everything to print a report.
    public void PrintReport()
    {
        PrintBasicStats();
        PrintPassingFailingCounts();
        PrintScoresSorted();
        PrintTopScores(3);
        PrintPassingScores();
        PrintFailingScores();
    }

    // prints the following
    // Count: W
    // Min: X
    // Max: Y
    // Average: Z  (formatted to 1 decimal place)
    // where W is the total score count, X is the minimum score, Y is the maximum score, and Z is the average of all scores.
    private void PrintBasicStats()
    {
        int minScores = _scores.Min();
        int maxScores = _scores.Max();
        double avgScores = _scores.Average();

        Console.WriteLine($"Count: {_scores.Length}\nMin: {minScores}\nMax: {maxScores}\nAverage: {avgScores:F1}");
    }

    // prints the following
    // Passing (>=threshold): X
    // Failing (<threshold): Y
    // where X is the list of passing scores and Y is the list of failing scores
    private void PrintPassingFailingCounts()
    {
        int passCount = _scores.Count(score => score >= Threshold);
        int failCount = _scores.Count(score => score < Threshold);

        Console.WriteLine($"Passing (>={Threshold}): {passCount}\nFailing (<{Threshold}): {failCount}");
    }

    // prints scores sorted in ascending order "Sorted (asc): {list}"
    private void PrintScoresSorted()
    {
        string formattedScores = string.Join(", ", _scores.OrderBy(score => score));

        Console.WriteLine($"Sorted (asc): {formattedScores}");
    }

    // prints top scores as "Top X: {list}" where X is topCount
    private void PrintTopScores(int topCount)
    {
        string topScoresFormatted = string.Join(", ", _scores.OrderByDescending(score => score).Take(topCount));

        Console.WriteLine($"Top {topCount}: {topScoresFormatted}");
    }

    // prints passing scores as "Passing scores (desc): {list}"
    private void PrintPassingScores()
    {
        string formattedScores = string.Join(", ", _scores.Where(score => score >= Threshold).OrderByDescending(score => score));

        Console.WriteLine($"Passing scores (desc): {formattedScores}");
    }

    // prints failing scores as "Failing scores (desc): {list}"
    private void PrintFailingScores()
    {
        string failingScoresFormatted = string.Join(", ", _scores.Where(score => score < Threshold).OrderByDescending(score => score));

        Console.WriteLine($"Failing scores (desc): {failingScoresFormatted}");
    }
}
