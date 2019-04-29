using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyContain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Enemy"))
        {
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
