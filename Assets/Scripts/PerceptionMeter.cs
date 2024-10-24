using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptionMeter
{
    public int perceptionAmount = 0; // positive = good side, negative = bad side
    public static PerceptionMeter perceptionMeterInstance = new PerceptionMeter();

    private PerceptionMeter()
    {
    }

    public void addPerception(int amount)
    {
        perceptionAmount += amount;
    }

    public int getSide()
    {
        if (perceptionAmount > 0)
        {
            return 1;
        }

        if (perceptionAmount < 0)
        {
            return -1;
        }

        return 0;
    }
}
