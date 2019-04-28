using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallOff : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody rigid;
    public Transform respawnpoint;
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);        
        }
    }
}
