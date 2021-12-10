using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate() {
        carControllerUpdate();
    }

    public float maxAcceleration;
    private void carControllerUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rigidbody.AddForce(new Vector3(0, 0, vertical*maxAcceleration));
        capSpeed();
    }

    public float maxSpeed;
    private void capSpeed() {
        if(rigidbody.velocity.z > maxSpeed) {
            float preserveSign = Mathf.Sign(rigidbody.velocity.z);
            Vector3 velocity = rigidbody.velocity;
            velocity.z = preserveSign * maxSpeed;
            rigidbody.velocity = velocity;
        }
    }
}
