using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectKey : MonoBehaviour
{
    public bool collected;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        collected = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (collected == false && other.gameObject == Player)
        {
            collected = true;
            GetComponentInChildren<Renderer>().enabled = false;
        }
    }


}
