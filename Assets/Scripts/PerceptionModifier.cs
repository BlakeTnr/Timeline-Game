using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PerceptionModifier : MonoBehaviour
{

    private Stopwatch stopwatch;
    private bool triggered = false;
    public int perceptionAmount;

    private void OnTriggerEnter(Collider other)
    {
        startStopwatch();
    }

    private void OnTriggerExit(Collider other)
    {
        stopwatch.Stop();

        if (stopwatch.Elapsed.TotalSeconds > 5 && !triggered)
        {
            triggered = true;
            PerceptionMeter.perceptionMeterInstance.addPerception(perceptionAmount);
        }
    }

    private void startStopwatch()
    {
        if (stopwatch == null)
        {
            stopwatch = new Stopwatch();
        }

        stopwatch.Start();
    }

}
