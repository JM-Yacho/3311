using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject Player;
    public GameObject Spawn;
    public GameObject key;
    private bool hit;

    void Start()
    {
        hit = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hit == false && other.gameObject == Player && key.GetComponent<collectKey>().collected == true)
        {
            hit = true;
            Spawn.transform.position = transform.position;
        }
    }
}
