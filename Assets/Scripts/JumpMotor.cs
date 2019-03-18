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
    private bool is_tap, moved;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        playercollider = GetComponent<Collider>();
        //Getting distance from ground
        disttoground = playercollider.bounds.extents.y;

    }
    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, disttoground + 0.1f);
    }
    //Makes sure jumping and camera changing dont interfer with each other
    public bool IsTap(Touch touch)
    {
        switch (touch.phase)
        {
            case TouchPhase.Began:
                is_tap = true;
                break;
            case TouchPhase.Moved:
                is_tap = false;
                moved = true;
                break;
            case TouchPhase.Ended:
                is_tap = true;
                break;
        }
        if (moved == false && is_tap)
            return true;
        else
            return false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
            if(Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began && IsGrounded() && IsTap(Input.GetTouch(0)))
                {
                player.AddForce(0, jumpForce, 0);
                }
                
            }
        
    }
}
