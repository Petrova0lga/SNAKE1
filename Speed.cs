using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Speed
{
    private float speed;
    private float acceleration;
    private float maxSpeed;

    public Speed(float initialSpeed, float initialAcceleration, float maxSpeed)
    {
        speed = initialSpeed;
        acceleration = initialAcceleration;
        this.maxSpeed = maxSpeed;
    }

    public float GetSpeed()
    {
        return speed;
    }

    public void IncreaseSpeed()
    {
        speed += acceleration;
        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }
    }

    public void Reset()
    {
        speed = 0;
    }
}
