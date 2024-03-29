using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    public float runSpeed = 9f;
    float targetMovingSpeed;
    public bool canRun = true;
    public bool isRunning;
    public KeyCode runningKey = KeyCode.LeftShift;
    private Rigidbody playerRigidbody;
    void Awake()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
        playerRigidbody.velocity =
            transform.rotation *
            new Vector3(Input.GetAxis("Horizontal"), playerRigidbody.velocity.y, Input.GetAxis("Vertical")
            * targetMovingSpeed);
         transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time .deltaTime),
             Space.Self);
    }

    
    void FixedUpdate()
    {

    
        if (canRun && Input.GetKey (runningKey))
        {
            isRunning = true;

    }
        
     else
    {
            isRunning = false;
            {
                playerRigidbody.velocity =
           transform.rotation *
           new Vector3(Input.GetAxis("Horizontal"), playerRigidbody.velocity.y, Input.GetAxis("Vertical")
           * targetMovingSpeed);
                transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime),
                    Space.Self);
            }
        }
