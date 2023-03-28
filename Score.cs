using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Score
{
    private int score;

    public Score()
    {
        score = 0;
    }

    public void AddPoints(int points)
    {
        score += points;
    }

    public int GetScore()
    {
        return score;
    }

    public void Reset()
    {
        score = 0;
    }
}
