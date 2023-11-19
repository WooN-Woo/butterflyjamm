using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorMovement : MonoBehaviour
{

    public float speed;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moves the car
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates the car 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
