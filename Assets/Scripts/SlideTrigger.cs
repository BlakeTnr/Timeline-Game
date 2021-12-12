using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTrigger : MonoBehaviour
{

    public int slideID;
    private Slide slide;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        slide = new Slide(slideID);
        slide.display();
    }

    private void OnTriggerExit(Collider other)
    {
        slide.destroy();
    }
}
