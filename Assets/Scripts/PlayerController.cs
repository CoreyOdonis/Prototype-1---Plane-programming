using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 5.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
      // This is where we get player input
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
      // Move the vehicle forward based on vertical input
      transform.Translate(Vector3.forward *Time.deltaTime * speed * forwardInput);
      
      // Rotates the car based on horizontal input
      transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
