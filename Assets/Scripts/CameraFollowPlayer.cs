using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform Target;

    private Vector3 offset;
    private float distance = 5.0f;
    private float yOff = 1.5f;

    //Camera swiping variables
    private Vector2 touchpos;
    private float swipeRes = 100f;
    private Vector3 desiredPos;
    private float smoothspeed = 7.5f;


    
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, yOff, -1f * distance);
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            touchpos = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            float swipeforce = touchpos.x - Input.mousePosition.x;
            if (Mathf.Abs(swipeforce) > swipeRes)
            {
                //There is a swipe!
                if (swipeforce < 0) //Left swipe
                    SlideCamera(true);
                else
                    SlideCamera(false);
            }
        }
    }
    private void FixedUpdate()
    {
        desiredPos = Target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, smoothspeed * Time.deltaTime);
        transform.LookAt(Target.position + Vector3.up);
    }

    public void SlideCamera(bool left)
    {
        //If not left, then right by default
        if (left)
        {
            offset = Quaternion.Euler(0, 90, 0) * offset;
        }
        else
        {
            offset = Quaternion.Euler(0, -90, 0) * offset;
        }
    }
}
