using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit_3Keys : MonoBehaviour
{
    public GameObject Player;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && key1.GetComponent<collectKey>().collected == true && key2.GetComponent<collectKey>().collected == true && key3.GetComponent<collectKey>().collected == true)
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
