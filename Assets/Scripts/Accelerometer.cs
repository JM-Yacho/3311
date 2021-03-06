﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public bool isflat = true;
    private Rigidbody rigid;
    private Transform camTransform;
    
    //Boost mechanic variables
    public float boostSpeed = 5.0f;

    private float lastBoost;

    private Collider playercollider;
    private float disttoground;
    public float jumpForce = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        

        rigid = GetComponent<Rigidbody>();
        camTransform = Camera.main.transform;

        playercollider = GetComponent<Collider>(); //for jump
        //Getting distance from ground
        disttoground = playercollider.bounds.extents.y;


    }

    void FixedUpdate()
    {
        Vector3 tilt = Input.acceleration;

        if (isflat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        }
        //Rotate our direction vector with camera
        Vector3 rotatedDir = camTransform.TransformDirection(tilt);
        rotatedDir = new Vector3(rotatedDir.x, 0, rotatedDir.z);
        rotatedDir = rotatedDir.normalized * tilt.magnitude;

        rigid.AddForce(rotatedDir);
    }
    /*
     * 
     * BUTTONS
     * 
     * 
     */
    public void Boost()
    {
        
            rigid.AddForce(rigid.velocity.normalized * boostSpeed, ForceMode.VelocityChange);
        
    }
    public void Jump()
    {
        bool IsGrounded = Physics.Raycast(transform.position, Vector3.down, disttoground + 0.1f);
        if (IsGrounded)
            rigid.AddForce(0, jumpForce, 0);
    }
}
