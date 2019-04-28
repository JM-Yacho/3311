using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceTrap : MonoBehaviour
{
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("bounceTrap"))
        {
            // how much the character should be knocked back
            var magnitude = 100;
            // calculate force vector
            var force = transform.position - other.transform.position;
            // normalize force vector to get direction only and trim magnitude
            force.Normalize();
            gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
        }
    }
}
