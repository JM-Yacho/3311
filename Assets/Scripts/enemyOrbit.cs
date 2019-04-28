using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyOrbit : MonoBehaviour
{
    public GameObject focalPoint;
    private float speed = 75;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(focalPoint.transform.position, Vector3.down, speed * Time.deltaTime);
    }
}
