using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Levels
{
    private int level;
    private int speed;

    public Levels()
    {
        level = 1;
        speed = 5;
    }

    public int GetLevel()
    {
        return level;
    }

    public int GetSpeed()
    {
        return speed;
    }

    public void IncreaseLevel()
    {
        level++;
        speed += 2;
    }
}