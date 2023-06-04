using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 5.0f;
    [SerializeField]
    float turnSpeed=1;
    [SerializeField]
    float horizontalInput;
    [SerializeField]
    float forwardlInput;
    void Start()
    {

    }

    void Update()
    {
        //Get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");

        //Move the vehicle based on verticle input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardlInput);
        //Rotate the vehicle based on hprizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*horizontalInput);
    }
}
