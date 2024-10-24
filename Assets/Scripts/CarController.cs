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

    private void FixedUpdate()
    {
        carControllerUpdate();
    }

    public float maxAcceleration;
    public float maxTurningAmount;

    private float horizontalInput;
    private float verticalInput;
    private void carControllerUpdate()
    {
        updateInputs(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        handleAccelerating();
        handleTurning();
    }

    private void handleAccelerating()
    {
        Vector3 worldFromLocalAcceleration = transform.TransformVector(new Vector3(0, 0, verticalInput * maxAcceleration));
        rigidbody.AddForce(worldFromLocalAcceleration);
        capSpeed();
    }

    public void updateInputs(float horizontal, float vertical)
    {
        this.horizontalInput = horizontal;
        this.verticalInput = vertical;
    }

    private void handleTurning()
    {
        gameObject.transform.Rotate(new Vector3(0, horizontalInput * maxTurningAmount, 0));
    }

    public float maxSpeed;
    private void capSpeed()
    {
        if (rigidbody.velocity.z > maxSpeed)
        {
            float preserveSign = Mathf.Sign(rigidbody.velocity.z);
            Vector3 velocity = rigidbody.velocity;
            velocity.z = preserveSign * maxSpeed;
            rigidbody.velocity = velocity;
        }
    }
}
