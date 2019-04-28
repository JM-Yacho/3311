using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformAttach : MonoBehaviour
{
    public GameObject Player;
    public GameObject proxy;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            proxy.transform.parent = transform;
            Player.transform.parent = proxy.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        proxy.transform.parent = null;
        Player.transform.parent = null;
    }
}
