using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    public GameObject slidePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Slide.slidePrefab = slidePrefab;
        Slide slide = new Slide(2);
        slide.display();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
