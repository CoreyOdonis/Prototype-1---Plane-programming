using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make the propeller spin per frame
public class SpinPropellerX : MonoBehaviour
{
    private float propellorSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
