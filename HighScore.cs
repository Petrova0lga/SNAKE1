using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HighScore
{
    private string fileName;
    private List<ScoreEntry> scoreEntries;

    public HighScore(string fileName)
    {
        this.fileName = fileName;
        scoreEntries = new List<ScoreEntry>();
        LoadScore();
    }

    public void AddScore(string name, int score)
    {
        scoreEntries.Add(new ScoreEntry(name, score));
        scoreEntries = scoreEntries.OrderByDescending(s => s.Score).ToList();
        SaveScore();
    }

    public void PrintScore()
    {
        Console.WriteLine("High Score:");
        foreach (ScoreEntry scoreEntry in scoreEntries)
        {
            Console.WriteLine("{0}: {1}", scoreEntry.Name, scoreEntry.Score);
        }
    }

    private void LoadScore()
    {
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');
                    if (fields.Length == 2 && int.TryParse(fields[1], out int score))
                    {
                        scoreEntries.Add(new ScoreEntry(fields[0], score));
                    }
                }
            }
            scoreEntries = scoreEntries.OrderByDescending(s => s.Score).ToList();
        }
    }

    private void SaveScore()
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (ScoreEntry scoreEntry in scoreEntries)
            {
                writer.WriteLine("{0},{1}", scoreEntry.Name, scoreEntry.Score);
            }
        }
    }
}

public class ScoreEntry
{
    public string Name { get; set; }
    public int Score { get; set; }

    public ScoreEntry(string name, int score)
    {
        Name = name;
        Score = score;
    }
}
