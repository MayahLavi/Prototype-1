using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 10.0f;
    private float turnspeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // get player input
        horizontalInput =  Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // move vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // turn vehicle
        transform.Rotate(Vector3.up,Time.deltaTime * turnspeed * horizontalInput);

    }
}
