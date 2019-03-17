using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class JumpMotor : MonoBehaviour
{

    private Rigidbody player;
    private Collider playercollider;
    private float disttoground;
    private float jumpForce = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        playercollider = GetComponent<Collider>();
        //Getting distance from ground
        disttoground = playercollider.bounds.extents.y;

    }
    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, disttoground + 0.1f);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       
            if(Input.touchCount == 1)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began && isGrounded())
                {
                player.AddForce(0, jumpForce, 0);
                }
                
            }
        
    }
}
