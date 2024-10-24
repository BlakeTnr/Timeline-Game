using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    public GameObject positiveEnding;
    public GameObject negativeEnding;
    public GameObject equalEnding;

    private void OnTriggerEnter(Collider other)
    {
        int side = PerceptionMeter.perceptionMeterInstance.getSide();

        switch (side)
        {
            case 1:
                GameObject.Instantiate(positiveEnding);
                break;

            case -1:
                GameObject.Instantiate(negativeEnding);
                break;

            case 0:
                GameObject.Instantiate(equalEnding);
                break;
        }
    }
}
