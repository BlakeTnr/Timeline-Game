using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBooster : MonoBehaviour
{

    public float accelerationModifier;
    public Text noticeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        float maxAcceleration = other.gameObject.GetComponent<CarController>().maxAcceleration;
        other.gameObject.GetComponent<CarController>().maxAcceleration += accelerationModifier * maxAcceleration;
        sendAccelerationNotice();
    }

    private void sendAccelerationNotice() {
        if(accelerationModifier > 0) {
            sendNotice("You're aproaching civil war faster!");
            return;
        }

        if(accelerationModifier < 0) {
            sendNotice("You've slowed down, for now");
            return;
        }
    }

    private void sendNotice(System.String text) {
        noticeText.text = text;
        Invoke("resetNotice", 5);
    }

    private void resetNotice() {
        noticeText.text = "";
    }
}
